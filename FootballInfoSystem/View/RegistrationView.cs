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
    public partial class RegistrationView : Form {
        public RegistrationView() {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            List<string> registrationMessages = RegistrationValidation.validateRegistration(txtBoxFirstName.Text, txtBoxLastName.Text,
                txtBoxUsername.Text, txtBoxPassword.Text, txtBoxRepeatPassword.Text, txtBoxEmail.Text);
            if (registrationMessages.Count == 0) {
                MessageBox.Show("Регистрирахте се успешно!");
                this.Close();
            } else {
                ErrorListView errors = new ErrorListView(registrationMessages);
                errors.ShowDialog();
            }
        }
    }
}
