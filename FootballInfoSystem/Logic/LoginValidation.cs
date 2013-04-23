using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballInfoSystem.Data;

namespace FootballInfoSystem.Logic {
    class LoginValidation {
        private string username;
        private string password;

        public LoginValidation(string username, string password) {
            this.username = username;
            this.password = password;
        }

        public List<string> ValidateUserInput(out User user) {
            List<string> errorMessages = new List<string>();
            errorMessages.AddRange(ValidationUtil.CheckLength(password, "'парола'"));
            errorMessages.AddRange(ValidationUtil.IsEmpty(password, "'парола'"));
            errorMessages.AddRange(ValidationUtil.IsEmpty(username, "'потребителско име'"));
            User queryResult = UserData.IsUserPassCorrect(username, password);
            if (queryResult == null) {
                user = null;
                errorMessages.Add("Въвели сте грешно потребителско име или парола!");
            } else {
                user = queryResult;
            }
            return errorMessages;
        }
    }
}
