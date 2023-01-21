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
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startDate = startDateBox.Text;
            Program.matchDate(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDate);
            Program.matchResultAndRating(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDate);
            Program.matchTeamsAndRounds(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDate);
            Program.playerKD(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDate);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startDateBox.Text = "e.g. 2022-10-21";
            startDateBox.ForeColor = Color.LightGray;
            mapPickBox.Text = "de_mirage";
            mapPickBox.ForeColor = Color.LightGray;
            searchPlayerBox.Text = "(case insensitive)";
            searchPlayerBox.ForeColor = Color.LightGray;
        }

        private void startDateBox_Enter(object sender, EventArgs e)
        {
            if (startDateBox.Text == "e.g. 2022-10-21")
            {
                startDateBox.Text = "";
                startDateBox.ForeColor = Color.Black;
            }
        }

        private void startDateBox_Leave(object sender, EventArgs e)
        {
            if (startDateBox.Text == "")
            {
                startDateBox.Text = "e.g. 2022-10-21";
                startDateBox.ForeColor = Color.LightGray;
            }
        }

        private void mapPickBox_Enter(object sender, EventArgs e)
        {
            if (mapPickBox.Text == "de_mirage")
            {
                mapPickBox.Text = "";
                mapPickBox.ForeColor = Color.Black;
            }
        }

        private void mapPickBox_Leave(object sender, EventArgs e)
        {
            if (mapPickBox.Text == "")
            {
                mapPickBox.Text = "de_mirage";
                mapPickBox.ForeColor = Color.LightGray;
            }
        }

        private void searchPlayerBox_Enter(object sender, EventArgs e)
        {
            if (searchPlayerBox.Text == "(case insensitive)")
            { 
                searchPlayerBox.Text = "";
                searchPlayerBox.ForeColor = Color.Black;
            }
        }

        private void searchPlayerBox_Leave(object sender, EventArgs e)
        {
            if (searchPlayerBox.Text == "")
            {
                searchPlayerBox.Text = "(case insensitive)";
                searchPlayerBox.ForeColor = Color.LightGray;
            }
        }

    }
}
