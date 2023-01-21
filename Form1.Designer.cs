using System;

namespace HLTV_Stats_Collector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.averagekills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgkillsper26rounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediankills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVGrating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVGRounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapsPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playerDataSheet = new System.Windows.Forms.DataGridView();
            this.matchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerTeamRounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opponentTeamRounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opponentTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerKillsAndDeaths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.searchPlayerBox = new System.Windows.Forms.TextBox();
            this.mapPickBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSheet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.startDateBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.playerDataSheet);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.searchPlayerBox);
            this.tabPage1.Controls.Add(this.mapPickBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find by player";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.averagekills,
            this.avgkillsper26rounds,
            this.mediankills,
            this.AVGrating,
            this.AVGRounds,
            this.mapsPlayed});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(463, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(280, 99);
            this.dataGridView2.TabIndex = 8;
            // 
            // averagekills
            // 
            this.averagekills.HeaderText = "AVG Kills";
            this.averagekills.Name = "averagekills";
            this.averagekills.Width = 30;
            // 
            // avgkillsper26rounds
            // 
            this.avgkillsper26rounds.HeaderText = "AVG kills per 26,5 rounds";
            this.avgkillsper26rounds.Name = "avgkillsper26rounds";
            this.avgkillsper26rounds.Width = 30;
            // 
            // mediankills
            // 
            this.mediankills.HeaderText = "Median kills";
            this.mediankills.Name = "mediankills";
            this.mediankills.Width = 30;
            // 
            // AVGrating
            // 
            this.AVGrating.HeaderText = "AVG Rating";
            this.AVGrating.Name = "AVGrating";
            this.AVGrating.Width = 30;
            // 
            // AVGRounds
            // 
            this.AVGRounds.HeaderText = "AVG Rounds";
            this.AVGRounds.Name = "AVGRounds";
            this.AVGRounds.Width = 30;
            // 
            // mapsPlayed
            // 
            this.mapsPlayed.HeaderText = "Maps played";
            this.mapsPlayed.Name = "mapsPlayed";
            this.mapsPlayed.Width = 30;
            // 
            // startDateBox
            // 
            this.startDateBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.startDateBox.FormattingEnabled = true;
            this.startDateBox.Items.AddRange(new object[] {
            "Last month",
            "Last 3 months",
            "Last 6 months",
            "Last 12 months",
            ""});
            this.startDateBox.Location = new System.Drawing.Point(141, 104);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(121, 21);
            this.startDateBox.TabIndex = 7;
            this.startDateBox.Enter += new System.EventHandler(this.startDateBox_Enter);
            this.startDateBox.Leave += new System.EventHandler(this.startDateBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start date:";
            // 
            // playerDataSheet
            // 
            this.playerDataSheet.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playerDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.playerDataSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerDataSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchDate,
            this.playerTeam,
            this.playerTeamRounds,
            this.opponentTeamRounds,
            this.opponentTeam,
            this.playerKillsAndDeaths,
            this.playerRating});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.playerDataSheet.DefaultCellStyle = dataGridViewCellStyle4;
            this.playerDataSheet.GridColor = System.Drawing.Color.White;
            this.playerDataSheet.Location = new System.Drawing.Point(21, 155);
            this.playerDataSheet.Name = "playerDataSheet";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playerDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.playerDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.playerDataSheet.Size = new System.Drawing.Size(744, 239);
            this.playerDataSheet.TabIndex = 5;
            // 
            // matchDate
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.matchDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.matchDate.HeaderText = "Date";
            this.matchDate.Name = "matchDate";
            this.matchDate.Width = 65;
            // 
            // playerTeam
            // 
            this.playerTeam.HeaderText = "Player team";
            this.playerTeam.Name = "playerTeam";
            // 
            // playerTeamRounds
            // 
            this.playerTeamRounds.HeaderText = " ";
            this.playerTeamRounds.Name = "playerTeamRounds";
            this.playerTeamRounds.Width = 30;
            // 
            // opponentTeamRounds
            // 
            this.opponentTeamRounds.HeaderText = "  ";
            this.opponentTeamRounds.Name = "opponentTeamRounds";
            this.opponentTeamRounds.Width = 30;
            // 
            // opponentTeam
            // 
            this.opponentTeam.HeaderText = "Opponent team";
            this.opponentTeam.Name = "opponentTeam";
            // 
            // playerKillsAndDeaths
            // 
            this.playerKillsAndDeaths.HeaderText = "K - D";
            this.playerKillsAndDeaths.Name = "playerKillsAndDeaths";
            this.playerKillsAndDeaths.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerKillsAndDeaths.Width = 60;
            // 
            // playerRating
            // 
            this.playerRating.HeaderText = "Rating";
            this.playerRating.Name = "playerRating";
            this.playerRating.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerRating.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.playerRating.Width = 50;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(287, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find stats";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchPlayerBox
            // 
            this.searchPlayerBox.Location = new System.Drawing.Point(141, 29);
            this.searchPlayerBox.Name = "searchPlayerBox";
            this.searchPlayerBox.Size = new System.Drawing.Size(121, 20);
            this.searchPlayerBox.TabIndex = 3;
            this.searchPlayerBox.Enter += new System.EventHandler(this.searchPlayerBox_Enter);
            this.searchPlayerBox.Leave += new System.EventHandler(this.searchPlayerBox_Leave);
            // 
            // mapPickBox
            // 
            this.mapPickBox.FormattingEnabled = true;
            this.mapPickBox.Items.AddRange(new object[] {
            "Inferno",
            "Mirage",
            "Nuke",
            "Overpass",
            "Vertigo",
            "Ancient",
            "Anubis"});
            this.mapPickBox.Location = new System.Drawing.Point(141, 64);
            this.mapPickBox.Name = "mapPickBox";
            this.mapPickBox.Size = new System.Drawing.Size(121, 21);
            this.mapPickBox.TabIndex = 2;
            this.mapPickBox.Enter += new System.EventHandler(this.mapPickBox_Enter);
            this.mapPickBox.Leave += new System.EventHandler(this.mapPickBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Map:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search player:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.comboBox5);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find by match";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView3.Location = new System.Drawing.Point(24, 121);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(388, 214);
            this.dataGridView3.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "AVG Kills";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "AVG kills per 26,5 rounds";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 30;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Median kills";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 30;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "AVG Rating";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "AVG Rounds";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 30;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Maps played";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 30;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(291, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Find stats";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(149, 85);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 11;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(149, 57);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(149, 30);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(20, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time period:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(20, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Map:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Match URL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "HLTV Stats Collector";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSheet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox mapPickBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchPlayerBox;
        private System.Windows.Forms.DataGridView playerDataSheet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox startDateBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn averagekills;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgkillsper26rounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediankills;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVGrating;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVGRounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapsPlayed;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerTeamRounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn opponentTeamRounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn opponentTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerKillsAndDeaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerRating;
    }
}

