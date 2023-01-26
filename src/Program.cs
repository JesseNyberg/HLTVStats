using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
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

        public static void matchRating(string playerName, string map, string startDate, string ranking, List<double> listOfRatings)
        {
            string playerId = convertNameToId(playerName.ToLower());
            string statsUrl;

            double rating = 0.00;


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


            if (doc.DocumentNode.SelectSingleNode("//td[contains(@class, 'match-')]") == null)
            {
                return;
            }

            foreach (HtmlNode ratingNode in doc.DocumentNode.SelectNodes("//td[contains(@class, 'match-')]/text()"))
                {
                    rating = 0.00;

                    if (!double.TryParse(ratingNode.InnerText.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out rating))
                    {
                        Console.WriteLine("Error gathering rating");
                    }

                        listOfRatings.Add(rating);
                }
        }

        public static void matchTeamsAndRounds(string playerName, string map, string startDate, string ranking,
            List<KeyValuePair<string, string>> teamAndRounds, List<KeyValuePair<string, string>> opponentTeamAndRounds)
        {
            string playerId = convertNameToId(playerName.ToLower());
            string statsUrl;

            DateTime currentDate = DateTime.Today;
            string formattedCurrentDate = currentDate.ToString("yyyy-MM-dd");

            int i = 0;
            int currentRow = 0;

            string scrapedTeamRound = "";
            string scrapedOpponentRound = "";
            string currentTeam = "";
            string currentOpponent = "";

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

            if (doc.DocumentNode.SelectSingleNode("//tr[contains(@class, 'group-')]//span/text()") == null)
            {
                return;
            }

            foreach (HtmlNode teamNode in doc.DocumentNode.SelectNodes("//tr[contains(@class, 'group-')]//span/text()"))
            {
                if (i % 4 == 0)
                {
                    currentTeam = teamNode.InnerText;
                }
                else if (i % 4 == 1)
                {
                    scrapedTeamRound = teamNode.InnerText.TrimStart(' ').TrimStart('(').TrimEnd(')');
                    teamAndRounds.Add(new KeyValuePair<string, string>(currentTeam, scrapedTeamRound));

                }
                else if (i % 4 == 2)
                {
                    currentOpponent = teamNode.InnerText;
                }
                else if (i % 4 == 3)
                {
                    scrapedOpponentRound = teamNode.InnerText.TrimStart(' ').TrimStart('(').TrimEnd(')');
                    opponentTeamAndRounds.Add(new KeyValuePair<string, string>(currentOpponent, scrapedOpponentRound));

                    currentRow++;
                }

                i++;
            }
        }
        public static void playerKD(string playerName, string map, string startDate, string ranking, List<double> listOfKills, List<string> listOfKillsDeaths)
        {
            string playerId = convertNameToId(playerName.ToLower());
            string statsUrl;

            string[] splitKills;
            int tempKills = 0;

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

            if (doc.DocumentNode.SelectSingleNode("//td[@class='statsCenterText']") == null)
            {
                //MessageBox.Show("No results found\n(or you're rate limited)", "Information", MessageBoxButtons.OK);
                return;
            }

            foreach (HtmlNode kdNode in doc.DocumentNode.SelectNodes("//td[@class='statsCenterText']"))
            {
                listOfKillsDeaths.Add(kdNode.InnerText);

                splitKills = kdNode.InnerText.Split('-');

                if (int.TryParse(splitKills[0].Trim(), out tempKills))
                {
                    listOfKills.Add(tempKills);
                }
                else
                {
                    MessageBox.Show("An error occurred within parsing average kills: " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static bool matchAverages(string matchURL, List<string> mapList, List<HLTV_Stats_Collector.Form1.Player> playerList)
        {
            string playerName = "";
            string map = "";
            int i = 0;

            HtmlWeb web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36";
            HtmlAgilityPack.HtmlDocument doc = web.Load(matchURL);

            if (doc.DocumentNode.SelectSingleNode("//div[@class='map-name-holder']//div[@class='mapname']") == null)
            {
                MessageBox.Show("No results found\n(or you're rate limited)", "Information", MessageBoxButtons.OK);
                return false;
            }

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//div[@class='map-name-holder']//div[@class='mapname']"))
            {
                map = node.InnerText;
                mapList.Add(map);
            }

            if (doc.DocumentNode.SelectSingleNode("//div[contains(@class, 'player-compare flagAlign')]//div[@class='text-ellipsis']") == null)
            {
                MessageBox.Show("No results found\n(or you're rate limited)", "Information", MessageBoxButtons.OK);
                return false;
            }

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//div[contains(@class, 'player-compare flagAlign')]//div[@class='text-ellipsis']"))
            {
                playerName = node.InnerText;
                playerList.Add(new HLTV_Stats_Collector.Form1.Player());
                playerList[i].playerName = playerName;
                i++;
            }

            return true;
        }
    }
}
