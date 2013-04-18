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
            if (login.ValidateUserInput(out user)) {
                this.user = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else {
                MessageBox.Show(login.ErrorText);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Program.ExitApplication(1);
        }
    }
}
