namespace FootballInfoSystem.View {
    partial class AddGamesView {
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.comboChampionship = new System.Windows.Forms.ComboBox();
            this.comboHomeTeam = new System.Windows.Forms.ComboBox();
            this.comboAwayTeam = new System.Windows.Forms.ComboBox();
            this.lblChampionship = new System.Windows.Forms.Label();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtBoxHomeTeam = new System.Windows.Forms.TextBox();
            this.txtBoxAwayTeam = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(223, 12);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(136, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Изход";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(55, 151);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(75, 23);
            this.btnAddGame.TabIndex = 2;
            this.btnAddGame.Text = "Добави";
            this.btnAddGame.UseVisualStyleBackColor = true;
            // 
            // comboChampionship
            // 
            this.comboChampionship.FormattingEnabled = true;
            this.comboChampionship.Location = new System.Drawing.Point(90, 12);
            this.comboChampionship.Name = "comboChampionship";
            this.comboChampionship.Size = new System.Drawing.Size(121, 21);
            this.comboChampionship.TabIndex = 3;
            // 
            // comboHomeTeam
            // 
            this.comboHomeTeam.FormattingEnabled = true;
            this.comboHomeTeam.Location = new System.Drawing.Point(90, 42);
            this.comboHomeTeam.Name = "comboHomeTeam";
            this.comboHomeTeam.Size = new System.Drawing.Size(121, 21);
            this.comboHomeTeam.TabIndex = 3;
            // 
            // comboAwayTeam
            // 
            this.comboAwayTeam.FormattingEnabled = true;
            this.comboAwayTeam.Location = new System.Drawing.Point(90, 72);
            this.comboAwayTeam.Name = "comboAwayTeam";
            this.comboAwayTeam.Size = new System.Drawing.Size(121, 21);
            this.comboAwayTeam.TabIndex = 3;
            // 
            // lblChampionship
            // 
            this.lblChampionship.AutoSize = true;
            this.lblChampionship.Location = new System.Drawing.Point(12, 12);
            this.lblChampionship.Name = "lblChampionship";
            this.lblChampionship.Size = new System.Drawing.Size(72, 13);
            this.lblChampionship.TabIndex = 4;
            this.lblChampionship.Text = "Първенство:";
            // 
            // lblAwayTeam
            // 
            this.lblAwayTeam.AutoSize = true;
            this.lblAwayTeam.Location = new System.Drawing.Point(12, 72);
            this.lblAwayTeam.Name = "lblAwayTeam";
            this.lblAwayTeam.Size = new System.Drawing.Size(33, 13);
            this.lblAwayTeam.TabIndex = 5;
            this.lblAwayTeam.Text = "Гост:";
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Location = new System.Drawing.Point(12, 42);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(57, 13);
            this.lblHomeTeam.TabIndex = 6;
            this.lblHomeTeam.Text = "Домакин:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 99);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(56, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Резултат:";
            // 
            // txtBoxHomeTeam
            // 
            this.txtBoxHomeTeam.Location = new System.Drawing.Point(100, 99);
            this.txtBoxHomeTeam.Name = "txtBoxHomeTeam";
            this.txtBoxHomeTeam.Size = new System.Drawing.Size(40, 20);
            this.txtBoxHomeTeam.TabIndex = 8;
            // 
            // txtBoxAwayTeam
            // 
            this.txtBoxAwayTeam.Location = new System.Drawing.Point(162, 99);
            this.txtBoxAwayTeam.Name = "txtBoxAwayTeam";
            this.txtBoxAwayTeam.Size = new System.Drawing.Size(40, 20);
            this.txtBoxAwayTeam.TabIndex = 9;
            // 
            // lblColon
            // 
            this.lblColon.AutoSize = true;
            this.lblColon.Location = new System.Drawing.Point(146, 99);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(10, 13);
            this.lblColon.TabIndex = 10;
            this.lblColon.Text = ":";
            // 
            // AddGamesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(469, 191);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtBoxAwayTeam);
            this.Controls.Add(this.txtBoxHomeTeam);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.lblAwayTeam);
            this.Controls.Add(this.lblChampionship);
            this.Controls.Add(this.comboHomeTeam);
            this.Controls.Add(this.comboAwayTeam);
            this.Controls.Add(this.comboChampionship);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.monthCalendar);
            this.Name = "AddGamesView";
            this.Text = "Добавяне на мачове";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.ComboBox comboChampionship;
        private System.Windows.Forms.ComboBox comboHomeTeam;
        private System.Windows.Forms.ComboBox comboAwayTeam;
        private System.Windows.Forms.Label lblChampionship;
        private System.Windows.Forms.Label lblAwayTeam;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtBoxHomeTeam;
        private System.Windows.Forms.TextBox txtBoxAwayTeam;
        private System.Windows.Forms.Label lblColon;
    }
}