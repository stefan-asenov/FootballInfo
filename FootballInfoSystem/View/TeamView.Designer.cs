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
            System.Windows.Forms.PictureBox pictureTeamLogo;
            this.teamControl = new System.Windows.Forms.TabControl();
            this.teamInfoTab = new System.Windows.Forms.TabPage();
            this.teamSquadTab = new System.Windows.Forms.TabPage();
            this.teamStatsTab = new System.Windows.Forms.TabPage();
            this.lblTeamFounded = new System.Windows.Forms.Label();
            this.lblCoach = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblPresident = new System.Windows.Forms.Label();
            this.lblFoundedData = new System.Windows.Forms.Label();
            this.lblStadiumData = new System.Windows.Forms.Label();
            this.lblPresidentData = new System.Windows.Forms.Label();
            this.lblCoachData = new System.Windows.Forms.Label();
            pictureTeamLogo = new System.Windows.Forms.PictureBox();
            this.teamControl.SuspendLayout();
            this.teamInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureTeamLogo)).BeginInit();
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
            this.teamInfoTab.Controls.Add(this.lblCoachData);
            this.teamInfoTab.Controls.Add(this.lblPresidentData);
            this.teamInfoTab.Controls.Add(this.lblStadiumData);
            this.teamInfoTab.Controls.Add(this.lblFoundedData);
            this.teamInfoTab.Controls.Add(this.lblStadium);
            this.teamInfoTab.Controls.Add(this.lblPresident);
            this.teamInfoTab.Controls.Add(this.lblCoach);
            this.teamInfoTab.Controls.Add(this.lblTeamFounded);
            this.teamInfoTab.Controls.Add(pictureTeamLogo);
            this.teamInfoTab.Location = new System.Drawing.Point(4, 22);
            this.teamInfoTab.Name = "teamInfoTab";
            this.teamInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.teamInfoTab.Size = new System.Drawing.Size(559, 321);
            this.teamInfoTab.TabIndex = 0;
            this.teamInfoTab.Text = "Информация";
            this.teamInfoTab.UseVisualStyleBackColor = true;
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
            this.teamStatsTab.Location = new System.Drawing.Point(4, 22);
            this.teamStatsTab.Name = "teamStatsTab";
            this.teamStatsTab.Padding = new System.Windows.Forms.Padding(3);
            this.teamStatsTab.Size = new System.Drawing.Size(559, 321);
            this.teamStatsTab.TabIndex = 2;
            this.teamStatsTab.Text = "Статистика";
            this.teamStatsTab.UseVisualStyleBackColor = true;
            // 
            // pictureTeamLogo
            // 
            pictureTeamLogo.Location = new System.Drawing.Point(7, 4);
            pictureTeamLogo.Name = "pictureTeamLogo";
            pictureTeamLogo.Size = new System.Drawing.Size(125, 125);
            pictureTeamLogo.TabIndex = 0;
            pictureTeamLogo.TabStop = false;
            // 
            // lblTeamFounded
            // 
            this.lblTeamFounded.AutoSize = true;
            this.lblTeamFounded.Location = new System.Drawing.Point(138, 4);
            this.lblTeamFounded.Name = "lblTeamFounded";
            this.lblTeamFounded.Size = new System.Drawing.Size(66, 13);
            this.lblTeamFounded.TabIndex = 1;
            this.lblTeamFounded.Text = "Създаване:";
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Location = new System.Drawing.Point(138, 83);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(53, 13);
            this.lblCoach.TabIndex = 1;
            this.lblCoach.Text = "Треньор:";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(138, 30);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(52, 13);
            this.lblStadium.TabIndex = 1;
            this.lblStadium.Text = "Стадион:";
            // 
            // lblPresident
            // 
            this.lblPresident.AutoSize = true;
            this.lblPresident.Location = new System.Drawing.Point(138, 56);
            this.lblPresident.Name = "lblPresident";
            this.lblPresident.Size = new System.Drawing.Size(65, 13);
            this.lblPresident.TabIndex = 1;
            this.lblPresident.Text = "Президент:";
            // 
            // lblFoundedData
            // 
            this.lblFoundedData.AutoSize = true;
            this.lblFoundedData.Location = new System.Drawing.Point(211, 4);
            this.lblFoundedData.Name = "lblFoundedData";
            this.lblFoundedData.Size = new System.Drawing.Size(35, 13);
            this.lblFoundedData.TabIndex = 2;
            this.lblFoundedData.Text = "label1";
            // 
            // lblStadiumData
            // 
            this.lblStadiumData.AutoSize = true;
            this.lblStadiumData.Location = new System.Drawing.Point(211, 30);
            this.lblStadiumData.Name = "lblStadiumData";
            this.lblStadiumData.Size = new System.Drawing.Size(35, 13);
            this.lblStadiumData.TabIndex = 2;
            this.lblStadiumData.Text = "label1";
            // 
            // lblPresidentData
            // 
            this.lblPresidentData.AutoSize = true;
            this.lblPresidentData.Location = new System.Drawing.Point(211, 56);
            this.lblPresidentData.Name = "lblPresidentData";
            this.lblPresidentData.Size = new System.Drawing.Size(35, 13);
            this.lblPresidentData.TabIndex = 2;
            this.lblPresidentData.Text = "label1";
            // 
            // lblCoachData
            // 
            this.lblCoachData.AutoSize = true;
            this.lblCoachData.Location = new System.Drawing.Point(211, 83);
            this.lblCoachData.Name = "lblCoachData";
            this.lblCoachData.Size = new System.Drawing.Size(35, 13);
            this.lblCoachData.TabIndex = 2;
            this.lblCoachData.Text = "label1";
            // 
            // TeamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 263);
            this.Controls.Add(this.teamControl);
            this.Name = "TeamView";
            this.Text = "TeamView";
            this.teamControl.ResumeLayout(false);
            this.teamInfoTab.ResumeLayout(false);
            this.teamInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureTeamLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl teamControl;
        private System.Windows.Forms.TabPage teamInfoTab;
        private System.Windows.Forms.TabPage teamSquadTab;
        private System.Windows.Forms.TabPage teamStatsTab;
        private System.Windows.Forms.Label lblCoachData;
        private System.Windows.Forms.Label lblPresidentData;
        private System.Windows.Forms.Label lblStadiumData;
        private System.Windows.Forms.Label lblFoundedData;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblPresident;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.Label lblTeamFounded;
    }
}