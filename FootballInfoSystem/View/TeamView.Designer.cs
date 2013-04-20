namespace FootballInfoSystem.View {
    partial class TeamView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.teamControl = new System.Windows.Forms.TabControl();
            this.teamInfoTab = new System.Windows.Forms.TabPage();
            this.lblCoachData = new System.Windows.Forms.Label();
            this.lblStadiumData = new System.Windows.Forms.Label();
            this.lblFoundedData = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblCoach = new System.Windows.Forms.Label();
            this.lblTeamFounded = new System.Windows.Forms.Label();
            this.teamSquadTab = new System.Windows.Forms.TabPage();
            this.teamStatsTab = new System.Windows.Forms.TabPage();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureTeamLogo = new System.Windows.Forms.PictureBox();
            this.teamControl.SuspendLayout();
            this.teamInfoTab.SuspendLayout();
            this.teamStatsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // teamControl
            // 
            this.teamControl.Controls.Add(this.teamInfoTab);
            this.teamControl.Controls.Add(this.teamSquadTab);
            this.teamControl.Controls.Add(this.teamStatsTab);
            this.teamControl.Location = new System.Drawing.Point(13, 13);
            this.teamControl.Name = "teamControl";
            this.teamControl.SelectedIndex = 0;
            this.teamControl.Size = new System.Drawing.Size(567, 347);
            this.teamControl.TabIndex = 0;
            // 
            // teamInfoTab
            // 
            this.teamInfoTab.Controls.Add(this.pictureTeamLogo);
            this.teamInfoTab.Controls.Add(this.lblTeamName);
            this.teamInfoTab.Controls.Add(this.lblCoachData);
            this.teamInfoTab.Controls.Add(this.lblStadiumData);
            this.teamInfoTab.Controls.Add(this.lblFoundedData);
            this.teamInfoTab.Controls.Add(this.lblStadium);
            this.teamInfoTab.Controls.Add(this.lblCoach);
            this.teamInfoTab.Controls.Add(this.lblTeamFounded);
            this.teamInfoTab.Location = new System.Drawing.Point(4, 22);
            this.teamInfoTab.Name = "teamInfoTab";
            this.teamInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.teamInfoTab.Size = new System.Drawing.Size(559, 321);
            this.teamInfoTab.TabIndex = 0;
            this.teamInfoTab.Text = "Информация";
            this.teamInfoTab.UseVisualStyleBackColor = true;
            // 
            // lblCoachData
            // 
            this.lblCoachData.AutoSize = true;
            this.lblCoachData.Location = new System.Drawing.Point(256, 147);
            this.lblCoachData.Name = "lblCoachData";
            this.lblCoachData.Size = new System.Drawing.Size(35, 13);
            this.lblCoachData.TabIndex = 2;
            this.lblCoachData.Text = "label1";
            // 
            // lblStadiumData
            // 
            this.lblStadiumData.AutoSize = true;
            this.lblStadiumData.Location = new System.Drawing.Point(256, 110);
            this.lblStadiumData.Name = "lblStadiumData";
            this.lblStadiumData.Size = new System.Drawing.Size(35, 13);
            this.lblStadiumData.TabIndex = 2;
            this.lblStadiumData.Text = "label1";
            // 
            // lblFoundedData
            // 
            this.lblFoundedData.AutoSize = true;
            this.lblFoundedData.Location = new System.Drawing.Point(256, 75);
            this.lblFoundedData.Name = "lblFoundedData";
            this.lblFoundedData.Size = new System.Drawing.Size(35, 13);
            this.lblFoundedData.TabIndex = 2;
            this.lblFoundedData.Text = "label1";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(174, 110);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(52, 13);
            this.lblStadium.TabIndex = 1;
            this.lblStadium.Text = "Стадион:";
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Location = new System.Drawing.Point(173, 147);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(53, 13);
            this.lblCoach.TabIndex = 1;
            this.lblCoach.Text = "Треньор:";
            // 
            // lblTeamFounded
            // 
            this.lblTeamFounded.AutoSize = true;
            this.lblTeamFounded.Location = new System.Drawing.Point(173, 75);
            this.lblTeamFounded.Name = "lblTeamFounded";
            this.lblTeamFounded.Size = new System.Drawing.Size(66, 13);
            this.lblTeamFounded.TabIndex = 1;
            this.lblTeamFounded.Text = "Създаване:";
            // 
            // teamSquadTab
            // 
            this.teamSquadTab.Location = new System.Drawing.Point(4, 22);
            this.teamSquadTab.Name = "teamSquadTab";
            this.teamSquadTab.Padding = new System.Windows.Forms.Padding(3);
            this.teamSquadTab.Size = new System.Drawing.Size(559, 321);
            this.teamSquadTab.TabIndex = 1;
            this.teamSquadTab.Text = "Състав";
            this.teamSquadTab.UseVisualStyleBackColor = true;
            // 
            // teamStatsTab
            // 
            this.teamStatsTab.Controls.Add(this.statisticsChart);
            this.teamStatsTab.Location = new System.Drawing.Point(4, 22);
            this.teamStatsTab.Name = "teamStatsTab";
            this.teamStatsTab.Padding = new System.Windows.Forms.Padding(3);
            this.teamStatsTab.Size = new System.Drawing.Size(559, 321);
            this.teamStatsTab.TabIndex = 2;
            this.teamStatsTab.Text = "Статистика";
            this.teamStatsTab.UseVisualStyleBackColor = true;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeamName.Location = new System.Drawing.Point(33, 13);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(53, 18);
            this.lblTeamName.TabIndex = 3;
            this.lblTeamName.Text = "label1";
            // 
            // statisticsChart
            // 
            chartArea3.Name = "ChartArea1";
            this.statisticsChart.ChartAreas.Add(chartArea3);
            this.statisticsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsChart.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            legend3.Name = "Legend1";
            this.statisticsChart.Legends.Add(legend3);
            this.statisticsChart.Location = new System.Drawing.Point(3, 3);
            this.statisticsChart.Name = "statisticsChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Default";
            this.statisticsChart.Series.Add(series3);
            this.statisticsChart.Size = new System.Drawing.Size(553, 315);
            this.statisticsChart.TabIndex = 0;
            this.statisticsChart.Text = "chart1";
            // 
            // pictureTeamLogo
            // 
            this.pictureTeamLogo.ErrorImage = global::FootballInfoSystem.Properties.Resources.default_img;
            this.pictureTeamLogo.Location = new System.Drawing.Point(9, 43);
            this.pictureTeamLogo.Name = "pictureTeamLogo";
            this.pictureTeamLogo.Size = new System.Drawing.Size(144, 144);
            this.pictureTeamLogo.TabIndex = 4;
            this.pictureTeamLogo.TabStop = false;
            // 
            // TeamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 366);
            this.Controls.Add(this.teamControl);
            this.Name = "TeamView";
            this.Text = "TeamView";
            this.teamControl.ResumeLayout(false);
            this.teamInfoTab.ResumeLayout(false);
            this.teamInfoTab.PerformLayout();
            this.teamStatsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeamLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl teamControl;
        private System.Windows.Forms.TabPage teamInfoTab;
        private System.Windows.Forms.TabPage teamSquadTab;
        private System.Windows.Forms.TabPage teamStatsTab;
        private System.Windows.Forms.Label lblCoachData;
        private System.Windows.Forms.Label lblStadiumData;
        private System.Windows.Forms.Label lblFoundedData;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.Label lblTeamFounded;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
        private System.Windows.Forms.PictureBox pictureTeamLogo;
    }
}