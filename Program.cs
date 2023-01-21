using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using CsvHelper;
using System.IO;
using CsvHelper.Configuration;
using System.Globalization;
using System.Data;

namespace HLTV_Stats_Collector
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            bool playerDataExists = File.Exists("player_data.csv");

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };


            using (var stream = File.Open("player_data.csv", FileMode.OpenOrCreate))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {

                string statsUrl = "https://www.hltv.org/stats/players";
                HtmlWeb web = new HtmlWeb();
                web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36";
                HtmlAgilityPack.HtmlDocument doc = web.Load(statsUrl);

                if (doc.DocumentNode != null)
                {
                    if (!playerDataExists)
                    {
                        Console.WriteLine("Player data doesn't exist, adding...");
                        csv.WriteField("Name");
                        csv.WriteField("Id");
                        csv.NextRecord();

                        foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//td[@class='playerCol ']/a[@href]"))
                        {
                            string playerUrl = link.Attributes["href"].Value;
                            string[] urlParts = playerUrl.Split('/');
                            string playerId = urlParts[urlParts.Length - 2];
                            string playerName = urlParts[urlParts.Length - 1];

                            // Write the player name and id to the CSV file
                            csv.WriteField(playerName);
                            csv.WriteField(playerId);
                            csv.NextRecord();
                        }
                        Console.WriteLine("Added successfully");

                    } else
                    {
                        Console.WriteLine("Player data is complete, skipping the scraping of stats");
                    }
                }
                else
                {
                    Console.WriteLine("doc.DocumentNode is null");
                }
            }

            /* To check the functionality of name to id */
            //using (var reader = new StreamReader("player_data.csv"))
            //using (var csv = new CsvReader(reader, config))
            //{
            //    csv.Read();
            //    csv.ReadHeader();
            //    while (csv.Read())
            //    {
            //        var name = csv.GetField("Name");
            //        var id = csv.GetField("Id");
            //        if (name == "jamppi")
            //        {
            //            Console.WriteLine("Player id for " + name + " is " + id);
            //        }
            //    }
            //}

            //  Take turns looping group-2 then group-1 and so on
            //  team 1 name, rounds for team 1, team 2 name, rounds for team 2  //tr[@class='group-2 first']//div[@class='gtSmartphone-only']//span/text()
            //  team 1 name, rounds for team 1, team 2 name, rounds for team 2  //tr[@class='group-1 first']//div[@class='gtSmartphone-only']//span/text()
            //  K-D Ratio                                                       //tr[@class='group-2 first']//td[@class='statsCenterText']
            //  Rating                                                          //tr[@class='group-2 first']//td[contains(@class, 'match-')]

            //matchResultAndRating("zywoo", "de_mirage"); 
            //matchDate("zywoo", "de_mirage");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static string convertNameToId (string playerName)
        {
            using (var reader = new StreamReader("player_data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var name = csv.GetField("Name");
                    var id = csv.GetField("Id");
                    if (name == playerName)
                    {
                        Console.WriteLine("Converted name to id from:" + name + " is " + id);
                        return id;
                    }
                }
            }
            Console.WriteLine("Convert Failed");
            return "null";
        }

        public static void matchResultAndRating(string playerName, string map)
        {
            string playerId = convertNameToId(playerName);

            string matchResult = "unknown";
            double rating = 0.00;

            string statsUrl = $"https://www.hltv.org/stats/players/matches/{playerId}/{playerName}?maps={map}";
            HtmlWeb web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36";
            HtmlAgilityPack.HtmlDocument doc = web.Load(statsUrl);
               foreach (HtmlNode tdNode in doc.DocumentNode.SelectNodes("//td[contains(@class, 'match-')]"))
                {
                matchResult = "unknown";

                rating = 0.00;
                if (tdNode.Attributes["class"].Value.Contains("match-won"))
                {
                    matchResult = "won";
                    if (!double.TryParse(tdNode.InnerText.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out rating))
                    {
                        Console.WriteLine("Error gathering rating");
                    }
                }
                else if (tdNode.Attributes["class"].Value.Contains("match-lost"))
                {
                    matchResult = "lost";
                    if (!double.TryParse(tdNode.InnerText.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out rating))
                    {
                        Console.WriteLine("Error gathering rating");
                    }
                }
                //Used for testing
                //Console.WriteLine("The match was " + matchResult + " with rating " + rating);
            }
        }

        public static void matchDate(string playerName, string map, DataGridView playerDataSheet)
        {
            string playerId = convertNameToId(playerName);

            if (playerId == "null")
            {
                return;
            }

            DateTime dateValue;
            string format = "d/M/yy";

            string statsUrl = $"https://www.hltv.org/stats/players/matches/{playerId}/{playerName}?maps={map}";
            HtmlWeb web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36";
            HtmlAgilityPack.HtmlDocument doc = web.Load(statsUrl);

            foreach (HtmlNode dateNode in doc.DocumentNode.SelectNodes("//div[@class='time']"))
            {
                    dateValue = default(DateTime);
                    if (!DateTime.TryParseExact(dateNode.InnerText.Trim(), format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                    //if (!DateTime.TryParse(dateNode.InnerText.Trim(), out dateValue))
                    {
                        Console.WriteLine("Error gathering date");
                    }
                Console.WriteLine("Date: " + dateValue.ToString("dd/MM/yyyy"));
                int rowIndex = playerDataSheet.Rows.Add();
                playerDataSheet.Rows[rowIndex].Cells["Date"].Value = dateValue.ToString("dd/MM/yyyy");
            }
        }


    }
}
