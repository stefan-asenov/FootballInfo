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
            favoriteTeamCombo.DataSource = DBUtils.GetFavoriteTeams(2);
        }

        private void addFavoriteTeamImage_Click(object sender, EventArgs e) {
            AddFavouriteTeamView favTeamView = new AddFavouriteTeamView();
            favTeamView.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            LoginFormView loginForm = new LoginFormView();
            loginForm.ShowDialog();
        }

        private void HandleLogin() {
            LoginFormView loginForm = new LoginFormView();
            DialogResult loginResult = loginForm.ShowDialog();
            while (loginResult != DialogResult.OK) {}
            lblUsername.Text = loginForm.user.firstName;
        }
    }
}
