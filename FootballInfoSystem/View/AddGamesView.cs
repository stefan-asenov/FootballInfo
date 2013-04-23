using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballInfoSystem.Data;

namespace FootballInfoSystem.View {
    public partial class AddGamesView : Form {
        public AddGamesView() {
            InitializeComponent();
            
            // Setting datetime format for dateTime picker
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "ddddd, MMMM dd, yyyy HH:mm";

            //Adding information for leagues
            DataTable leagues = DBUtils.GetLeagues();

            comboChampionship.ValueMember = "id";
            comboChampionship.DisplayMember = "name";
            comboChampionship.DataSource = leagues;

            leaguesCombo.ValueMember = "id";
            leaguesCombo.DisplayMember = "name";
            leaguesCombo.DataSource = leagues;
            
        }

        private void ChampionshipComboChanged(object sender, EventArgs e)
        {
            try
            {
                comboHomeTeam.ValueMember = "id";
                comboHomeTeam.DisplayMember = "name";
                comboHomeTeam.DataSource = DBUtils.GetTeamsInLeague((int)comboChampionship.SelectedValue);
            }
            catch (Exception)
            {
                MessageBox.Show("Няма същесвуващи първенства");
            }
        }

        private void LeaguesComboChanged(object sender, EventArgs e)
        {
            UpdatePastMatchesTable();
        }

        private void UpdatePastMatchesTable()
        {
            DataTable data = DBUtils.GetPastMatchesWithoutResult((int)leaguesCombo.SelectedValue);
            pastGamesGridView.DataSource = data;
            if (data.Rows.Count != 0) {
                EnableMatchUpdate(true);
                pastGamesGridView.Columns["Id"].Visible = false;
                pastGamesGridView.Columns["matchDate"].HeaderText = "Дата";
                pastGamesGridView.Columns["name"].HeaderText = "Домакин";
                pastGamesGridView.Columns["name1"].HeaderText = "Гост";
            } else {
                EnableMatchUpdate(false);
            }
            UpdateSetResultInfo(0);
        }

        private void EnableMatchUpdate(bool enabled) {
            homeTeamScoreDropdown.Enabled = enabled;
            awayTeamScoreDropdown.Enabled = enabled;
            updateResultButton.Enabled = enabled;
        }

        private void HomeTeamComboChanged(object sender, EventArgs e)
        {
            try
            {
                comboAwayTeam.ValueMember = "id";
                comboAwayTeam.DisplayMember = "name";
                comboAwayTeam.DataSource = DBUtils.GetTeamsInLeagueWithoutSpecificTeam((int)comboChampionship.SelectedValue, (int)comboHomeTeam.SelectedValue);
            }
            catch (Exception)
            {
                MessageBox.Show("Няма същесвуващи първенства");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            string homeTeamName = ((DataRowView)comboHomeTeam.SelectedItem).Row[comboHomeTeam.DisplayMember].ToString();
            string awayTeamName = ((DataRowView)comboAwayTeam.SelectedItem).Row[comboAwayTeam.DisplayMember].ToString();
            string message = "Наистина ли искате да създадете срещата " + homeTeamName + " : " + awayTeamName + " на " + dateTimePicker.Value + "?";
            string caption = "Създаване на футболна среща";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int homeTeamId = (int)comboHomeTeam.SelectedValue;
                int awayTeamId = (int)comboAwayTeam.SelectedValue;
                DateTime matchDate = dateTimePicker.Value;
                bool isCreated = DBUtils.АddGame(homeTeamId, awayTeamId, matchDate);
                if (isCreated)
                {
                    MessageBox.Show("Успешно създадохте срещата.");
                    return;
                }
                MessageBox.Show("Не успяхте да създадете срещата. Опитайте отново!");
            }
        }

        private void pastGamesGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateSetResultInfo(e.RowIndex);
        }

        private void UpdateSetResultInfo(int rowIndex)
        {
            string homeTeamName = "";
            string awayTeamName = "";
            if (pastGamesGridView.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = pastGamesGridView.Rows[rowIndex];
                homeTeamName = Convert.ToString(selectedRow.Cells["name"].Value) + " scored: ";
                awayTeamName = Convert.ToString(selectedRow.Cells["name1"].Value) + " scored: ";
            }
            lblHomeTeamName.Text = homeTeamName;
            lblAwayTeamName.Text = awayTeamName;
        }

        private void updateResultButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = pastGamesGridView.Rows[pastGamesGridView.SelectedRows[0].Index];

            string homeTeamName = Convert.ToString(selectedRow.Cells["name"].Value);
            int homeTeamScore = Convert.ToInt32(homeTeamScoreDropdown.Value);
            string awayTeamName = Convert.ToString(selectedRow.Cells["name1"].Value);
            int awayTeamScore = Convert.ToInt32(awayTeamScoreDropdown.Value);
            int gameId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            
            string message = "Наистина ли искате да въведете резултатът '" + homeTeamScore + " : " + awayTeamScore + "' за срещата " + homeTeamName + " : " + awayTeamName + "?";
            string caption = "Въвеждане на резултат";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (pastGamesGridView.SelectedRows.Count == 1)
                {

                    bool isGameUpdated = DBUtils.UpdateGameResult(gameId, homeTeamScore, awayTeamScore);
                    bool isStandingUpdated = updateStanding(homeTeamName, homeTeamScore,awayTeamName, awayTeamScore);
                    if (isGameUpdated && isStandingUpdated)
                    {
                        UpdatePastMatchesTable();
                        homeTeamScoreDropdown.Value = 0;
                        awayTeamScoreDropdown.Value = 0;
                        MessageBox.Show("Успешно въведохте резултат за срещата.");
                        return;
                    }
                    MessageBox.Show("Не успяхте въведете резултат за срещата. Опитайте отново!");
                }
            }
        }

        private bool updateStanding(string homeTeamName, int homeTeamScore, string awayTeamName, int awayTeamScore) {
            int homeTeamPoints = homeTeamScore > awayTeamScore ? 3 : homeTeamScore == awayTeamScore ? 1 : 0;
            int awayTeamPoints = awayTeamScore > homeTeamScore ? 3 : homeTeamScore == awayTeamScore ? 1 : 0;
            return DBUtils.UpdateStanding(homeTeamName, homeTeamPoints) && DBUtils.UpdateStanding(awayTeamName, awayTeamPoints);
        }

        private void btnCancel_Click_1(object sender, EventArgs e) {
            this.Close();
        }
    }
}
