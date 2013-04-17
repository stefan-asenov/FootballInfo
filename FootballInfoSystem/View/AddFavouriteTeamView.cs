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
    public partial class AddFavouriteTeamView : Form {
        public AddFavouriteTeamView() {
            InitializeComponent();
            comboLeagues.ValueMember = "id";
            comboLeagues.DisplayMember = "name";
            comboLeagues.DataSource = DBUtils.GetLeagues();  
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            //TODO get user ID://
            int userID = 1;
            try 
            {
                bool isAdded = DBUtils.АddFavoriteTeam(userID, (int)comboTeams.SelectedValue);
                if (isAdded)
                {
                    MessageBox.Show("Успешо добавихте любим отбор.");
                    return;
                }
                MessageBox.Show("Не успяхте да добавите любим отбор. Опитайте отново.");
            }
            catch (Exception)
            {
                MessageBox.Show("Не може да добавяте любим отбор, ако не сте избрали такъв.");
            }
        }

        private void leaguesComboChanged(object sender, EventArgs e)
        {
            try
            {
                comboTeams.ValueMember = "id";
                comboTeams.DisplayMember = "name";
                comboTeams.DataSource = DBUtils.GetTeamsInLeague((int)comboLeagues.SelectedValue);
            }
            catch (Exception)
            {
                MessageBox.Show("Няма същесвуващи първенства");
            }
        }
    }
}
