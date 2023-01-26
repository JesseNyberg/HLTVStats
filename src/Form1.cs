using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MathNet.Numerics.Statistics;

namespace HLTV_Stats_Collector
{

    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public class Player
        {
            public string playerName = "";
            public int mapsPlayed = 0;
            public double matchAvgKills;
            public double matchAvgKills26Rounds;
            public double matchAvgRating;
            public double matchMedianKills;
        }

        private List<KeyValuePair<string, string>> opponentTeamAndRounds = new List<KeyValuePair<string, string>>();
        private List<KeyValuePair<string, string>> teamAndRounds = new List<KeyValuePair<string, string>>();
        private List<string> listOfKillsDeaths = new List<string> { };
        private List<string> mapList = new List<string> { };
        private List<Player> playerList = new List<Player>();

        private List<double> listOfKills = new List<double> { };
        private List<double> listOfRatings = new List<double> { };

        private double medianKills = 0.00;
        private double avgKills = 0.00;
        private double playerKillAmount = 0.00;

        private double allRounds = 0.00;
        private double avgRounds = 0.00;
        private int teamRoundAmount = 0;
        private int opponentRoundAmount = 0;

        double avgRating = 0.00;

        bool resultsFound = true;
        bool parseFailed = false;

        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green800, Accent.DeepOrange200, TextShade.WHITE);

            // Find by Player styling
            playerDataSheet.BorderStyle = BorderStyle.None;
            playerDataSheet.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            playerDataSheet.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            playerDataSheet.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            playerDataSheet.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            playerDataSheet.BackgroundColor = Color.FromArgb(51, 51, 51);
            playerDataSheet.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            playerDataSheet.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

            playerDataSheet.EnableHeadersVisualStyles = false;
            playerDataSheet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            playerDataSheet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(78, 78, 78);
            playerDataSheet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            playerDataSheet.RowPrePaint += new DataGridViewRowPrePaintEventHandler(playerDataSheet_RowPrePaint);

            // Find by match styling
            matchPlayerDataSheet.BorderStyle = BorderStyle.None;
            matchPlayerDataSheet.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            matchPlayerDataSheet.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            matchPlayerDataSheet.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            matchPlayerDataSheet.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            matchPlayerDataSheet.BackgroundColor = Color.FromArgb(51, 51, 51);
            matchPlayerDataSheet.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            matchPlayerDataSheet.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

            matchPlayerDataSheet.EnableHeadersVisualStyles = false;
            matchPlayerDataSheet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            matchPlayerDataSheet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(78, 78, 78);
            matchPlayerDataSheet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            matchPlayerDataSheet.RowPrePaint += new DataGridViewRowPrePaintEventHandler(matchPlayerDataSheet_RowPrePaint);

            byPlayerProgressBar.Visible = false;
            matchProgressBar.Visible = false;
        }

        // Used to hide the datagridview values while they load
        private void HideAllCellValues()
        {
            playerDataSheet.Height = 22;
        }

        private void ShowAllCellValues()
        {
            playerDataSheet.Height = 179;
        }

        // Find stats button is clicked
        private async void button1_Click_1(object sender, EventArgs e)
        {
            opponentTeamAndRounds.Clear();
            teamAndRounds.Clear();
            listOfKills.Clear();
            listOfRatings.Clear();
            listOfKillsDeaths.Clear();
            HideAllCellValues();

            medianKills = 0.00;
            avgKills = 0.00;
            playerKillAmount = 0.00;

            allRounds = 0.00;
            avgRounds = 0.00;

            teamRoundAmount = 0;
            opponentRoundAmount = 0;

            avgRating = 0.00;

            byPlayerProgressBar.Value = 0;

            int teamRounds = 0;

            parseFailed = false;

            if (mapPickBox.Text == "")
            {
                MessageBox.Show("Choose a map", "Information", MessageBoxButtons.OK);
                return;
            }

            if (searchPlayerBox.Text == "")
            {
                MessageBox.Show("Enter a player name", "Information", MessageBoxButtons.OK);
                return;
            }

            if (rankingBox.Text == "")
            {
                MessageBox.Show("Choose a ranking filter", "Information", MessageBoxButtons.OK);
                return;
            }

            resultsFound = true;

            int rowIndex = 0;

            playerDataSheet.Rows.Clear();
            materialListView1.Items.Clear();

            try
            {
                byPlayerProgressBar.Visible = true;
                resultsFound = Program.matchDate(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDateBox.Text, rankingBox.Text);
                byPlayerProgressBar.Value++;

                if (resultsFound)
                {
                    await Task.Delay(500);
                    Program.matchTeamsAndRounds(searchPlayerBox.Text, mapPickBox.Text, startDateBox.Text, rankingBox.Text, teamAndRounds, opponentTeamAndRounds);
                    byPlayerProgressBar.Value++;

                    foreach (KeyValuePair<string, string> roundTeamPair in teamAndRounds) {
                        playerDataSheet.Rows[rowIndex].Cells["playerTeam"].Value = roundTeamPair.Key;
                        playerDataSheet.Rows[rowIndex].Cells["playerTeamRounds"].Value = roundTeamPair.Value;

                        rowIndex++;
                    }
                    rowIndex = 0;

                    foreach (KeyValuePair<string, string> roundOpponentPair in opponentTeamAndRounds)
                    {
                        playerDataSheet.Rows[rowIndex].Cells["opponentTeam"].Value = roundOpponentPair.Key;
                        playerDataSheet.Rows[rowIndex].Cells["opponentTeamRounds"].Value = roundOpponentPair.Value;

                        rowIndex++;
                    }
                    rowIndex = 0;

                    for (rowIndex = 0; rowIndex < teamAndRounds.Count; rowIndex++)
                    {
                        //int teamRound = int.Parse(teamAndRounds[rowIndex].Value);
                        //int opponentRound = int.Parse(opponentTeamAndRounds[rowIndex].Value);

                        if (!int.TryParse(teamAndRounds[rowIndex].Value, out teamRoundAmount))
                        {
                            Console.WriteLine("Parse failed: " + teamAndRounds[rowIndex].Value);
                            MessageBox.Show("An error occurred within parsing rounds: \n(Try setting date to newer)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            matchProgressBar.Visible = false;
                            parseFailed = true;
                            break;
                        }

                        if (!int.TryParse(opponentTeamAndRounds[rowIndex].Value, out opponentRoundAmount))
                        {
                            Console.WriteLine("Parse failed: " + opponentTeamAndRounds[rowIndex].Value);
                            MessageBox.Show("An error occurred within parsing rounds: \n(Try setting date to newer)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            matchProgressBar.Visible = false;
                            parseFailed = true;
                            break;
                        }

                        if (opponentRoundAmount > teamRoundAmount)
                        {
                            playerDataSheet.Rows[rowIndex].Cells["playerTeam"].Style.ForeColor = Color.Red;
                            playerDataSheet.Rows[rowIndex].Cells["opponentTeam"].Style.ForeColor = Color.Green;
                        }
                        else
                        {
                            playerDataSheet.Rows[rowIndex].Cells["playerTeam"].Style.ForeColor = Color.Green;
                            playerDataSheet.Rows[rowIndex].Cells["opponentTeam"].Style.ForeColor = Color.Red;
                        }

                        allRounds += teamRoundAmount + opponentRoundAmount;
                        teamRounds += teamRoundAmount;
                    }
                    rowIndex = 0;

                    await Task.Delay(500);
                    Program.matchRating(searchPlayerBox.Text, mapPickBox.Text, startDateBox.Text, rankingBox.Text, listOfRatings);
                    byPlayerProgressBar.Value++;

                    foreach (double rating in listOfRatings)
                    {
                        playerDataSheet.Rows[rowIndex++].Cells["playerRating"].Value = rating;
                    }
                    rowIndex = 0;

                    await Task.Delay(500);
                    Program.playerKD(searchPlayerBox.Text, mapPickBox.Text, startDateBox.Text, rankingBox.Text, listOfKills, listOfKillsDeaths);
                    byPlayerProgressBar.Value++;

                    foreach (string KD in listOfKillsDeaths)
                    {
                        playerDataSheet.Rows[rowIndex++].Cells["playerKillsAndDeaths"].Value = KD;
                    }

                    medianKills = Statistics.Median(listOfKills);
                    avgKills = Statistics.Mean(listOfKills);
                    avgRating = Statistics.Mean(listOfRatings);

                    avgRounds = teamRounds / listOfRatings.Count();
                    playerKillAmount = listOfKills.Sum();

                    ListViewItem item = new ListViewItem(Math.Round(avgKills, 2).ToString());
                    item.SubItems.Add(Math.Round((playerKillAmount / allRounds) * 26.5, 2).ToString());
                    item.SubItems.Add(Math.Round(medianKills, 2).ToString());
                    item.SubItems.Add(Math.Round(avgRating, 2).ToString());
                    item.SubItems.Add(Math.Round(avgRounds, 2).ToString());
                    materialListView1.Items.Add(item);

                    foreach (DataGridViewRow row in playerDataSheet.Rows)
                    {
                        row.Cells["roundDivider"].Value = "-";
                    }
                    ShowAllCellValues();
                }
            } catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            byPlayerProgressBar.Visible = false;
        }

        private async void matchStatsButton_Click(object sender, EventArgs e)
        {
            if (matchMapBox.Text == "")
            {
                MessageBox.Show("Choose a map", "Information", MessageBoxButtons.OK);
                return;
            }

            if (searchByMatchBox.Text == "")
            {
                MessageBox.Show("Enter a match URL", "Information", MessageBoxButtons.OK);
                return;
            }

            if (matchRankingBox.Text == "")
            {
                MessageBox.Show("Choose a ranking filter", "Information", MessageBoxButtons.OK);
                return;
            }

            matchPlayerDataSheet.Rows.Clear();
            mapList.Clear();
            playerList.Clear();

            parseFailed = false;
            int rowIndex = 0;
            matchProgressBar.Value = 0;

            try
            {
                matchProgressBar.Visible = true;

                resultsFound = Program.matchAverages(searchByMatchBox.Text, mapList, playerList);
                matchProgressBar.Value++;

                if (!resultsFound)
                {
                    matchProgressBar.Visible = false;
                    return;
                }

                foreach (Player player in playerList)
                {
                    List<double> mapKills = new List<double>();
                    List<double> mapRatings = new List<double>();
                    List<KeyValuePair<string, string>> mapTeamRounds = new List<KeyValuePair<string, string>>();
                    List<KeyValuePair<string, string>> mapOpponentRounds = new List<KeyValuePair<string, string>>();

                    playerKillAmount = 0.00;
                    allRounds = 0.00;

                    teamRoundAmount = 0;
                    opponentRoundAmount = 0;
                    rowIndex = 0;

                    mapKills.Clear();
                    mapRatings.Clear();
                    parseFailed = false;

                    await Task.Delay(delaySlider.Value);

                    Program.matchRating(player.playerName, matchMapBox.Text, matchStartdateBox.Text, matchRankingBox.Text, mapRatings);
                    matchProgressBar.Value++;

                    await Task.Delay(delaySlider.Value);

                    Program.playerKD(player.playerName, matchMapBox.Text, matchStartdateBox.Text, matchRankingBox.Text, mapKills, listOfKillsDeaths);
                    matchProgressBar.Value++;

                    player.matchMedianKills = Math.Round(Statistics.Median(mapKills), 2);
                    player.matchAvgKills = Math.Round(Statistics.Mean(mapKills), 2);
                    player.matchAvgRating = Math.Round(Statistics.Mean(mapRatings), 2);
                    playerKillAmount = mapKills.Sum();

                    await Task.Delay(delaySlider.Value);

                    Program.matchTeamsAndRounds(player.playerName, matchMapBox.Text, matchStartdateBox.Text, matchRankingBox.Text, mapTeamRounds, mapOpponentRounds);
                    matchProgressBar.Value++;

                    for (rowIndex = 0; rowIndex < mapTeamRounds.Count; rowIndex++)
                    {
                        if (!int.TryParse(mapTeamRounds[rowIndex].Value, out teamRoundAmount))
                        {
                            Console.WriteLine("Parse failed: " + mapTeamRounds[rowIndex].Value);
                            MessageBox.Show("An error occurred within parsing rounds: \n(Try setting date to newer)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            matchProgressBar.Visible = false;
                            parseFailed = true;
                            break;
                        }

                        if (!int.TryParse(mapOpponentRounds[rowIndex].Value, out opponentRoundAmount))
                        {
                            Console.WriteLine("Parse failed: " + mapTeamRounds[rowIndex].Value);
                            MessageBox.Show("An error occurred within parsing rounds: \n(Try setting date to newer)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            matchProgressBar.Visible = false;
                            parseFailed = true;
                            break;
                        }

                        allRounds += teamRoundAmount + opponentRoundAmount;
                    }

                    if (parseFailed)
                    {
                        return;
                    }

                    player.matchAvgKills26Rounds = Math.Round((playerKillAmount / allRounds) * 26.5, 2);
                    player.mapsPlayed = mapRatings.Count;

                    await Task.Delay(delaySlider.Value);
                    }

                    foreach (Player player in playerList)
                    {
                        rowIndex = matchPlayerDataSheet.Rows.Add();
                        matchPlayerDataSheet.Rows[rowIndex].Cells["matchPlayer"].Value = player.playerName;

                        if (double.IsNaN(player.matchAvgKills) || double.IsInfinity(player.matchAvgKills))
                        {
                            matchPlayerDataSheet.Rows[rowIndex].Cells["matchKills"].Value = "Not found";
                            continue;
                        }

                        matchPlayerDataSheet.Rows[rowIndex].Cells["matchKills"].Value = player.matchAvgKills;
                        matchPlayerDataSheet.Rows[rowIndex].Cells["matchKills26"].Value = player.matchAvgKills26Rounds;
                        matchPlayerDataSheet.Rows[rowIndex].Cells["matchMedianKills"].Value = player.matchMedianKills;
                        matchPlayerDataSheet.Rows[rowIndex].Cells["matchRating"].Value = player.matchAvgRating;
                        matchPlayerDataSheet.Rows[rowIndex].Cells["matchMapsPlayed"].Value = player.mapsPlayed;
                    }

            } catch (Exception exception)
                {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            matchProgressBar.Visible = false;
        }

        private void playerDataSheet_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
            playerDataSheet.Rows[e.RowIndex].DefaultCellStyle.BackColor = playerDataSheet.GridColor = Color.FromArgb(51, 51, 51);
        }

        private void matchPlayerDataSheet_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
            matchPlayerDataSheet.Rows[e.RowIndex].DefaultCellStyle.BackColor = matchPlayerDataSheet.GridColor = Color.FromArgb(51, 51, 51);
        }

    }
}
