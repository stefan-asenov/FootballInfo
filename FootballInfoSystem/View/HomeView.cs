using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballInfoSystem.Data;

namespace FootballInfoSystem.View
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
	        HandleLogin();
            int userID = 1;
            favoriteTeamCombo.ValueMember = "id";
            favoriteTeamCombo.DisplayMember = "name";
            favoriteTeamCombo.DataSource = DBUtils.GetFavoriteTeams(userID);
        }

        private void addFavoriteTeamImage_Click(object sender, EventArgs e) {
            AddFavouriteTeamView favTeamView = new AddFavouriteTeamView();
            favTeamView.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            HandleLogin();
        }

        private void HandleLogin() {
            LoginFormView loginForm = new LoginFormView();
            DialogResult loginResult = loginForm.ShowDialog();
            while (loginResult != DialogResult.OK) {}
            lblUsername.Text = loginForm.user.firstName;
            this.Show();
        }
        private void UpdateStandingTable(int leagueId)
        {
            standingGridView.DataSource = DBUtils.GetTeamsInLeague(leagueId);
            standingGridView.Columns["Id"].Visible = false;
            standingGridView.Columns["stadium"].Visible = false;
            standingGridView.Columns["manager"].Visible = false;
            standingGridView.Columns["founded"].Visible = false;
            standingGridView.Columns["League_id"].Visible = false;
        }

        private void UpdateLeagueInfo(int leagueId)
        {
            League league = DBUtils.GetLeague(leagueId);
            leagueCountryImage.ImageLocation = "Resources/" + league.country + ".png";
            leagueNameLabel.Text = league.name;
        }

        private void favoriteTeamChanged(object sender, EventArgs e)
        {
            if (favoriteTeamCombo.SelectedItem is DataRowView)
            {
                int leagueId = int.Parse(((DataRowView)favoriteTeamCombo.SelectedItem).Row["League_id"].ToString());
                UpdateStandingTable(leagueId);
                UpdateLeagueInfo(leagueId);
            }
        }
    }
}
