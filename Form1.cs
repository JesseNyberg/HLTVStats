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

        private void button1_Click_1(object sender, EventArgs e)
        {
            playerDataSheet.Rows.Clear();
            string startDate = startDateBox.Text;
            Program.matchDate(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDate);
            Program.matchResultAndRating(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDate);
            Program.matchTeamsAndRounds(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDate);
            Program.playerKD(searchPlayerBox.Text, mapPickBox.Text, playerDataSheet, startDate);
        }
    }
}
