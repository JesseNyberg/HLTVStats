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




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }
}
