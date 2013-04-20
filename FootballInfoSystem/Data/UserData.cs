using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FootballInfoSystem.Data {
    class UserData {



        public static User IsUserPassCorrect(string username, string password) {
            SqlConnection dbConnection = null;
            User user = null;
            try {
                dbConnection = new SqlConnection(DBUtils.getDbConnectionString());
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
                }
            } finally {
                if (dbConnection != null) {
                    dbConnection.Close();
                }
            }
            return user;
        }
    }
}
