﻿namespace FootballInfoSystem.View
{
    partial class HomeView
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
            this.mainTab = new System.Windows.Forms.TabControl();
            this.standingTab = new System.Windows.Forms.TabPage();
            this.leagueNameLabel = new System.Windows.Forms.Label();
            this.leagueCountryImage = new System.Windows.Forms.PictureBox();
            this.standingGridView = new System.Windows.Forms.DataGridView();
            this.programTab = new System.Windows.Forms.TabPage();
            this.forecastTab = new System.Windows.Forms.TabPage();
            this.footballersTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFavouriteTeam = new System.Windows.Forms.Label();
            this.favoriteTeamCombo = new System.Windows.Forms.ComboBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFavoriteTeamImage = new System.Windows.Forms.PictureBox();
            this.mainTab.SuspendLayout();
            this.standingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leagueCountryImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standingGridView)).BeginInit();
            this.footballersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addFavoriteTeamImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.standingTab);
            this.mainTab.Controls.Add(this.programTab);
            this.mainTab.Controls.Add(this.forecastTab);
            this.mainTab.Controls.Add(this.footballersTab);
            this.mainTab.Location = new System.Drawing.Point(16, 66);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(623, 287);
            this.mainTab.TabIndex = 0;
            // 
            // standingTab
            // 
            this.standingTab.Controls.Add(this.leagueNameLabel);
            this.standingTab.Controls.Add(this.leagueCountryImage);
            this.standingTab.Controls.Add(this.standingGridView);
            this.standingTab.Location = new System.Drawing.Point(4, 22);
            this.standingTab.Name = "standingTab";
            this.standingTab.Padding = new System.Windows.Forms.Padding(3);
            this.standingTab.Size = new System.Drawing.Size(615, 261);
            this.standingTab.TabIndex = 0;
            this.standingTab.Text = "Класиране";
            this.standingTab.UseVisualStyleBackColor = true;
            // 
            // leagueNameLabel
            // 
            this.leagueNameLabel.AutoSize = true;
            this.leagueNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leagueNameLabel.Location = new System.Drawing.Point(88, 13);
            this.leagueNameLabel.Name = "leagueNameLabel";
            this.leagueNameLabel.Size = new System.Drawing.Size(38, 20);
            this.leagueNameLabel.TabIndex = 2;
            this.leagueNameLabel.Text = "asd";
            // 
            // leagueCountryImage
            // 
            this.leagueCountryImage.ErrorImage = global::FootballInfoSystem.Properties.Resources._default;
            this.leagueCountryImage.Location = new System.Drawing.Point(0, 0);
            this.leagueCountryImage.Name = "leagueCountryImage";
            this.leagueCountryImage.Size = new System.Drawing.Size(69, 48);
            this.leagueCountryImage.TabIndex = 1;
            this.leagueCountryImage.TabStop = false;
            // 
            // standingGridView
            // 
            this.standingGridView.AllowUserToAddRows = false;
            this.standingGridView.AllowUserToDeleteRows = false;
            this.standingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.standingGridView.Location = new System.Drawing.Point(-1, 49);
            this.standingGridView.Name = "standingGridView";
            this.standingGridView.ReadOnly = true;
            this.standingGridView.Size = new System.Drawing.Size(616, 216);
            this.standingGridView.TabIndex = 0;
            // 
            // programTab
            // 
            this.programTab.Location = new System.Drawing.Point(4, 22);
            this.programTab.Name = "programTab";
            this.programTab.Padding = new System.Windows.Forms.Padding(3);
            this.programTab.Size = new System.Drawing.Size(615, 261);
            this.programTab.TabIndex = 1;
            this.programTab.Text = "Програма";
            this.programTab.UseVisualStyleBackColor = true;
            // 
            // forecastTab
            // 
            this.forecastTab.Location = new System.Drawing.Point(4, 22);
            this.forecastTab.Name = "forecastTab";
            this.forecastTab.Padding = new System.Windows.Forms.Padding(3);
            this.forecastTab.Size = new System.Drawing.Size(615, 261);
            this.forecastTab.TabIndex = 2;
            this.forecastTab.Text = "Прогнози";
            this.forecastTab.UseVisualStyleBackColor = true;
            // 
            // footballersTab
            // 
            this.footballersTab.Controls.Add(this.dataGridView1);
            this.footballersTab.Location = new System.Drawing.Point(4, 22);
            this.footballersTab.Name = "footballersTab";
            this.footballersTab.Padding = new System.Windows.Forms.Padding(3);
            this.footballersTab.Size = new System.Drawing.Size(615, 261);
            this.footballersTab.TabIndex = 3;
            this.footballersTab.Text = "Футболисти";
            this.footballersTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblFavouriteTeam
            // 
            this.lblFavouriteTeam.AutoSize = true;
            this.lblFavouriteTeam.Location = new System.Drawing.Point(17, 37);
            this.lblFavouriteTeam.Name = "lblFavouriteTeam";
            this.lblFavouriteTeam.Size = new System.Drawing.Size(78, 13);
            this.lblFavouriteTeam.TabIndex = 1;
            this.lblFavouriteTeam.Text = "Любим отбор:";
            // 
            // favoriteTeamCombo
            // 
            this.favoriteTeamCombo.FormattingEnabled = true;
            this.favoriteTeamCombo.Location = new System.Drawing.Point(97, 34);
            this.favoriteTeamCombo.Name = "favoriteTeamCombo";
            this.favoriteTeamCombo.Size = new System.Drawing.Size(121, 21);
            this.favoriteTeamCombo.TabIndex = 2;
            this.favoriteTeamCombo.SelectedValueChanged += new System.EventHandler(this.favoriteTeamChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(733, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.adminToolStripMenuItem.Text = "Админ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.exitToolStripMenuItem.Text = "Изход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addFavoriteTeamImage
            // 
            this.addFavoriteTeamImage.Image = global::FootballInfoSystem.Properties.Resources.add;
            this.addFavoriteTeamImage.ImageLocation = "";
            this.addFavoriteTeamImage.Location = new System.Drawing.Point(224, 34);
            this.addFavoriteTeamImage.Name = "addFavoriteTeamImage";
            this.addFavoriteTeamImage.Size = new System.Drawing.Size(25, 25);
            this.addFavoriteTeamImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addFavoriteTeamImage.TabIndex = 3;
            this.addFavoriteTeamImage.TabStop = false;
            this.addFavoriteTeamImage.Click += new System.EventHandler(this.addFavoriteTeamImage_Click);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 406);
            this.Controls.Add(this.addFavoriteTeamImage);
            this.Controls.Add(this.favoriteTeamCombo);
            this.Controls.Add(this.lblFavouriteTeam);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.mainMenu);
            this.Name = "HomeView";
            this.Text = "Футболна информационна система";
            this.mainTab.ResumeLayout(false);
            this.standingTab.ResumeLayout(false);
            this.standingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leagueCountryImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standingGridView)).EndInit();
            this.footballersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addFavoriteTeamImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage standingTab;
        private System.Windows.Forms.TabPage programTab;
        private System.Windows.Forms.Label lblFavouriteTeam;
        private System.Windows.Forms.ComboBox favoriteTeamCombo;
        private System.Windows.Forms.PictureBox addFavoriteTeamImage;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage forecastTab;
        private System.Windows.Forms.TabPage footballersTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView standingGridView;
        private System.Windows.Forms.Label leagueNameLabel;
        private System.Windows.Forms.PictureBox leagueCountryImage;
    }
}