using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FootballInfoSystem.Data {
    class UserData {
        public static User IsUserPassCorrect(string username, string password) {
            User user = null;
            using (SqlConnection dbConnection = new SqlConnection(DBUtils.getDbConnectionString())) {
                dbConnection.Open();
                string commandText = "select * from Users where userName = @username and password = @password";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@password", password));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    reader.Read();
                    user = new User();
                    user.Id = reader.GetInt32(0);
                    user.firstName = reader.GetString(3);
                    user.lastName = reader.GetString(4);
                    user.role = reader.GetInt32(5);
                }
            }
            return user;
        }

        public static List<string> GetExistingUsernames() {
            List<string> usernames = new List<string>();
            using (SqlConnection dbConnection = new SqlConnection(DBUtils.getDbConnectionString())) {
                dbConnection.Open();
                string commandText = "select userName from Users";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    usernames.Add(reader.GetString(0));
                }
            }
            return usernames;
        }

        public static void addUserToDatabase(string firstName, string lastName, string username, string password, string email) {
            using (SqlConnection dbConnection = new SqlConnection(DBUtils.getDbConnectionString())) {
                dbConnection.Open();
                string commandText = "INSERT INTO Users (userName, password, firstName, lastName, email, role) " +
                    "VALUES (@username, @password, @firstName, @lastName, @email, 2)";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@password", password));
                cmd.Parameters.Add(new SqlParameter("@firstName", firstName));
                cmd.Parameters.Add(new SqlParameter("@lastName", lastName));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                try {
                    int result = cmd.ExecuteNonQuery();
                    if (result != 1) {
                        MessageBox.Show("Грешка при добавяне на потребител!");
                    }
                } catch (SqlException ex) {
                    MessageBox.Show("Грешка при добавяне на потребител!");
                }
            }
        }
    }
}
