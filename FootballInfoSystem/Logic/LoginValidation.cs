using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballInfoSystem.Logic {
    class LoginValidation {
        public int MIN_PASSWORD_LENGTH { get; private set; }
        
        private string username;
        private string password;
        public string ErrorText { get; private set; }

        public LoginValidation(string username, string password) {
            this.username = username;
            this.password = password;
            ErrorText = string.Empty;
            MIN_PASSWORD_LENGTH = 6;
        }

        public bool ValidateUserInput(out User user) {
            CheckLength(password, "password", MIN_PASSWORD_LENGTH);
            IsEmpty(password, "password");
            IsEmpty(username, "username");
            if (!ErrorText.Equals(string.Empty)) {
                user = null;
                return false;

            }
            /*User queryResult = UserData.IsUserPassCorrect(username, password);
            if (queryResult == null) {
                user = null;
                ErrorText = "Въвели сте грешно потребителско име или парола!";
                return false;
            }*/
            user = new User();
            user.firstName = "Stefan";
            return true;
        }

        private void IsEmpty(string text, string name) {
            if (text.Length == 0) {
                ErrorText = "The " + name + " cannot be empty!";
            }
        }

        private void CheckLength(string text, string fieldName, int length) {
            if (text.Length < length) {
                ErrorText = "The " + fieldName + " is too short!";
            }
        }
    }
}
