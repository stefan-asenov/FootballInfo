using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballInfoSystem.Logic {
    class ValidationUtil {
        public static int MIN_PASSWORD_LENGTH = 6;

        public static List<string> IsEmpty(string text, string filedName) {
            List<string> errorMessages = new List<string>();
            if (text.Length == 0) {
                string errorText = "Полето " + filedName + " не може да бъде празно!";
                errorMessages.Add(errorText);
            }
            return errorMessages;
        }

        public static List<string> CheckLength(string text, string fieldName) {
            return CheckLength(text, fieldName, MIN_PASSWORD_LENGTH);
        }

        public static List<string> CheckLength(string text, string fieldName, int length) {
            List<string> errorMessages = new List<string>();
            if (text.Length < length) {
                string errorText = "Дължината на полето " + fieldName + " трябва да е минимум " + length + " символа!";
                errorMessages.Add(errorText);
            }
            return errorMessages;
        }
    }
}
