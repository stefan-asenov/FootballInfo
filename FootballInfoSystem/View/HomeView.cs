using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballInfoSystem.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace FootballInfoSystem.View
{
    public partial class HomeView : Form
    {
        private User user;
        public HomeView(User user)
        {
            InitializeComponent();
	        HandleLogin(user);
            this.Show();
            UpdateFavoriteTeamsCombo();
        }

        private void addFavoriteTeamImage_Click(object sender, EventArgs e) {
            AddFavouriteTeamView favTeamView = new AddFavouriteTeamView();
            favTeamView.ShowDialog();
            UpdateFavoriteTeamsCombo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
            Program.loginFormView.Show();
        }

        private void HandleLogin(User user) {
            lblUsername.Text = "Здравей, " + user.firstName + " " + user.lastName;
            this.user = user;
        }

        private void UpdateFavoriteTeamsCombo()
        {
            favoriteTeamCombo.ValueMember = "id";
            favoriteTeamCombo.DisplayMember = "name";
            favoriteTeamCombo.DataSource = DBUtils.GetFavoriteTeams(user.Id);
        }

        private void UpdateLeagueInfo(int leagueId)
        {
            League league = DBUtils.GetLeague(leagueId);
            leagueCountryImage.ImageLocation = "Resources/" + league.country + ".png";
            leagueCountryImageStandingTab.ImageLocation = "Resources/" + league.country + ".png";
            leagueNameLabel.Text = league.name;
            leagueNameLabelStandingTab.Text = league.name;
        }

        private void UpdateStandingTable(int leagueId)
        {
            DataTable data = DBUtils.GetTeamsInLeague(leagueId);
            standingGridView.DataSource = DBUtils.GetTeamsInLeague(leagueId);
            if (data.Rows.Count != 0)
            {
                standingGridView.Columns["Id"].Visible = false;
                standingGridView.Columns["stadium"].Visible = false;
                standingGridView.Columns["manager"].Visible = false;
                standingGridView.Columns["founded"].Visible = false;
                standingGridView.Columns["League_id"].Visible = false;

                standingGridView.Columns["name"].HeaderText = "Име";
                standingGridView.Columns["points"].HeaderText = "Точки";
                standingGridView.Columns["wins"].HeaderText = "Победи";
                standingGridView.Columns["losts"].HeaderText = "Загуби";
                standingGridView.Columns["draws"].HeaderText = "Равенства";
            }
        }

        private void UpdateProgramTable(int teamId)
        {
            DataTable data = DBUtils.GetMatches(teamId);
            programGridView.DataSource = DBUtils.GetMatches(teamId);
            if (data.Rows.Count != 0)
            {
                programGridView.Columns["matchDate"].HeaderText = "Дата";
                programGridView.Columns["name"].HeaderText = "Домакин";
                programGridView.Columns["result"].HeaderText = "Резултат";
                programGridView.Columns["name1"].HeaderText = "Гост";
            }
        }

        private void UpdateFootballersTable(int teamId)
        {
            DataTable data = DBUtils.GetFootballers(teamId); ;
            footballersGridView.DataSource = data;
            if (data.Rows.Count != 0)
            {
                footballersGridView.Columns["Id"].Visible = false;
                footballersGridView.Columns["age"].Visible = false;
                footballersGridView.Columns["nationality"].Visible = false;
                footballersGridView.Columns["datеOfBirth"].Visible = false;
                footballersGridView.Columns["height"].Visible = false;
                footballersGridView.Columns["weight"].Visible = false;
                footballersGridView.Columns["Team_id"].Visible = false;

                footballersGridView.Columns["name"].HeaderText = "Име";
                footballersGridView.Columns["position"].HeaderText = "Позиция";
                footballersGridView.Columns["number"].HeaderText = "Номер";
            }
        }

        private void UpdateStatisticsChart(int teamId)
        {
            Team team = DBUtils.GetTeam(teamId);

            double[] yValues = { team.wins, team.draws, team.losts};
            string[] xValues = { "Победи: " + team.wins, "Равенства: " + team.draws, "Загуби: " + team.losts};
            statisticsChart.Series["Default"].Points.DataBindXY(xValues, yValues);

            statisticsChart.Series["Default"].Points[0].Color = Color.GreenYellow;
            statisticsChart.Series["Default"].Points[1].Color = Color.Orange;
            statisticsChart.Series["Default"].Points[2].Color = Color.Tomato;
            statisticsChart.Series["Default"].ChartType = SeriesChartType.Pie;

            statisticsChart.Series["Default"]["PieLabelStyle"] = "Disabled";
            statisticsChart.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            statisticsChart.Legends[0].Enabled = true;
        }

        private void UpdatePredictedGames(int teamId) {

        }

        private void favoriteTeamChanged(object sender, EventArgs e)
        {
            if (favoriteTeamCombo.SelectedItem is DataRowView)
            {
                int leagueId = int.Parse(((DataRowView)favoriteTeamCombo.SelectedItem).Row["League_id"].ToString());
                UpdateStandingTable(leagueId);
                UpdateLeagueInfo(leagueId);
                UpdateProgramTable((int)favoriteTeamCombo.SelectedValue);
                UpdateFootballersTable((int)favoriteTeamCombo.SelectedValue);
                UpdateStatisticsChart((int)favoriteTeamCombo.SelectedValue);
                UpdatePredictedGames((int) favoriteTeamCombo.SelectedValue);
            }
        }

        private void standingGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void standingGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = standingGridView.Rows[e.RowIndex];
            int teamId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            TeamView teamView = new TeamView(teamId);
            teamView.Show();
        }

        private void footballersGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = footballersGridView.Rows[e.RowIndex];
            int footballerId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            FootballerView footballerView = new FootballerView(footballerId);
            footballerView.Show();
        }

        private void HomeView_FormClosing(object sender, FormClosingEventArgs e) {
            Program.ExitApplication(1);
        }
    }
}
