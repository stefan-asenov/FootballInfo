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
        private int userId;
        public AddFavouriteTeamView(int userId) {
            InitializeComponent();
            this.userId = userId;
            comboLeagues.DataSource = DBUtils.GetLeagues(); 
            comboLeagues.ValueMember = "Id";
            comboLeagues.DisplayMember = "name";
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            string teamName = ((DataRowView)comboTeams.SelectedItem).Row[comboTeams.DisplayMember].ToString();
            string message = "Наистина ли искате да добавите " + teamName + " в любими отбори?";
            string caption = "Любими отбори";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool isAdded = DBUtils.АddFavoriteTeam(userId, (int)comboTeams.SelectedValue);
                    if (isAdded)
                    {
                        MessageBox.Show("Успешо добавихте "+ teamName + " в любими отбор.");
                        return;
                    }
                    MessageBox.Show(teamName + " вече е добавен в любими.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Не може да добавяте любим отбор, ако не сте избрали такъв.");
                }
            }
        }

        private void leaguesComboChanged(object sender, EventArgs e)
        {
            try
            {
                comboTeams.DataSource = DBUtils.GetTeamsInLeague((int)comboLeagues.SelectedValue);
                comboTeams.ValueMember = "Id";
                comboTeams.DisplayMember = "name";
            }
            catch (Exception)
            {
                MessageBox.Show("Няма същесвуващи първенства");
            }
        }
    }
}
