using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MathNet.Numerics.Statistics;

namespace HLTV_Stats_Collector
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green800, Accent.DeepOrange200, TextShade.WHITE);
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
            materialProgressBar1.Visible = false;
        }

        private void HideAllCellValues()
        {
            playerDataSheet.Height = 22;
        }

        private void ShowAllCellValues()
        {
            playerDataSheet.Height = 179;
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            HideAllCellValues();
            materialProgressBar1.Value = 0;

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

            bool resultsFound = true;

            List<double> listOfKills = new List<double> {};
            double medianKills = 0.00;
            double avgKills = 0.00;
            double killAmount = 0.00;

            double allRounds = 0.00;
            double avgRounds = 0.00;

            double avgRating = 0.00;

            playerDataSheet.Rows.Clear();
            materialListView1.Items.Clear();

            try
            {
                materialProgressBar1.Visible = true;
                resultsFound = Program.matchDate(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDateBox.Text, rankingBox.Text);
                materialProgressBar1.Value++;

                if (resultsFound)
                {
                    await Task.Delay(500);
                    Program.matchTeamsAndRounds(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDateBox.Text, rankingBox.Text, ref allRounds, ref avgRounds);
                    materialProgressBar1.Value++;

                    await Task.Delay(500);
                    Program.matchResultAndRating(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDateBox.Text, rankingBox.Text, ref avgRating);
                    materialProgressBar1.Value++;

                    await Task.Delay(500);
                    Program.playerKD(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDateBox.Text, rankingBox.Text, ref listOfKills, ref killAmount);
                    materialProgressBar1.Value++;

                    medianKills = Statistics.Median(listOfKills);
                    avgKills = Statistics.Mean(listOfKills);

                    ListViewItem item = new ListViewItem(Math.Round(avgKills, 2).ToString());
                    item.SubItems.Add(Math.Round((killAmount / allRounds) * 26.5, 2).ToString());
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
            materialProgressBar1.Visible = false;
        }

        private void playerDataSheet_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
            playerDataSheet.Rows[e.RowIndex].DefaultCellStyle.BackColor = playerDataSheet.GridColor = Color.FromArgb(51, 51, 51);
        }
    }
}
