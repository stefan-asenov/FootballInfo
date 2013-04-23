using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballInfoSystem.Logic {
    class RegistrationValidation {
        public static List<String> ErrorMessages = new List<string>();

        public static List<string> validateRegistration(string username, string password, string repeatPassword) {
            List<string> errorMessages = new List<string>();
            errorMessages.AddRange(ValidationUtil.CheckLength(password, "'парола'"));
            errorMessages.AddRange(ValidationUtil.CheckLength(repeatPassword, "'повтори парола'"));
            errorMessages.AddRange(ValidationUtil.IsEmpty(password, "'парола'"));
            errorMessages.AddRange(ValidationUtil.IsEmpty(repeatPassword, "'повтори парола'"));
            errorMessages.AddRange(ValidationUtil.IsEmpty(username, "'потребителско име'"));
            if (!repeatPassword.Equals(password)) {
                errorMessages.Add("Паролите не съвпадат!");
            }
            return errorMessages;
        }
    }
}
