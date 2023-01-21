using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLTV_Stats_Collector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void searchPlayerBox_TextChanged(object sender, EventArgs e)
        {

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

        private void playerDataSheet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
