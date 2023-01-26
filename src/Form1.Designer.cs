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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.byPlayerProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.rankingBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.statAvgKills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statAvgKillsPer26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statMedianKills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statAvgRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statAvgRounds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerDataSheet = new System.Windows.Forms.DataGridView();
            this.matchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerTeamRounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundDivider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opponentTeamRounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opponentTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerKillsAndDeaths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapPickBox = new MaterialSkin.Controls.MaterialComboBox();
            this.startDateBox = new MaterialSkin.Controls.MaterialTextBox();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.searchPlayerBox = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.matchProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.matchMapBox = new MaterialSkin.Controls.MaterialComboBox();
            this.matchRankingBox = new MaterialSkin.Controls.MaterialComboBox();
            this.matchStartdateBox = new MaterialSkin.Controls.MaterialTextBox();
            this.matchStatsButton = new MaterialSkin.Controls.MaterialButton();
            this.matchPlayerDataSheet = new System.Windows.Forms.DataGridView();
            this.matchPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchKills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchKills26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchMedianKills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchMapsPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchByMatchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.delaySlider = new MaterialSkin.Controls.MaterialSlider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSheet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchPlayerDataSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-2, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(892, 413);
            this.materialTabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.delaySlider);
            this.tabPage1.Controls.Add(this.byPlayerProgressBar);
            this.tabPage1.Controls.Add(this.rankingBox);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.materialListView1);
            this.tabPage1.Controls.Add(this.playerDataSheet);
            this.tabPage1.Controls.Add(this.mapPickBox);
            this.tabPage1.Controls.Add(this.startDateBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.searchPlayerBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(884, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find by player";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // byPlayerProgressBar
            // 
            this.byPlayerProgressBar.Depth = 0;
            this.byPlayerProgressBar.Location = new System.Drawing.Point(416, 148);
            this.byPlayerProgressBar.Maximum = 4;
            this.byPlayerProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.byPlayerProgressBar.Name = "byPlayerProgressBar";
            this.byPlayerProgressBar.Size = new System.Drawing.Size(100, 5);
            this.byPlayerProgressBar.TabIndex = 23;
            // 
            // rankingBox
            // 
            this.rankingBox.AutoResize = false;
            this.rankingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rankingBox.Depth = 0;
            this.rankingBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.rankingBox.DropDownHeight = 118;
            this.rankingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankingBox.DropDownWidth = 121;
            this.rankingBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.rankingBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rankingBox.FormattingEnabled = true;
            this.rankingBox.Hint = "Choose ranking";
            this.rankingBox.IntegralHeight = false;
            this.rankingBox.ItemHeight = 29;
            this.rankingBox.Items.AddRange(new object[] {
            "",
            "All",
            "Top 5",
            "Top 10",
            "Top 20",
            "Top 30",
            "Top 50"});
            this.rankingBox.Location = new System.Drawing.Point(18, 131);
            this.rankingBox.MaxDropDownItems = 4;
            this.rankingBox.MouseState = MaterialSkin.MouseState.OUT;
            this.rankingBox.Name = "rankingBox";
            this.rankingBox.Size = new System.Drawing.Size(272, 35);
            this.rankingBox.StartIndex = 0;
            this.rankingBox.TabIndex = 22;
            this.rankingBox.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(578, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Average statistics";
            this.materialLabel1.UseAccent = true;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = true;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statAvgKills,
            this.statAvgKillsPer26,
            this.statMedianKills,
            this.statAvgRating,
            this.statAvgRounds});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(403, 25);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Scrollable = false;
            this.materialListView1.Size = new System.Drawing.Size(480, 100);
            this.materialListView1.TabIndex = 20;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // statAvgKills
            // 
            this.statAvgKills.Text = "Kills";
            // 
            // statAvgKillsPer26
            // 
            this.statAvgKillsPer26.Text = "Kills (26,5 rounds)";
            this.statAvgKillsPer26.Width = 150;
            // 
            // statMedianKills
            // 
            this.statMedianKills.Text = "Median kills";
            this.statMedianKills.Width = 110;
            // 
            // statAvgRating
            // 
            this.statAvgRating.Text = "Rating";
            this.statAvgRating.Width = 80;
            // 
            // statAvgRounds
            // 
            this.statAvgRounds.Text = "Rounds";
            this.statAvgRounds.Width = 80;
            // 
            // playerDataSheet
            // 
            this.playerDataSheet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.playerDataSheet.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(18, 1, 1, 1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playerDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.playerDataSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerDataSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchDate,
            this.playerTeam,
            this.playerTeamRounds,
            this.roundDivider,
            this.opponentTeamRounds,
            this.opponentTeam,
            this.playerKillsAndDeaths,
            this.playerRating});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.playerDataSheet.DefaultCellStyle = dataGridViewCellStyle5;
            this.playerDataSheet.Location = new System.Drawing.Point(18, 184);
            this.playerDataSheet.Name = "playerDataSheet";
            this.playerDataSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playerDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.playerDataSheet.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.playerDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.playerDataSheet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.playerDataSheet.Size = new System.Drawing.Size(608, 179);
            this.playerDataSheet.TabIndex = 19;
            // 
            // matchDate
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 3, 1, 1);
            this.matchDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.matchDate.HeaderText = "Date";
            this.matchDate.Name = "matchDate";
            // 
            // playerTeam
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.playerTeam.DefaultCellStyle = dataGridViewCellStyle3;
            this.playerTeam.HeaderText = "Team";
            this.playerTeam.Name = "playerTeam";
            this.playerTeam.Width = 130;
            // 
            // playerTeamRounds
            // 
            this.playerTeamRounds.HeaderText = " ";
            this.playerTeamRounds.Name = "playerTeamRounds";
            this.playerTeamRounds.Width = 35;
            // 
            // roundDivider
            // 
            this.roundDivider.HeaderText = "   ";
            this.roundDivider.Name = "roundDivider";
            this.roundDivider.Width = 20;
            // 
            // opponentTeamRounds
            // 
            this.opponentTeamRounds.HeaderText = "  ";
            this.opponentTeamRounds.Name = "opponentTeamRounds";
            this.opponentTeamRounds.Width = 35;
            // 
            // opponentTeam
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.opponentTeam.DefaultCellStyle = dataGridViewCellStyle4;
            this.opponentTeam.HeaderText = "Opponent";
            this.opponentTeam.Name = "opponentTeam";
            this.opponentTeam.Width = 130;
            // 
            // playerKillsAndDeaths
            // 
            this.playerKillsAndDeaths.HeaderText = "K - D";
            this.playerKillsAndDeaths.Name = "playerKillsAndDeaths";
            this.playerKillsAndDeaths.Width = 80;
            // 
            // playerRating
            // 
            this.playerRating.HeaderText = "Rating";
            this.playerRating.Name = "playerRating";
            this.playerRating.Width = 80;
            // 
            // mapPickBox
            // 
            this.mapPickBox.AutoResize = false;
            this.mapPickBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mapPickBox.Depth = 0;
            this.mapPickBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mapPickBox.DropDownHeight = 118;
            this.mapPickBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapPickBox.DropDownWidth = 121;
            this.mapPickBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mapPickBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mapPickBox.FormattingEnabled = true;
            this.mapPickBox.Hint = "Choose map";
            this.mapPickBox.IntegralHeight = false;
            this.mapPickBox.ItemHeight = 29;
            this.mapPickBox.Items.AddRange(new object[] {
            "",
            "de_inferno",
            "de_mirage",
            "de_nuke",
            "de_overpass",
            "de_vertigo",
            "de_ancient",
            "de_anubis"});
            this.mapPickBox.Location = new System.Drawing.Point(18, 6);
            this.mapPickBox.MaxDropDownItems = 4;
            this.mapPickBox.MouseState = MaterialSkin.MouseState.OUT;
            this.mapPickBox.Name = "mapPickBox";
            this.mapPickBox.Size = new System.Drawing.Size(272, 35);
            this.mapPickBox.StartIndex = 0;
            this.mapPickBox.TabIndex = 16;
            this.mapPickBox.UseTallSize = false;
            // 
            // startDateBox
            // 
            this.startDateBox.AnimateReadOnly = false;
            this.startDateBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startDateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startDateBox.Depth = 0;
            this.startDateBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.startDateBox.ForeColor = System.Drawing.Color.LightGray;
            this.startDateBox.Hint = "Enter start date (e.g. 2022-10-21)";
            this.startDateBox.LeadingIcon = null;
            this.startDateBox.Location = new System.Drawing.Point(18, 89);
            this.startDateBox.MaxLength = 50;
            this.startDateBox.MouseState = MaterialSkin.MouseState.OUT;
            this.startDateBox.Multiline = false;
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(272, 36);
            this.startDateBox.TabIndex = 17;
            this.startDateBox.Text = "";
            this.startDateBox.TrailingIcon = null;
            this.startDateBox.UseTallSize = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button1.Depth = 0;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(297, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "FIND STATS";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // searchPlayerBox
            // 
            this.searchPlayerBox.AnimateReadOnly = false;
            this.searchPlayerBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchPlayerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchPlayerBox.Depth = 0;
            this.searchPlayerBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchPlayerBox.ForeColor = System.Drawing.Color.LightGray;
            this.searchPlayerBox.Hint = "Enter player name";
            this.searchPlayerBox.LeadingIcon = null;
            this.searchPlayerBox.LeaveOnEnterKey = true;
            this.searchPlayerBox.Location = new System.Drawing.Point(18, 47);
            this.searchPlayerBox.MaxLength = 50;
            this.searchPlayerBox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchPlayerBox.Multiline = false;
            this.searchPlayerBox.Name = "searchPlayerBox";
            this.searchPlayerBox.Size = new System.Drawing.Size(272, 36);
            this.searchPlayerBox.TabIndex = 15;
            this.searchPlayerBox.Text = "";
            this.searchPlayerBox.TrailingIcon = null;
            this.searchPlayerBox.UseTallSize = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.materialSlider1);
            this.tabPage2.Controls.Add(this.matchProgressBar);
            this.tabPage2.Controls.Add(this.matchMapBox);
            this.tabPage2.Controls.Add(this.matchRankingBox);
            this.tabPage2.Controls.Add(this.matchStartdateBox);
            this.tabPage2.Controls.Add(this.matchStatsButton);
            this.tabPage2.Controls.Add(this.matchPlayerDataSheet);
            this.tabPage2.Controls.Add(this.searchByMatchBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(884, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find by match";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // matchProgressBar
            // 
            this.matchProgressBar.Depth = 0;
            this.matchProgressBar.Location = new System.Drawing.Point(416, 148);
            this.matchProgressBar.Maximum = 40;
            this.matchProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.matchProgressBar.Name = "matchProgressBar";
            this.matchProgressBar.Size = new System.Drawing.Size(100, 5);
            this.matchProgressBar.TabIndex = 26;
            // 
            // matchMapBox
            // 
            this.matchMapBox.AutoResize = false;
            this.matchMapBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matchMapBox.Depth = 0;
            this.matchMapBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.matchMapBox.DropDownHeight = 118;
            this.matchMapBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matchMapBox.DropDownWidth = 121;
            this.matchMapBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.matchMapBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matchMapBox.FormattingEnabled = true;
            this.matchMapBox.Hint = "Choose map";
            this.matchMapBox.IntegralHeight = false;
            this.matchMapBox.ItemHeight = 29;
            this.matchMapBox.Items.AddRange(new object[] {
            "",
            "de_inferno",
            "de_mirage",
            "de_nuke",
            "de_overpass",
            "de_vertigo",
            "de_ancient",
            "de_anubis"});
            this.matchMapBox.Location = new System.Drawing.Point(18, 6);
            this.matchMapBox.MaxDropDownItems = 4;
            this.matchMapBox.MouseState = MaterialSkin.MouseState.OUT;
            this.matchMapBox.Name = "matchMapBox";
            this.matchMapBox.Size = new System.Drawing.Size(272, 35);
            this.matchMapBox.StartIndex = 0;
            this.matchMapBox.TabIndex = 25;
            this.matchMapBox.UseTallSize = false;
            // 
            // matchRankingBox
            // 
            this.matchRankingBox.AutoResize = false;
            this.matchRankingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matchRankingBox.Depth = 0;
            this.matchRankingBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.matchRankingBox.DropDownHeight = 118;
            this.matchRankingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matchRankingBox.DropDownWidth = 121;
            this.matchRankingBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.matchRankingBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matchRankingBox.FormattingEnabled = true;
            this.matchRankingBox.Hint = "Choose ranking";
            this.matchRankingBox.IntegralHeight = false;
            this.matchRankingBox.ItemHeight = 29;
            this.matchRankingBox.Items.AddRange(new object[] {
            "",
            "All",
            "Top 5",
            "Top 10",
            "Top 20",
            "Top 30",
            "Top 50"});
            this.matchRankingBox.Location = new System.Drawing.Point(18, 131);
            this.matchRankingBox.MaxDropDownItems = 4;
            this.matchRankingBox.MouseState = MaterialSkin.MouseState.OUT;
            this.matchRankingBox.Name = "matchRankingBox";
            this.matchRankingBox.Size = new System.Drawing.Size(272, 35);
            this.matchRankingBox.StartIndex = 0;
            this.matchRankingBox.TabIndex = 24;
            this.matchRankingBox.UseTallSize = false;
            // 
            // matchStartdateBox
            // 
            this.matchStartdateBox.AnimateReadOnly = false;
            this.matchStartdateBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.matchStartdateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matchStartdateBox.Depth = 0;
            this.matchStartdateBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.matchStartdateBox.ForeColor = System.Drawing.Color.LightGray;
            this.matchStartdateBox.Hint = "Enter start date (e.g. 2022-10-21)";
            this.matchStartdateBox.LeadingIcon = null;
            this.matchStartdateBox.Location = new System.Drawing.Point(18, 89);
            this.matchStartdateBox.MaxLength = 50;
            this.matchStartdateBox.MouseState = MaterialSkin.MouseState.OUT;
            this.matchStartdateBox.Multiline = false;
            this.matchStartdateBox.Name = "matchStartdateBox";
            this.matchStartdateBox.Size = new System.Drawing.Size(272, 36);
            this.matchStartdateBox.TabIndex = 23;
            this.matchStartdateBox.Text = "";
            this.matchStartdateBox.TrailingIcon = null;
            this.matchStartdateBox.UseTallSize = false;
            // 
            // matchStatsButton
            // 
            this.matchStatsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matchStatsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matchStatsButton.Depth = 0;
            this.matchStatsButton.HighEmphasis = true;
            this.matchStatsButton.Icon = null;
            this.matchStatsButton.Location = new System.Drawing.Point(297, 131);
            this.matchStatsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matchStatsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.matchStatsButton.Name = "matchStatsButton";
            this.matchStatsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matchStatsButton.Size = new System.Drawing.Size(103, 36);
            this.matchStatsButton.TabIndex = 21;
            this.matchStatsButton.Text = "FIND STATS";
            this.matchStatsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matchStatsButton.UseAccentColor = true;
            this.matchStatsButton.UseVisualStyleBackColor = true;
            this.matchStatsButton.Click += new System.EventHandler(this.matchStatsButton_Click);
            // 
            // matchPlayerDataSheet
            // 
            this.matchPlayerDataSheet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.matchPlayerDataSheet.AllowUserToAddRows = false;
            this.matchPlayerDataSheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matchPlayerDataSheet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(18, 1, 1, 1);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matchPlayerDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.matchPlayerDataSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchPlayerDataSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchPlayer,
            this.matchKills,
            this.matchKills26,
            this.matchMedianKills,
            this.matchRating,
            this.matchMapsPlayed});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matchPlayerDataSheet.DefaultCellStyle = dataGridViewCellStyle11;
            this.matchPlayerDataSheet.Location = new System.Drawing.Point(18, 184);
            this.matchPlayerDataSheet.Name = "matchPlayerDataSheet";
            this.matchPlayerDataSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matchPlayerDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.matchPlayerDataSheet.RowHeadersVisible = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matchPlayerDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.matchPlayerDataSheet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.matchPlayerDataSheet.Size = new System.Drawing.Size(652, 179);
            this.matchPlayerDataSheet.TabIndex = 20;
            // 
            // matchPlayer
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(3, 3, 1, 1);
            this.matchPlayer.DefaultCellStyle = dataGridViewCellStyle9;
            this.matchPlayer.HeaderText = "Player";
            this.matchPlayer.Name = "matchPlayer";
            // 
            // matchKills
            // 
            this.matchKills.HeaderText = "Average kills";
            this.matchKills.Name = "matchKills";
            // 
            // matchKills26
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matchKills26.DefaultCellStyle = dataGridViewCellStyle10;
            this.matchKills26.HeaderText = "  Kills in  26,5  rounds";
            this.matchKills26.Name = "matchKills26";
            // 
            // matchMedianKills
            // 
            this.matchMedianKills.HeaderText = "Median kills";
            this.matchMedianKills.Name = "matchMedianKills";
            // 
            // matchRating
            // 
            this.matchRating.HeaderText = "Average rating";
            this.matchRating.Name = "matchRating";
            // 
            // matchMapsPlayed
            // 
            this.matchMapsPlayed.HeaderText = "Maps played";
            this.matchMapsPlayed.Name = "matchMapsPlayed";
            // 
            // searchByMatchBox
            // 
            this.searchByMatchBox.AnimateReadOnly = false;
            this.searchByMatchBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchByMatchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchByMatchBox.Depth = 0;
            this.searchByMatchBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchByMatchBox.ForeColor = System.Drawing.Color.LightGray;
            this.searchByMatchBox.Hint = "Enter match URL";
            this.searchByMatchBox.LeadingIcon = null;
            this.searchByMatchBox.LeaveOnEnterKey = true;
            this.searchByMatchBox.Location = new System.Drawing.Point(18, 47);
            this.searchByMatchBox.MaxLength = 50;
            this.searchByMatchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchByMatchBox.Multiline = false;
            this.searchByMatchBox.Name = "searchByMatchBox";
            this.searchByMatchBox.Size = new System.Drawing.Size(272, 36);
            this.searchByMatchBox.TabIndex = 16;
            this.searchByMatchBox.Text = "";
            this.searchByMatchBox.TrailingIcon = null;
            this.searchByMatchBox.UseTallSize = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(246, 25);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(364, 36);
            this.materialTabSelector1.TabIndex = 9;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // delaySlider
            // 
            this.delaySlider.Depth = 0;
            this.delaySlider.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.delaySlider.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.delaySlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delaySlider.Location = new System.Drawing.Point(627, 131);
            this.delaySlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.delaySlider.Name = "delaySlider";
            this.delaySlider.RangeMax = 2000;
            this.delaySlider.Size = new System.Drawing.Size(249, 40);
            this.delaySlider.TabIndex = 24;
            this.delaySlider.Text = "Request delay (ms)";
            this.delaySlider.UseAccentColor = true;
            this.delaySlider.Value = 500;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel2.Location = new System.Drawing.Point(624, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 14);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "(To prevent rate limit)";
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSlider1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(627, 131);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.RangeMax = 2000;
            this.materialSlider1.Size = new System.Drawing.Size(249, 40);
            this.materialSlider1.TabIndex = 27;
            this.materialSlider1.Text = "Request delay (ms)";
            this.materialSlider1.UseAccentColor = true;
            this.materialSlider1.Value = 500;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel3.Location = new System.Drawing.Point(624, 157);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(117, 14);
            this.materialLabel3.TabIndex = 28;
            this.materialLabel3.Text = "(To prevent rate limit)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 472);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HLTV Stats Collector";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSheet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchPlayerDataSheet)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTextBox searchPlayerBox;
        private MaterialSkin.Controls.MaterialComboBox mapPickBox;
        private MaterialSkin.Controls.MaterialTextBox startDateBox;
        private MaterialSkin.Controls.MaterialButton button1;
        private System.Windows.Forms.DataGridView playerDataSheet;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader statAvgKills;
        private System.Windows.Forms.ColumnHeader statAvgKillsPer26;
        private System.Windows.Forms.ColumnHeader statMedianKills;
        private System.Windows.Forms.ColumnHeader statAvgRating;
        private System.Windows.Forms.ColumnHeader statAvgRounds;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox rankingBox;
        private MaterialSkin.Controls.MaterialTextBox searchByMatchBox;
        private MaterialSkin.Controls.MaterialProgressBar byPlayerProgressBar;
        private System.Windows.Forms.DataGridView matchPlayerDataSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerTeamRounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundDivider;
        private System.Windows.Forms.DataGridViewTextBoxColumn opponentTeamRounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn opponentTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerKillsAndDeaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerRating;
        private MaterialSkin.Controls.MaterialButton matchStatsButton;
        private MaterialSkin.Controls.MaterialComboBox matchRankingBox;
        private MaterialSkin.Controls.MaterialTextBox matchStartdateBox;
        private MaterialSkin.Controls.MaterialComboBox matchMapBox;
        private MaterialSkin.Controls.MaterialProgressBar matchProgressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchKills;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchKills26;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchMedianKills;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchMapsPlayed;
        private MaterialSkin.Controls.MaterialSlider delaySlider;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}

