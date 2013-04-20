using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FootballInfoSystem.Data;

namespace FootballInfoSystem.View {
    public partial class FootballerView : Form {
        public FootballerView(int footballerId)
        {
            InitializeComponent();
            UpdateFootballerInfo(footballerId);
        }

        private void UpdateFootballerInfo(int footballerId)
        {
            Footballer footballer = DBUtils.GetFootballer(footballerId);
            lblName.Text = footballer.name;
            lblDataBorn.Text = footballer.datеOfBirth.ToShortDateString();
            lblDataCountry.Text = footballer.nationality;
            lblDataHeight.Text = footballer.height.ToString();
            lblDataWeight.Text = footballer.weight.ToString();
            lblDataNumber.Text = footballer.number.ToString();
            lblDataPosition.Text = footballer.position;
        }
    }
}
