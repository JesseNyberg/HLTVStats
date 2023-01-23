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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.avgKills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.avgKillsPer26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medianKills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.avgRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.avgRounds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rankingBox = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSheet)).BeginInit();
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
            this.materialTabControl1.Location = new System.Drawing.Point(0, 55);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(890, 414);
            this.materialTabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(882, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find by player";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.avgKills,
            this.avgKillsPer26,
            this.medianKills,
            this.avgRating,
            this.avgRounds});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(390, 25);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(480, 100);
            this.materialListView1.TabIndex = 20;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // avgKills
            // 
            this.avgKills.Text = "Kills";
            // 
            // avgKillsPer26
            // 
            this.avgKillsPer26.Text = "Kills (26,5 rounds)";
            this.avgKillsPer26.Width = 150;
            // 
            // medianKills
            // 
            this.medianKills.Text = "Median kills";
            this.medianKills.Width = 110;
            // 
            // avgRating
            // 
            this.avgRating.Text = "Rating";
            this.avgRating.Width = 80;
            // 
            // avgRounds
            // 
            this.avgRounds.Text = "Rounds";
            this.avgRounds.Width = 80;
            // 
            // playerDataSheet
            // 
            this.playerDataSheet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.playerDataSheet.AllowUserToAddRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(18, 1, 1, 1);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playerDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
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
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.playerDataSheet.DefaultCellStyle = dataGridViewCellStyle26;
            this.playerDataSheet.Location = new System.Drawing.Point(6, 183);
            this.playerDataSheet.Name = "playerDataSheet";
            this.playerDataSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playerDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.playerDataSheet.RowHeadersVisible = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.playerDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.playerDataSheet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.playerDataSheet.Size = new System.Drawing.Size(618, 179);
            this.playerDataSheet.TabIndex = 19;
            // 
            // matchDate
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle23.Padding = new System.Windows.Forms.Padding(3, 3, 1, 1);
            this.matchDate.DefaultCellStyle = dataGridViewCellStyle23;
            this.matchDate.HeaderText = "Date";
            this.matchDate.Name = "matchDate";
            // 
            // playerTeam
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.playerTeam.DefaultCellStyle = dataGridViewCellStyle24;
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.opponentTeam.DefaultCellStyle = dataGridViewCellStyle25;
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
            "de_inferno",
            "de_mirage",
            "de_nuke",
            "de_overpass",
            "de_vertigo",
            "de_ancient",
            "de_anubis"});
            this.mapPickBox.Location = new System.Drawing.Point(6, 14);
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
            this.startDateBox.Location = new System.Drawing.Point(6, 97);
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
            this.button1.Location = new System.Drawing.Point(285, 139);
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
            this.searchPlayerBox.Location = new System.Drawing.Point(6, 55);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find by match";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            "All",
            "Top 5",
            "Top 10",
            "Top 20",
            "Top 30",
            "Top 50"});
            this.rankingBox.Location = new System.Drawing.Point(6, 139);
            this.rankingBox.MaxDropDownItems = 4;
            this.rankingBox.MouseState = MaterialSkin.MouseState.OUT;
            this.rankingBox.Name = "rankingBox";
            this.rankingBox.Size = new System.Drawing.Size(272, 35);
            this.rankingBox.StartIndex = 0;
            this.rankingBox.TabIndex = 22;
            this.rankingBox.UseTallSize = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "HLTV Stats Collector";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSheet)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn matchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerTeamRounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundDivider;
        private System.Windows.Forms.DataGridViewTextBoxColumn opponentTeamRounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn opponentTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerKillsAndDeaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerRating;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader avgKills;
        private System.Windows.Forms.ColumnHeader avgKillsPer26;
        private System.Windows.Forms.ColumnHeader medianKills;
        private System.Windows.Forms.ColumnHeader avgRating;
        private System.Windows.Forms.ColumnHeader avgRounds;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox rankingBox;
    }
}

