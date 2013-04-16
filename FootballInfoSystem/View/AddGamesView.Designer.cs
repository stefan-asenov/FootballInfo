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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.addGameButton = new System.Windows.Forms.Button();
            this.championshipCombo = new System.Windows.Forms.ComboBox();
            this.homeTeamCombo = new System.Windows.Forms.ComboBox();
            this.awayTeamCombo = new System.Windows.Forms.ComboBox();
            this.championshipLabel = new System.Windows.Forms.Label();
            this.awayTeamLabel = new System.Windows.Forms.Label();
            this.homeTeamLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(223, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
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
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(55, 151);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(75, 23);
            this.addGameButton.TabIndex = 2;
            this.addGameButton.Text = "Добави";
            this.addGameButton.UseVisualStyleBackColor = true;
            // 
            // championshipCombo
            // 
            this.championshipCombo.FormattingEnabled = true;
            this.championshipCombo.Location = new System.Drawing.Point(90, 12);
            this.championshipCombo.Name = "championshipCombo";
            this.championshipCombo.Size = new System.Drawing.Size(121, 21);
            this.championshipCombo.TabIndex = 3;
            // 
            // homeTeamCombo
            // 
            this.homeTeamCombo.FormattingEnabled = true;
            this.homeTeamCombo.Location = new System.Drawing.Point(90, 42);
            this.homeTeamCombo.Name = "homeTeamCombo";
            this.homeTeamCombo.Size = new System.Drawing.Size(121, 21);
            this.homeTeamCombo.TabIndex = 3;
            // 
            // awayTeamCombo
            // 
            this.awayTeamCombo.FormattingEnabled = true;
            this.awayTeamCombo.Location = new System.Drawing.Point(90, 72);
            this.awayTeamCombo.Name = "awayTeamCombo";
            this.awayTeamCombo.Size = new System.Drawing.Size(121, 21);
            this.awayTeamCombo.TabIndex = 3;
            // 
            // championshipLabel
            // 
            this.championshipLabel.AutoSize = true;
            this.championshipLabel.Location = new System.Drawing.Point(12, 12);
            this.championshipLabel.Name = "championshipLabel";
            this.championshipLabel.Size = new System.Drawing.Size(72, 13);
            this.championshipLabel.TabIndex = 4;
            this.championshipLabel.Text = "Първенство:";
            // 
            // awayTeamLabel
            // 
            this.awayTeamLabel.AutoSize = true;
            this.awayTeamLabel.Location = new System.Drawing.Point(12, 72);
            this.awayTeamLabel.Name = "awayTeamLabel";
            this.awayTeamLabel.Size = new System.Drawing.Size(33, 13);
            this.awayTeamLabel.TabIndex = 5;
            this.awayTeamLabel.Text = "Гост:";
            // 
            // homeTeamLabel
            // 
            this.homeTeamLabel.AutoSize = true;
            this.homeTeamLabel.Location = new System.Drawing.Point(12, 42);
            this.homeTeamLabel.Name = "homeTeamLabel";
            this.homeTeamLabel.Size = new System.Drawing.Size(57, 13);
            this.homeTeamLabel.TabIndex = 6;
            this.homeTeamLabel.Text = "Домакин:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 99);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(56, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Резултат:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = ":";
            // 
            // AddGamesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(469, 191);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.homeTeamLabel);
            this.Controls.Add(this.awayTeamLabel);
            this.Controls.Add(this.championshipLabel);
            this.Controls.Add(this.homeTeamCombo);
            this.Controls.Add(this.awayTeamCombo);
            this.Controls.Add(this.championshipCombo);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "AddGamesView";
            this.Text = "Добавяне на мачове";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.ComboBox championshipCombo;
        private System.Windows.Forms.ComboBox homeTeamCombo;
        private System.Windows.Forms.ComboBox awayTeamCombo;
        private System.Windows.Forms.Label championshipLabel;
        private System.Windows.Forms.Label awayTeamLabel;
        private System.Windows.Forms.Label homeTeamLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}