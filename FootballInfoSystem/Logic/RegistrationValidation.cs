using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballInfoSystem.Data;

namespace FootballInfoSystem.Logic {
    class RegistrationValidation {
        public static List<String> ErrorMessages = new List<string>();

        public static List<string> validateRegistration(string firstName, string lastName, string username, string password, string repeatPassword) {
            List<string> errorMessages = new List<string>();
            errorMessages.AddRange(ValidationUtil.IsEmpty(firstName, "'име'"));
            errorMessages.AddRange(ValidationUtil.IsEmpty(lastName, "'фамилия'"));
            errorMessages.AddRange(ValidationUtil.CheckLength(password, "'парола'"));
            errorMessages.AddRange(ValidationUtil.CheckLength(repeatPassword, "'повтори парола'"));
            errorMessages.AddRange(ValidationUtil.IsEmpty(password, "'парола'"));
            errorMessages.AddRange(ValidationUtil.IsEmpty(repeatPassword, "'повтори парола'"));
            errorMessages.AddRange(ValidationUtil.IsEmpty(username, "'потребителско име'"));
            if (!repeatPassword.Equals(password)) {
                errorMessages.Add("Паролите не съвпадат!");
            }
            if (errorMessages.Count == 0) {
                UserData.addUserToDatabase(firstName, lastName, username, password);
            }
            return errorMessages;
        }
    }
}
