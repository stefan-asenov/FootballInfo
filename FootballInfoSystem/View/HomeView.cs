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
            favoriteTeamCombo.DataSource = DBUtils.GetFavoriteTeams(2);
        }

        private void addFavoriteTeamImage_Click(object sender, EventArgs e) {
            AddFavouriteTeamView favTeamView = new AddFavouriteTeamView();
            favTeamView.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.ExitApplication(1);
        }

        
    }
}
