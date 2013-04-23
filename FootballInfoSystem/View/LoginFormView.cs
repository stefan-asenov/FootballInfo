using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballInfoSystem.Logic;

namespace FootballInfoSystem.View {
    public partial class LoginFormView : Form {
        public User user { get; private set; }

        public LoginFormView() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            user = null;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            LoginValidation login = new LoginValidation(txtBoxUsername.Text, txtBoxPassword.Text);
            User user;
            List<string> loginMessages = login.ValidateUserInput(out user);
            if (loginMessages.Count == 0) {
                this.user = user;
                this.DialogResult = DialogResult.OK;
                this.Hide();
                HomeView homeView = new HomeView(user);
            } else {
                ErrorListView errors = new ErrorListView(loginMessages);
                errors.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void LoginFormView_Activated(object sender, EventArgs e) {
            this.txtBoxUsername.Text = "";
            this.txtBoxPassword.Text = "";
        }

        private void linkLblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            RegistrationView registrationView = new RegistrationView();
            registrationView.ShowDialog();
        }
    }
}
