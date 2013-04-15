namespace FootballInfoSystem.View {
    partial class FootballerView {
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
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.footballerTabControl = new System.Windows.Forms.TabControl();
            this.personalInfoTab = new System.Windows.Forms.TabPage();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.lblPreviousTeams = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBorn = new System.Windows.Forms.Label();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.linkLblCountry = new System.Windows.Forms.LinkLabel();
            this.lblDataBorn = new System.Windows.Forms.Label();
            this.lblDataHeight = new System.Windows.Forms.Label();
            this.lblDataWeight = new System.Windows.Forms.Label();
            this.lblDataNumber = new System.Windows.Forms.Label();
            this.lblDataPreviousTeams = new System.Windows.Forms.Label();
            this.lblDataPosition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.footballerTabControl.SuspendLayout();
            this.personalInfoTab.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // photoBox
            // 
            this.photoBox.Location = new System.Drawing.Point(6, 6);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(124, 171);
            this.photoBox.TabIndex = 1;
            this.photoBox.TabStop = false;
            // 
            // footballerTabControl
            // 
            this.footballerTabControl.Controls.Add(this.personalInfoTab);
            this.footballerTabControl.Controls.Add(this.historyTab);
            this.footballerTabControl.Location = new System.Drawing.Point(13, 12);
            this.footballerTabControl.Name = "footballerTabControl";
            this.footballerTabControl.SelectedIndex = 0;
            this.footballerTabControl.Size = new System.Drawing.Size(409, 290);
            this.footballerTabControl.TabIndex = 2;
            // 
            // personalInfoTab
            // 
            this.personalInfoTab.Controls.Add(this.infoPanel);
            this.personalInfoTab.Controls.Add(this.photoBox);
            this.personalInfoTab.Location = new System.Drawing.Point(4, 22);
            this.personalInfoTab.Name = "personalInfoTab";
            this.personalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalInfoTab.Size = new System.Drawing.Size(401, 264);
            this.personalInfoTab.TabIndex = 0;
            this.personalInfoTab.Text = "Лична информация";
            this.personalInfoTab.UseVisualStyleBackColor = true;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.lblDataPreviousTeams);
            this.infoPanel.Controls.Add(this.lblDataNumber);
            this.infoPanel.Controls.Add(this.lblDataPosition);
            this.infoPanel.Controls.Add(this.lblDataWeight);
            this.infoPanel.Controls.Add(this.lblDataHeight);
            this.infoPanel.Controls.Add(this.lblDataBorn);
            this.infoPanel.Controls.Add(this.linkLblCountry);
            this.infoPanel.Controls.Add(this.lblPreviousTeams);
            this.infoPanel.Controls.Add(this.lblNumber);
            this.infoPanel.Controls.Add(this.lblPosition);
            this.infoPanel.Controls.Add(this.lblWeight);
            this.infoPanel.Controls.Add(this.lblHeight);
            this.infoPanel.Controls.Add(this.lblCountry);
            this.infoPanel.Controls.Add(this.lblName);
            this.infoPanel.Controls.Add(this.lblBorn);
            this.infoPanel.Location = new System.Drawing.Point(136, 7);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(259, 251);
            this.infoPanel.TabIndex = 3;
            // 
            // lblPreviousTeams
            // 
            this.lblPreviousTeams.AutoSize = true;
            this.lblPreviousTeams.Location = new System.Drawing.Point(15, 197);
            this.lblPreviousTeams.Name = "lblPreviousTeams";
            this.lblPreviousTeams.Size = new System.Drawing.Size(100, 13);
            this.lblPreviousTeams.TabIndex = 6;
            this.lblPreviousTeams.Text = "Предишни отбори:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(15, 169);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Номер:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(15, 143);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(35, 13);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Пост:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(15, 118);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(40, 13);
            this.lblWeight.TabIndex = 4;
            this.lblWeight.Text = "Тегло:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(15, 92);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(58, 13);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Височина:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(15, 64);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(58, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Държава:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(23, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ime";
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Location = new System.Drawing.Point(15, 37);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(98, 13);
            this.lblBorn.TabIndex = 2;
            this.lblBorn.Text = "Дата на раждане:";
            // 
            // historyTab
            // 
            this.historyTab.Location = new System.Drawing.Point(4, 22);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyTab.Size = new System.Drawing.Size(401, 264);
            this.historyTab.TabIndex = 1;
            this.historyTab.Text = "История";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // linkLblCountry
            // 
            this.linkLblCountry.AutoSize = true;
            this.linkLblCountry.Location = new System.Drawing.Point(132, 63);
            this.linkLblCountry.Name = "linkLblCountry";
            this.linkLblCountry.Size = new System.Drawing.Size(55, 13);
            this.linkLblCountry.TabIndex = 7;
            this.linkLblCountry.TabStop = true;
            this.linkLblCountry.Text = "linkLabel1";
            this.linkLblCountry.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // lblDataBorn
            // 
            this.lblDataBorn.AutoSize = true;
            this.lblDataBorn.Location = new System.Drawing.Point(132, 37);
            this.lblDataBorn.Name = "lblDataBorn";
            this.lblDataBorn.Size = new System.Drawing.Size(35, 13);
            this.lblDataBorn.TabIndex = 8;
            this.lblDataBorn.Text = "label1";
            // 
            // lblDataHeight
            // 
            this.lblDataHeight.AutoSize = true;
            this.lblDataHeight.Location = new System.Drawing.Point(132, 92);
            this.lblDataHeight.Name = "lblDataHeight";
            this.lblDataHeight.Size = new System.Drawing.Size(35, 13);
            this.lblDataHeight.TabIndex = 8;
            this.lblDataHeight.Text = "label1";
            // 
            // lblDataWeight
            // 
            this.lblDataWeight.AutoSize = true;
            this.lblDataWeight.Location = new System.Drawing.Point(132, 118);
            this.lblDataWeight.Name = "lblDataWeight";
            this.lblDataWeight.Size = new System.Drawing.Size(35, 13);
            this.lblDataWeight.TabIndex = 8;
            this.lblDataWeight.Text = "label1";
            // 
            // lblDataNumber
            // 
            this.lblDataNumber.AutoSize = true;
            this.lblDataNumber.Location = new System.Drawing.Point(132, 169);
            this.lblDataNumber.Name = "lblDataNumber";
            this.lblDataNumber.Size = new System.Drawing.Size(35, 13);
            this.lblDataNumber.TabIndex = 8;
            this.lblDataNumber.Text = "label1";
            // 
            // lblDataPreviousTeams
            // 
            this.lblDataPreviousTeams.AutoSize = true;
            this.lblDataPreviousTeams.Location = new System.Drawing.Point(132, 197);
            this.lblDataPreviousTeams.Name = "lblDataPreviousTeams";
            this.lblDataPreviousTeams.Size = new System.Drawing.Size(35, 13);
            this.lblDataPreviousTeams.TabIndex = 8;
            this.lblDataPreviousTeams.Text = "label1";
            // 
            // lblDataPosition
            // 
            this.lblDataPosition.AutoSize = true;
            this.lblDataPosition.Location = new System.Drawing.Point(132, 143);
            this.lblDataPosition.Name = "lblDataPosition";
            this.lblDataPosition.Size = new System.Drawing.Size(35, 13);
            this.lblDataPosition.TabIndex = 8;
            this.lblDataPosition.Text = "label1";
            // 
            // FootballerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 314);
            this.Controls.Add(this.footballerTabControl);
            this.Name = "FootballerView";
            this.Text = "FootballerView";
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.footballerTabControl.ResumeLayout(false);
            this.personalInfoTab.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.TabControl footballerTabControl;
        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblPreviousTeams;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDataPreviousTeams;
        private System.Windows.Forms.Label lblDataNumber;
        private System.Windows.Forms.Label lblDataPosition;
        private System.Windows.Forms.Label lblDataWeight;
        private System.Windows.Forms.Label lblDataHeight;
        private System.Windows.Forms.Label lblDataBorn;
        private System.Windows.Forms.LinkLabel linkLblCountry;
    }
}