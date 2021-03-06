﻿namespace FootballInfoSystem.View {
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
            this.personalInfoTab = new System.Windows.Forms.TabPage();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.lblBorn = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDataBorn = new System.Windows.Forms.Label();
            this.lblDataHeight = new System.Windows.Forms.Label();
            this.lblDataWeight = new System.Windows.Forms.Label();
            this.lblDataPosition = new System.Windows.Forms.Label();
            this.lblDataNumber = new System.Windows.Forms.Label();
            this.lblDataCountry = new System.Windows.Forms.Label();
            this.footballerTabControl = new System.Windows.Forms.TabControl();
            this.personalInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.footballerTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalInfoTab
            // 
            this.personalInfoTab.Controls.Add(this.infoPanel);
            this.personalInfoTab.Controls.Add(this.photoBox);
            this.personalInfoTab.Location = new System.Drawing.Point(4, 22);
            this.personalInfoTab.Name = "personalInfoTab";
            this.personalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalInfoTab.Size = new System.Drawing.Size(386, 224);
            this.personalInfoTab.TabIndex = 0;
            this.personalInfoTab.Text = "Лична информация";
            this.personalInfoTab.UseVisualStyleBackColor = true;
            // 
            // photoBox
            // 
            this.photoBox.Location = new System.Drawing.Point(6, 6);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(124, 171);
            this.photoBox.TabIndex = 1;
            this.photoBox.TabStop = false;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.lblDataCountry);
            this.infoPanel.Controls.Add(this.lblDataNumber);
            this.infoPanel.Controls.Add(this.lblDataPosition);
            this.infoPanel.Controls.Add(this.lblDataWeight);
            this.infoPanel.Controls.Add(this.lblDataHeight);
            this.infoPanel.Controls.Add(this.lblDataBorn);
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
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Location = new System.Drawing.Point(15, 37);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(98, 13);
            this.lblBorn.TabIndex = 2;
            this.lblBorn.Text = "Дата на раждане:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(15, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ime";
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
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(15, 92);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(58, 13);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Височина:";
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
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(15, 143);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(35, 13);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Пост:";
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
            // lblDataPosition
            // 
            this.lblDataPosition.AutoSize = true;
            this.lblDataPosition.Location = new System.Drawing.Point(132, 143);
            this.lblDataPosition.Name = "lblDataPosition";
            this.lblDataPosition.Size = new System.Drawing.Size(35, 13);
            this.lblDataPosition.TabIndex = 8;
            this.lblDataPosition.Text = "label1";
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
            // lblDataCountry
            // 
            this.lblDataCountry.AutoSize = true;
            this.lblDataCountry.Location = new System.Drawing.Point(132, 64);
            this.lblDataCountry.Name = "lblDataCountry";
            this.lblDataCountry.Size = new System.Drawing.Size(35, 13);
            this.lblDataCountry.TabIndex = 9;
            this.lblDataCountry.Text = "label1";
            // 
            // footballerTabControl
            // 
            this.footballerTabControl.Controls.Add(this.personalInfoTab);
            this.footballerTabControl.Location = new System.Drawing.Point(13, 12);
            this.footballerTabControl.Name = "footballerTabControl";
            this.footballerTabControl.SelectedIndex = 0;
            this.footballerTabControl.Size = new System.Drawing.Size(394, 250);
            this.footballerTabControl.TabIndex = 2;
            // 
            // FootballerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 280);
            this.Controls.Add(this.footballerTabControl);
            this.Name = "FootballerView";
            this.Text = "Информация за футболиста";
            this.personalInfoTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.footballerTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label lblDataCountry;
        private System.Windows.Forms.Label lblDataNumber;
        private System.Windows.Forms.Label lblDataPosition;
        private System.Windows.Forms.Label lblDataWeight;
        private System.Windows.Forms.Label lblDataHeight;
        private System.Windows.Forms.Label lblDataBorn;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.TabControl footballerTabControl;

    }
}