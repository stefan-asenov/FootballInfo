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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddGame = new System.Windows.Forms.TabPage();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lblChampionship = new System.Windows.Forms.Label();
            this.comboHomeTeam = new System.Windows.Forms.ComboBox();
            this.comboAwayTeam = new System.Windows.Forms.ComboBox();
            this.comboChampionship = new System.Windows.Forms.ComboBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UpdateResultBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.awayTeamScoreDropdown = new System.Windows.Forms.NumericUpDown();
            this.homeTeamScoreDropdown = new System.Windows.Forms.NumericUpDown();
            this.updateResultButton = new System.Windows.Forms.Button();
            this.lblAwayTeamName = new System.Windows.Forms.Label();
            this.lblHomeTeamName = new System.Windows.Forms.Label();
            this.pastGamesGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.leaguesCombo = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.AddGame.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.UpdateResultBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awayTeamScoreDropdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamScoreDropdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastGamesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddGame);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 314);
            this.tabControl1.TabIndex = 0;
            // 
            // AddGame
            // 
            this.AddGame.Controls.Add(this.dateTimePicker);
            this.AddGame.Controls.Add(this.lblHomeTeam);
            this.AddGame.Controls.Add(this.lblAwayTeam);
            this.AddGame.Controls.Add(this.lblChampionship);
            this.AddGame.Controls.Add(this.comboHomeTeam);
            this.AddGame.Controls.Add(this.comboAwayTeam);
            this.AddGame.Controls.Add(this.comboChampionship);
            this.AddGame.Controls.Add(this.btnAddGame);
            this.AddGame.Controls.Add(this.btnCancel);
            this.AddGame.Location = new System.Drawing.Point(4, 22);
            this.AddGame.Name = "AddGame";
            this.AddGame.Padding = new System.Windows.Forms.Padding(3);
            this.AddGame.Size = new System.Drawing.Size(629, 288);
            this.AddGame.TabIndex = 0;
            this.AddGame.Text = "Добавяне на мачове";
            this.AddGame.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(338, 29);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(241, 20);
            this.dateTimePicker.TabIndex = 20;
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Location = new System.Drawing.Point(17, 73);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(57, 13);
            this.lblHomeTeam.TabIndex = 19;
            this.lblHomeTeam.Text = "Домакин:";
            // 
            // lblAwayTeam
            // 
            this.lblAwayTeam.AutoSize = true;
            this.lblAwayTeam.Location = new System.Drawing.Point(17, 118);
            this.lblAwayTeam.Name = "lblAwayTeam";
            this.lblAwayTeam.Size = new System.Drawing.Size(33, 13);
            this.lblAwayTeam.TabIndex = 18;
            this.lblAwayTeam.Text = "Гост:";
            // 
            // lblChampionship
            // 
            this.lblChampionship.AutoSize = true;
            this.lblChampionship.Location = new System.Drawing.Point(17, 29);
            this.lblChampionship.Name = "lblChampionship";
            this.lblChampionship.Size = new System.Drawing.Size(72, 13);
            this.lblChampionship.TabIndex = 17;
            this.lblChampionship.Text = "Първенство:";
            // 
            // comboHomeTeam
            // 
            this.comboHomeTeam.FormattingEnabled = true;
            this.comboHomeTeam.Location = new System.Drawing.Point(102, 73);
            this.comboHomeTeam.Name = "comboHomeTeam";
            this.comboHomeTeam.Size = new System.Drawing.Size(121, 21);
            this.comboHomeTeam.TabIndex = 14;
            this.comboHomeTeam.SelectedIndexChanged += new System.EventHandler(this.HomeTeamComboChanged);
            // 
            // comboAwayTeam
            // 
            this.comboAwayTeam.FormattingEnabled = true;
            this.comboAwayTeam.Location = new System.Drawing.Point(102, 118);
            this.comboAwayTeam.Name = "comboAwayTeam";
            this.comboAwayTeam.Size = new System.Drawing.Size(121, 21);
            this.comboAwayTeam.TabIndex = 15;
            // 
            // comboChampionship
            // 
            this.comboChampionship.FormattingEnabled = true;
            this.comboChampionship.Location = new System.Drawing.Point(102, 29);
            this.comboChampionship.Name = "comboChampionship";
            this.comboChampionship.Size = new System.Drawing.Size(121, 21);
            this.comboChampionship.TabIndex = 16;
            this.comboChampionship.SelectedIndexChanged += new System.EventHandler(this.ChampionshipComboChanged);
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(406, 253);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(75, 23);
            this.btnAddGame.TabIndex = 13;
            this.btnAddGame.Text = "Добави";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(504, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Изход";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UpdateResultBox);
            this.tabPage2.Controls.Add(this.pastGamesGridView);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.leaguesCombo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(629, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Актуализиране на мачове";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UpdateResultBox
            // 
            this.UpdateResultBox.Controls.Add(this.panel1);
            this.UpdateResultBox.Location = new System.Drawing.Point(390, 47);
            this.UpdateResultBox.Name = "UpdateResultBox";
            this.UpdateResultBox.Size = new System.Drawing.Size(236, 224);
            this.UpdateResultBox.TabIndex = 29;
            this.UpdateResultBox.TabStop = false;
            this.UpdateResultBox.Text = "Актуализация";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.awayTeamScoreDropdown);
            this.panel1.Controls.Add(this.homeTeamScoreDropdown);
            this.panel1.Controls.Add(this.updateResultButton);
            this.panel1.Controls.Add(this.lblAwayTeamName);
            this.panel1.Controls.Add(this.lblHomeTeamName);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 174);
            this.panel1.TabIndex = 28;
            // 
            // awayTeamScoreDropdown
            // 
            this.awayTeamScoreDropdown.Location = new System.Drawing.Point(144, 64);
            this.awayTeamScoreDropdown.Name = "awayTeamScoreDropdown";
            this.awayTeamScoreDropdown.Size = new System.Drawing.Size(58, 20);
            this.awayTeamScoreDropdown.TabIndex = 29;
            // 
            // homeTeamScoreDropdown
            // 
            this.homeTeamScoreDropdown.Location = new System.Drawing.Point(144, 20);
            this.homeTeamScoreDropdown.Name = "homeTeamScoreDropdown";
            this.homeTeamScoreDropdown.Size = new System.Drawing.Size(58, 20);
            this.homeTeamScoreDropdown.TabIndex = 28;
            // 
            // updateResultButton
            // 
            this.updateResultButton.Location = new System.Drawing.Point(115, 127);
            this.updateResultButton.Name = "updateResultButton";
            this.updateResultButton.Size = new System.Drawing.Size(87, 23);
            this.updateResultButton.TabIndex = 27;
            this.updateResultButton.Text = "Актуализирай";
            this.updateResultButton.UseVisualStyleBackColor = true;
            this.updateResultButton.Click += new System.EventHandler(this.updateResultButton_Click);
            // 
            // lblAwayTeamName
            // 
            this.lblAwayTeamName.AutoSize = true;
            this.lblAwayTeamName.Location = new System.Drawing.Point(5, 64);
            this.lblAwayTeamName.Name = "lblAwayTeamName";
            this.lblAwayTeamName.Size = new System.Drawing.Size(35, 13);
            this.lblAwayTeamName.TabIndex = 24;
            this.lblAwayTeamName.Text = "label3";
            // 
            // lblHomeTeamName
            // 
            this.lblHomeTeamName.AutoSize = true;
            this.lblHomeTeamName.Location = new System.Drawing.Point(5, 20);
            this.lblHomeTeamName.Name = "lblHomeTeamName";
            this.lblHomeTeamName.Size = new System.Drawing.Size(35, 13);
            this.lblHomeTeamName.TabIndex = 23;
            this.lblHomeTeamName.Text = "label2";
            // 
            // pastGamesGridView
            // 
            this.pastGamesGridView.AllowUserToAddRows = false;
            this.pastGamesGridView.AllowUserToDeleteRows = false;
            this.pastGamesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastGamesGridView.Location = new System.Drawing.Point(6, 53);
            this.pastGamesGridView.Name = "pastGamesGridView";
            this.pastGamesGridView.ReadOnly = true;
            this.pastGamesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pastGamesGridView.Size = new System.Drawing.Size(377, 218);
            this.pastGamesGridView.TabIndex = 22;
            this.pastGamesGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.pastGamesGridView_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Първенство:";
            // 
            // leaguesCombo
            // 
            this.leaguesCombo.FormattingEnabled = true;
            this.leaguesCombo.Location = new System.Drawing.Point(93, 14);
            this.leaguesCombo.Name = "leaguesCombo";
            this.leaguesCombo.Size = new System.Drawing.Size(121, 21);
            this.leaguesCombo.TabIndex = 20;
            this.leaguesCombo.SelectedIndexChanged += new System.EventHandler(this.LeaguesComboChanged);
            // 
            // AddGamesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 345);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddGamesView";
            this.Text = "Добавяне и актуализиране на мачове";
            this.tabControl1.ResumeLayout(false);
            this.AddGame.ResumeLayout(false);
            this.AddGame.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.UpdateResultBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awayTeamScoreDropdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamScoreDropdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastGamesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddGame;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.Label lblAwayTeam;
        private System.Windows.Forms.Label lblChampionship;
        private System.Windows.Forms.ComboBox comboHomeTeam;
        private System.Windows.Forms.ComboBox comboAwayTeam;
        private System.Windows.Forms.ComboBox comboChampionship;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox leaguesCombo;
        private System.Windows.Forms.DataGridView pastGamesGridView;
        private System.Windows.Forms.GroupBox UpdateResultBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown awayTeamScoreDropdown;
        private System.Windows.Forms.NumericUpDown homeTeamScoreDropdown;
        private System.Windows.Forms.Button updateResultButton;
        private System.Windows.Forms.Label lblAwayTeamName;
        private System.Windows.Forms.Label lblHomeTeamName;

    }
}