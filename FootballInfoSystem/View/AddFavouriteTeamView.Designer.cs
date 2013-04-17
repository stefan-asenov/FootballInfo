namespace FootballInfoSystem.View {
    partial class AddFavouriteTeamView {
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
            this.comboLeagues = new System.Windows.Forms.ComboBox();
            this.lblChampionship = new System.Windows.Forms.Label();
            this.comboTeams = new System.Windows.Forms.ComboBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboLeagues
            // 
            this.comboLeagues.FormattingEnabled = true;
            this.comboLeagues.Location = new System.Drawing.Point(91, 12);
            this.comboLeagues.Name = "comboLeagues";
            this.comboLeagues.Size = new System.Drawing.Size(157, 21);
            this.comboLeagues.TabIndex = 0;
            this.comboLeagues.SelectedIndexChanged += new System.EventHandler(this.leaguesComboChanged);
            // 
            // lblChampionship
            // 
            this.lblChampionship.AutoSize = true;
            this.lblChampionship.Location = new System.Drawing.Point(13, 12);
            this.lblChampionship.Name = "lblChampionship";
            this.lblChampionship.Size = new System.Drawing.Size(66, 13);
            this.lblChampionship.TabIndex = 1;
            this.lblChampionship.Text = "Първентво:";
            // 
            // comboTeams
            // 
            this.comboTeams.FormattingEnabled = true;
            this.comboTeams.Location = new System.Drawing.Point(91, 39);
            this.comboTeams.Name = "comboTeams";
            this.comboTeams.Size = new System.Drawing.Size(157, 21);
            this.comboTeams.TabIndex = 2;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(13, 39);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(41, 13);
            this.lblTeam.TabIndex = 3;
            this.lblTeam.Text = "Отбор:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(91, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(173, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddFavouriteTeamView
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(260, 109);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.comboTeams);
            this.Controls.Add(this.lblChampionship);
            this.Controls.Add(this.comboLeagues);
            this.Name = "AddFavouriteTeamView";
            this.Text = "Любим отбор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboLeagues;
        private System.Windows.Forms.Label lblChampionship;
        private System.Windows.Forms.ComboBox comboTeams;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}