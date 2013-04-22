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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.standingTab = new System.Windows.Forms.TabPage();
            this.leagueNameLabelStandingTab = new System.Windows.Forms.Label();
            this.leagueCountryImageStandingTab = new System.Windows.Forms.PictureBox();
            this.standingGridView = new System.Windows.Forms.DataGridView();
            this.programTab = new System.Windows.Forms.TabPage();
            this.leagueNameLabel = new System.Windows.Forms.Label();
            this.programGridView = new System.Windows.Forms.DataGridView();
            this.leagueCountryImage = new System.Windows.Forms.PictureBox();
            this.forecastTab = new System.Windows.Forms.TabPage();
            this.predictionsDataGrid = new System.Windows.Forms.DataGridView();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.footballersTab = new System.Windows.Forms.TabPage();
            this.footballersGridView = new System.Windows.Forms.DataGridView();
            this.lblFavouriteTeam = new System.Windows.Forms.Label();
            this.favoriteTeamCombo = new System.Windows.Forms.ComboBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new System.Windows.Forms.Label();
            this.addFavoriteTeamImage = new System.Windows.Forms.PictureBox();
            this.predictionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeWinCoefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawCoefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayWinCoefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTab.SuspendLayout();
            this.standingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leagueCountryImageStandingTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standingGridView)).BeginInit();
            this.programTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueCountryImage)).BeginInit();
            this.forecastTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predictionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.footballersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footballersGridView)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addFavoriteTeamImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictionBindingSource)).BeginInit();
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
            this.standingTab.Controls.Add(this.leagueNameLabelStandingTab);
            this.standingTab.Controls.Add(this.leagueCountryImageStandingTab);
            this.standingTab.Controls.Add(this.standingGridView);
            this.standingTab.Location = new System.Drawing.Point(4, 22);
            this.standingTab.Name = "standingTab";
            this.standingTab.Padding = new System.Windows.Forms.Padding(3);
            this.standingTab.Size = new System.Drawing.Size(615, 261);
            this.standingTab.TabIndex = 0;
            this.standingTab.Text = "Класиране";
            this.standingTab.UseVisualStyleBackColor = true;
            // 
            // leagueNameLabelStandingTab
            // 
            this.leagueNameLabelStandingTab.AutoSize = true;
            this.leagueNameLabelStandingTab.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leagueNameLabelStandingTab.Location = new System.Drawing.Point(90, 3);
            this.leagueNameLabelStandingTab.Name = "leagueNameLabelStandingTab";
            this.leagueNameLabelStandingTab.Size = new System.Drawing.Size(47, 29);
            this.leagueNameLabelStandingTab.TabIndex = 2;
            this.leagueNameLabelStandingTab.Text = "asd";
            // 
            // leagueCountryImageStandingTab
            // 
            this.leagueCountryImageStandingTab.ErrorImage = global::FootballInfoSystem.Properties.Resources._default;
            this.leagueCountryImageStandingTab.Location = new System.Drawing.Point(0, 0);
            this.leagueCountryImageStandingTab.Name = "leagueCountryImageStandingTab";
            this.leagueCountryImageStandingTab.Size = new System.Drawing.Size(75, 43);
            this.leagueCountryImageStandingTab.TabIndex = 1;
            this.leagueCountryImageStandingTab.TabStop = false;
            // 
            // standingGridView
            // 
            this.standingGridView.AllowUserToAddRows = false;
            this.standingGridView.AllowUserToDeleteRows = false;
            this.standingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.standingGridView.Location = new System.Drawing.Point(-1, 49);
            this.standingGridView.Name = "standingGridView";
            this.standingGridView.ReadOnly = true;
            this.standingGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.standingGridView.Size = new System.Drawing.Size(616, 216);
            this.standingGridView.TabIndex = 0;
            this.standingGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.standingGridView_RowHeaderMouseClick);
            // 
            // programTab
            // 
            this.programTab.Controls.Add(this.leagueNameLabel);
            this.programTab.Controls.Add(this.programGridView);
            this.programTab.Controls.Add(this.leagueCountryImage);
            this.programTab.Location = new System.Drawing.Point(4, 22);
            this.programTab.Name = "programTab";
            this.programTab.Padding = new System.Windows.Forms.Padding(3);
            this.programTab.Size = new System.Drawing.Size(615, 261);
            this.programTab.TabIndex = 1;
            this.programTab.Text = "Програма";
            this.programTab.UseVisualStyleBackColor = true;
            // 
            // leagueNameLabel
            // 
            this.leagueNameLabel.AutoSize = true;
            this.leagueNameLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leagueNameLabel.Location = new System.Drawing.Point(90, 3);
            this.leagueNameLabel.Name = "leagueNameLabel";
            this.leagueNameLabel.Size = new System.Drawing.Size(47, 29);
            this.leagueNameLabel.TabIndex = 3;
            this.leagueNameLabel.Text = "asd";
            // 
            // programGridView
            // 
            this.programGridView.AllowUserToAddRows = false;
            this.programGridView.AllowUserToDeleteRows = false;
            this.programGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programGridView.Location = new System.Drawing.Point(-4, 48);
            this.programGridView.Name = "programGridView";
            this.programGridView.ReadOnly = true;
            this.programGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.programGridView.Size = new System.Drawing.Size(619, 213);
            this.programGridView.TabIndex = 0;
            // 
            // leagueCountryImage
            // 
            this.leagueCountryImage.Location = new System.Drawing.Point(0, 0);
            this.leagueCountryImage.Name = "leagueCountryImage";
            this.leagueCountryImage.Size = new System.Drawing.Size(75, 42);
            this.leagueCountryImage.TabIndex = 1;
            this.leagueCountryImage.TabStop = false;
            // 
            // forecastTab
            // 
            this.forecastTab.Controls.Add(this.predictionsDataGrid);
            this.forecastTab.Controls.Add(this.statisticsChart);
            this.forecastTab.Location = new System.Drawing.Point(4, 22);
            this.forecastTab.Name = "forecastTab";
            this.forecastTab.Padding = new System.Windows.Forms.Padding(3);
            this.forecastTab.Size = new System.Drawing.Size(615, 261);
            this.forecastTab.TabIndex = 2;
            this.forecastTab.Text = "Прогнози";
            this.forecastTab.UseVisualStyleBackColor = true;
            // 
            // predictionsDataGrid
            // 
            this.predictionsDataGrid.AutoGenerateColumns = false;
            this.predictionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predictionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.homeTeamDataGridViewTextBoxColumn,
            this.homeWinCoefDataGridViewTextBoxColumn,
            this.drawCoefDataGridViewTextBoxColumn,
            this.awayWinCoefDataGridViewTextBoxColumn,
            this.awayTeamDataGridViewTextBoxColumn});
            this.predictionsDataGrid.DataSource = this.predictionBindingSource;
            this.predictionsDataGrid.Location = new System.Drawing.Point(3, 4);
            this.predictionsDataGrid.Name = "predictionsDataGrid";
            this.predictionsDataGrid.Size = new System.Drawing.Size(346, 251);
            this.predictionsDataGrid.TabIndex = 1;
            // 
            // statisticsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.statisticsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statisticsChart.Legends.Add(legend1);
            this.statisticsChart.Location = new System.Drawing.Point(359, 0);
            this.statisticsChart.Name = "statisticsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Default";
            this.statisticsChart.Series.Add(series1);
            this.statisticsChart.Size = new System.Drawing.Size(274, 268);
            this.statisticsChart.TabIndex = 0;
            this.statisticsChart.Text = "Team statistics";
            // 
            // footballersTab
            // 
            this.footballersTab.Controls.Add(this.footballersGridView);
            this.footballersTab.Location = new System.Drawing.Point(4, 22);
            this.footballersTab.Name = "footballersTab";
            this.footballersTab.Padding = new System.Windows.Forms.Padding(3);
            this.footballersTab.Size = new System.Drawing.Size(615, 261);
            this.footballersTab.TabIndex = 3;
            this.footballersTab.Text = "Футболисти";
            this.footballersTab.UseVisualStyleBackColor = true;
            // 
            // footballersGridView
            // 
            this.footballersGridView.AllowUserToAddRows = false;
            this.footballersGridView.AllowUserToDeleteRows = false;
            this.footballersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.footballersGridView.Location = new System.Drawing.Point(7, 7);
            this.footballersGridView.Name = "footballersGridView";
            this.footballersGridView.ReadOnly = true;
            this.footballersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.footballersGridView.Size = new System.Drawing.Size(602, 248);
            this.footballersGridView.TabIndex = 0;
            this.footballersGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.footballersGridView_RowHeaderMouseClick);
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
            this.logoutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(653, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.adminToolStripMenuItem.Text = "Админ";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.logoutToolStripMenuItem.Text = "Отписване";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(512, 34);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "label1";
            // 
            // addFavoriteTeamImage
            // 
            this.addFavoriteTeamImage.Image = global::FootballInfoSystem.Properties.Resources.add;
            this.addFavoriteTeamImage.Location = new System.Drawing.Point(224, 34);
            this.addFavoriteTeamImage.Name = "addFavoriteTeamImage";
            this.addFavoriteTeamImage.Size = new System.Drawing.Size(25, 25);
            this.addFavoriteTeamImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addFavoriteTeamImage.TabIndex = 3;
            this.addFavoriteTeamImage.TabStop = false;
            this.addFavoriteTeamImage.Click += new System.EventHandler(this.addFavoriteTeamImage_Click);
            // 
            // predictionBindingSource
            // 
            this.predictionBindingSource.DataSource = typeof(FootballInfoSystem.Logic.Prediction);
            // 
            // homeTeamDataGridViewTextBoxColumn
            // 
            this.homeTeamDataGridViewTextBoxColumn.DataPropertyName = "homeTeam";
            this.homeTeamDataGridViewTextBoxColumn.HeaderText = "homeTeam";
            this.homeTeamDataGridViewTextBoxColumn.Name = "homeTeamDataGridViewTextBoxColumn";
            this.homeTeamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homeWinCoefDataGridViewTextBoxColumn
            // 
            this.homeWinCoefDataGridViewTextBoxColumn.DataPropertyName = "homeWinCoef";
            this.homeWinCoefDataGridViewTextBoxColumn.HeaderText = "homeWinCoef";
            this.homeWinCoefDataGridViewTextBoxColumn.Name = "homeWinCoefDataGridViewTextBoxColumn";
            this.homeWinCoefDataGridViewTextBoxColumn.ReadOnly = true;
            this.homeWinCoefDataGridViewTextBoxColumn.Width = 30;
            // 
            // drawCoefDataGridViewTextBoxColumn
            // 
            this.drawCoefDataGridViewTextBoxColumn.DataPropertyName = "drawCoef";
            this.drawCoefDataGridViewTextBoxColumn.HeaderText = "drawCoef";
            this.drawCoefDataGridViewTextBoxColumn.Name = "drawCoefDataGridViewTextBoxColumn";
            this.drawCoefDataGridViewTextBoxColumn.ReadOnly = true;
            this.drawCoefDataGridViewTextBoxColumn.Width = 30;
            // 
            // awayWinCoefDataGridViewTextBoxColumn
            // 
            this.awayWinCoefDataGridViewTextBoxColumn.DataPropertyName = "awayWinCoef";
            this.awayWinCoefDataGridViewTextBoxColumn.HeaderText = "awayWinCoef";
            this.awayWinCoefDataGridViewTextBoxColumn.Name = "awayWinCoefDataGridViewTextBoxColumn";
            this.awayWinCoefDataGridViewTextBoxColumn.ReadOnly = true;
            this.awayWinCoefDataGridViewTextBoxColumn.Width = 30;
            // 
            // awayTeamDataGridViewTextBoxColumn
            // 
            this.awayTeamDataGridViewTextBoxColumn.DataPropertyName = "awayTeam";
            this.awayTeamDataGridViewTextBoxColumn.HeaderText = "awayTeam";
            this.awayTeamDataGridViewTextBoxColumn.Name = "awayTeamDataGridViewTextBoxColumn";
            this.awayTeamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 368);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.addFavoriteTeamImage);
            this.Controls.Add(this.favoriteTeamCombo);
            this.Controls.Add(this.lblFavouriteTeam);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.mainMenu);
            this.Name = "HomeView";
            this.Text = "Футболна информационна система";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeView_FormClosing);
            this.mainTab.ResumeLayout(false);
            this.standingTab.ResumeLayout(false);
            this.standingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leagueCountryImageStandingTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standingGridView)).EndInit();
            this.programTab.ResumeLayout(false);
            this.programTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueCountryImage)).EndInit();
            this.forecastTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.predictionsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            this.footballersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.footballersGridView)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addFavoriteTeamImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictionBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TabPage forecastTab;
        private System.Windows.Forms.TabPage footballersTab;
        private System.Windows.Forms.DataGridView standingGridView;
        private System.Windows.Forms.Label leagueNameLabelStandingTab;
        private System.Windows.Forms.PictureBox leagueCountryImageStandingTab;
        private System.Windows.Forms.DataGridView programGridView;
        private System.Windows.Forms.PictureBox leagueCountryImage;
	private System.Windows.Forms.Label leagueNameLabel;
    private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView footballersGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
        private System.Windows.Forms.DataGridView predictionsDataGrid;
        private System.Windows.Forms.BindingSource predictionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTeamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeWinCoefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawCoefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayWinCoefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayTeamDataGridViewTextBoxColumn;
    }
}