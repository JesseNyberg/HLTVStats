using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Globalization;
using System.Data;
using System.Drawing;
using HtmlAgilityPack;
using CsvHelper;
using CsvHelper.Configuration;

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


            if (!playerDataExists)
            {


                using (var stream = File.Open("player_data.csv", FileMode.OpenOrCreate))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {

                    string statsUrl = "https://www.hltv.org/stats/players?minMapCount=0";
                    HtmlWeb web = new HtmlWeb();
                    web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36";
                    HtmlAgilityPack.HtmlDocument doc = web.Load(statsUrl);

                    if (doc.DocumentNode.SelectSingleNode("//td[@class='playerCol ']/a[@href]") != null)
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
                    }
                    else
                    {
                        Console.WriteLine("doc.DocumentNode is null");
                    }
                }
            } 
            else
            {
                Console.WriteLine("Player data exists, skipping...");
            }

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
            MessageBox.Show("Name not found, check your syntax", "Information", MessageBoxButtons.OK);

            return "null";
        }

        public static void matchResultAndRating(string playerName, string map, DataGridView playerDataSheet, string startDate, string ranking, ref double avgRating)
        {
            string playerId = convertNameToId(playerName.ToLower());
            string statsUrl;

            double rating = 0.00;

            int rowIndex = 0;

            DateTime currentDate = DateTime.Today;
            string formattedCurrentDate = currentDate.ToString("yyyy-MM-dd");

            if (startDate == "")
            {
                statsUrl = $"https://www.hltv.org/stats/players/matches/{playerId}/{playerName}?maps={map}";
            } else
            {
                statsUrl = $"https://www.hltv.org/stats/players/matches/{playerId}/{playerName}?startDate={startDate}&endDate={formattedCurrentDate}&maps={map}";
            }

            if (ranking != "All")
            {
                statsUrl += $"&rankingFilter={ranking.Trim().Replace(" ", "")}";
            }

            HtmlWeb web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36";
            HtmlAgilityPack.HtmlDocument doc = web.Load(statsUrl);

               foreach (HtmlNode tdNode in doc.DocumentNode.SelectNodes("//td[contains(@class, 'match-')]"))
                {

                rating = 0.00;

                if (!double.TryParse(tdNode.InnerText.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out rating))
                {
                    Console.WriteLine("Error gathering rating");
                }

                    playerDataSheet.Rows[rowIndex++].Cells["playerRating"].Value = rating;
                    avgRating += rating;
                }

            avgRating /= rowIndex;
        }

        public static bool matchDate(string playerName, string map, DataGridView playerDataSheet, string startDate, string ranking)
        {
            string playerId = convertNameToId(playerName.ToLower());
            string statsUrl;

            if (playerId == "null")
            {
                return false;
            }

            DateTime dateValue;
            string format = "d/M/yy";
            DateTime currentDate = DateTime.Today;
            string formattedCurrentDate = currentDate.ToString("yyyy-MM-dd");

            if (startDate == "")
            {
                statsUrl = $"https://www.hltv.org/stats/players/matches/{playerId}/{playerName}?maps={map}";
            }
            else
            {
                statsUrl = $"https://www.hltv.org/stats/players/matches/{playerId}/{playerName}?startDate={startDate}&endDate={formattedCurrentDate}&maps={map}";
            }

            if (ranking != "All")
            {
                statsUrl += $"&rankingFilter={ranking.Trim().Replace(" ", "")}";
            }

            HtmlWeb web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36";
            HtmlAgilityPack.HtmlDocument doc = web.Load(statsUrl);

            if (doc.DocumentNode.SelectSingleNode("//div[@class='time']") == null)
            {
                MessageBox.Show("No results found\n(or you're rate limited)", "Information", MessageBoxButtons.OK);
                return false;
            }

            foreach (HtmlNode dateNode in doc.DocumentNode.SelectNodes("//div[@class='time']"))
            {
                dateValue = default(DateTime);

                if (!DateTime.TryParseExact(dateNode.InnerText.Trim(), format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                    {
                        Console.WriteLine("Error gathering date");
                    }

                Console.WriteLine("Date: " + dateValue.ToString("dd/MM/yyyy"));

                int rowIndex = playerDataSheet.Rows.Add();
                playerDataSheet.Rows[rowIndex].Cells["matchDate"].Value = dateValue.ToString("dd/MM/yyyy");
            }

            return true;
        }

        public static void matchTeamsAndRounds(string playerName, string map, DataGridView playerDataSheet, string startDate, string ranking, ref double allRounds, ref double avgRounds)
        {
            string playerId = convertNameToId(playerName.ToLower());
            string statsUrl;

            DateTime currentDate = DateTime.Today;
            string formattedCurrentDate = currentDate.ToString("yyyy-MM-dd");

            int i = 0;
            int currentRow = 0;
            int roundCount = 0;

            string scrapedTeamRounds = "";
            string scrapedOpponentRounds = "";

            if (startDate == "")
            {
                statsUrl = $"https://www.hltv.org/stats/players/matches/{playerId}/{playerName}?maps={map}";
            }
            else
            {
                statsUrl = $"https://www.hltv.org/stats/players/matches/{playerId}/{playerName}?startDate={startDate}&endDate={formattedCurrentDate}&maps={map}";
            }

            if (ranking != "All")
            {
                statsUrl += $"&rankingFilter={ranking.Trim().Replace(" ", "")}";
            }

            HtmlWeb web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36";
            HtmlAgilityPack.HtmlDocument doc = web.Load(statsUrl);

            foreach (HtmlNode dateNode in doc.DocumentNode.SelectNodes("//tr[contains(@class, 'group-')]//span/text()"))
            {
                if (i % 4 == 0)
                {
                    playerDataSheet.Rows[currentRow].Cells["playerTeam"].Value = dateNode.InnerText;
                }
                else if (i % 4 == 1)
                {
                    scrapedTeamRounds = dateNode.InnerText.TrimStart(' ').TrimStart('(').TrimEnd(')');
                    playerDataSheet.Rows[currentRow].Cells["playerTeamRounds"].Value = scrapedTeamRounds;
                    allRounds += int.Parse(scrapedTeamRounds);
                    avgRounds += int.Parse(scrapedTeamRounds);
                    roundCount++;
                }
                else if (i % 4 == 2)
                {
                    playerDataSheet.Rows[currentRow].Cells["opponentTeam"].Value = dateNode.InnerText;
                }
                else if (i % 4 == 3)
                {
                    scrapedOpponentRounds = dateNode.InnerText.TrimStart(' ').TrimStart('(').TrimEnd(')');
                    playerDataSheet.Rows[currentRow].Cells["opponentTeamRounds"].Value = scrapedOpponentRounds;

                    if (int.Parse(scrapedOpponentRounds) > int.Parse(scrapedTeamRounds))
                    {
                        playerDataSheet.Rows[currentRow].Cells["playerTeam"].Style.ForeColor = Color.Red;
                        playerDataSheet.Rows[currentRow].Cells["opponentTeam"].Style.ForeColor = Color.Green;
                    } else
                    {
                        playerDataSheet.Rows[currentRow].Cells["playerTeam"].Style.ForeColor = Color.Green;
                        playerDataSheet.Rows[currentRow].Cells["opponentTeam"].Style.ForeColor = Color.Red;
                    }
                    allRounds += int.Parse(scrapedOpponentRounds);
                    currentRow++;
                }

                i++;
            }

            avgRounds /= roundCount;
        }
        public static void playerKD(string playerName, string map, DataGridView playerDataSheet, string startDate, string ranking, ref List<double> listOfKills, ref double killAmount)
        {
            string playerId = convertNameToId(playerName.ToLower());
            string statsUrl;

            string[] splitKills;
            int tempKills;

            int rowIndex = 0;

            DateTime currentDate = DateTime.Today;
            string formattedCurrentDate = currentDate.ToString("yyyy-MM-dd");

            if (startDate == "")
            {
                statsUrl = $"https://www.hltv.org/stats/players/matches/{playerId}/{playerName}?maps={map}";
            }
            else
            {
                statsUrl = $"https://www.hltv.org/stats/players/matches/{playerId}/{playerName}?startDate={startDate}&endDate={formattedCurrentDate}&maps={map}";
            }

            if (ranking != "All")
            {
                statsUrl += $"&rankingFilter={ranking.Trim().Replace(" ", "")}";
            }

            HtmlWeb web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36";
            HtmlAgilityPack.HtmlDocument doc = web.Load(statsUrl);

            foreach (HtmlNode dateNode in doc.DocumentNode.SelectNodes("//td[@class='statsCenterText']"))
            {
                playerDataSheet.Rows[rowIndex++].Cells["playerKillsAndDeaths"].Value = dateNode.InnerText;

                splitKills = dateNode.InnerText.Split('-');

                if (int.TryParse(splitKills[0].Trim(), out tempKills))
                {
                    listOfKills.Add(tempKills);
                    killAmount += tempKills;
                }
                else
                {
                    MessageBox.Show("An error occurred within parsing average kills: " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
