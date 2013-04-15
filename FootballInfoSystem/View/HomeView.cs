using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FootballInfoSystem.View
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
            favoriteTeamCombo.DataSource = GetFavoriteTeams(2);
        }

        private void addFavoriteTeamImage_Click(object sender, EventArgs e) {
            SelectFavouriteTeamView favTeamView = new SelectFavouriteTeamView();
            favTeamView.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.ExitApplication(1);
        }

        public static List<string> GetFavoriteTeams(int userId)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FootballSystemDatabase;Integrated Security=True");
            List<string> result = new List<string>();
            try
            {
                conn.Open();
                string commandText = "select * from Teams where id in (select Teams_id from UserTeam where Users_id = @userId)";
                SqlCommand cmd = new SqlCommand(commandText, conn);
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString(1));
                }
            }
            catch (Exception)
            {
                return new List<string>();
            }
            return result;
        }
    }
}
