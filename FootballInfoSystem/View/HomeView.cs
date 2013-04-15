using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FootballInfoSystem.View
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void addFavoriteTeamImage_Click(object sender, EventArgs e) {
            SelectFavouriteTeamView favTeamView = new SelectFavouriteTeamView();
            favTeamView.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
