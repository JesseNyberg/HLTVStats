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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool noResultsFound = false;

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
                Program.matchDate(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDateBox.Text, rankingBox.Text, ref noResultsFound);

                if (!noResultsFound)
                {
                    Program.matchResultAndRating(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDateBox.Text, rankingBox.Text, ref avgRating);
                    Program.matchTeamsAndRounds(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDateBox.Text, rankingBox.Text, ref allRounds, ref avgRounds);
                    Program.playerKD(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDateBox.Text, rankingBox.Text, ref listOfKills, ref killAmount);

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
                }
            } catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void playerDataSheet_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
            playerDataSheet.Rows[e.RowIndex].DefaultCellStyle.BackColor = playerDataSheet.GridColor = Color.FromArgb(51, 51, 51);
        }
    }
}
