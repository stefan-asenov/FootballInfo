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
            this.teamControl = new System.Windows.Forms.TabControl();
            this.teamInfoTab = new System.Windows.Forms.TabPage();
            this.teamSquadTab = new System.Windows.Forms.TabPage();
            this.teamStatsTab = new System.Windows.Forms.TabPage();
            this.teamControl.SuspendLayout();
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
            // TeamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 372);
            this.Controls.Add(this.teamControl);
            this.Name = "TeamView";
            this.Text = "TeamView";
            this.teamControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl teamControl;
        private System.Windows.Forms.TabPage teamInfoTab;
        private System.Windows.Forms.TabPage teamSquadTab;
        private System.Windows.Forms.TabPage teamStatsTab;
    }
}