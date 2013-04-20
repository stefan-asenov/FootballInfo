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

namespace FootballInfoSystem.View {
    public partial class TeamView : Form {
        public TeamView(int teamId) {
            InitializeComponent();
            UpdateTeamInfo(teamId);
        }

        private void UpdateTeamInfo(int teamId)
        {
            //Updating teamInfo
            Team team = DBUtils.GetTeam(teamId);
            lblTeamName.Text = team.name;
            lblCoachData.Text = team.manager;
            lblStadiumData.Text = team.stadium;
            lblFoundedData.Text = team.founded.ToShortDateString();

            //Updating team logo
            pictureTeamLogo.ImageLocation = "Resources/" + team.name + ".png";

            //Updating statistics
            if (statisticsChart.Titles.Count > 0)
            {
                statisticsChart.Titles.RemoveAt(0);
            }
            statisticsChart.Titles.Add("Статистика за " + team.name);
            double[] yValues = { team.wins, team.draws, team.losts };
            string[] xValues = { "Победи: " + team.wins, "Равенства: " + team.draws, "Загуби: " + team.losts };
            statisticsChart.Series["Default"].Points.DataBindXY(xValues, yValues);

            statisticsChart.Series["Default"].Points[0].Color = Color.GreenYellow;
            statisticsChart.Series["Default"].Points[1].Color = Color.Orange;
            statisticsChart.Series["Default"].Points[2].Color = Color.Tomato;
            statisticsChart.Series["Default"].ChartType = SeriesChartType.Pie;

            statisticsChart.Series["Default"]["PieLabelStyle"] = "Disabled";
            statisticsChart.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            statisticsChart.Legends[0].Enabled = true;
        }
    }
}
