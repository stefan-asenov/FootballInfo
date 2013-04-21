using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FootballInfoSystem.Data
{
    class DBUtils
    {
        private const string DB_CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=FootballSystemDatabase;Integrated Security=True";

        private DBUtils() {}

        public static string getDbConnectionString() {
            return DB_CONNECTION_STRING;
        }

        public static DataTable GetFavoriteTeams(int userId)
        {
            SqlConnection dbConnection = null;
            DataTable dataTable = new DataTable();
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select * from Teams where id in (select Teams_id from UserTeam where Users_id = @userId)";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return dataTable;
        }

        public static Team GetTeam(int teamId)
        {
            Team team = new Team();
            SqlConnection dbConnection = null;
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select * from Teams where id = @teamId";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@teamId", teamId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    team.Id = reader.GetInt32(0);
                    team.name = reader.GetString(1);
                    team.stadium = reader.GetString(2);
                    team.manager = reader.GetString(3);
                    team.founded = reader.GetDateTime(4);
                    team.points = reader.GetInt16(5);
                    team.wins = reader.GetInt16(6);
                    team.losts = reader.GetInt16(7);
                    team.draws = reader.GetInt16(8);
                    team.League = new League();
                    team.League.Id = reader.GetInt32(9);
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return team;
        }

        public static DataTable GetLeagues()
        {
            SqlConnection dbConnection = null;
            DataTable dataTable = new DataTable();
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select * from Leagues";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return dataTable;
        }

        public static DataTable GetTeamsInLeague(int leagueId)
        {
            SqlConnection dbConnection = null;
            DataTable dataTable = new DataTable();
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select * from Teams where League_id = @leagueId order by points desc";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@leagueId", leagueId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return dataTable;
        }

        public static DataTable GetTeamsInLeagueWithoutSpecificTeam(int leagueId, int excludedTeamId)
        {
            SqlConnection dbConnection = null;
            DataTable dataTable = new DataTable();
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select * from Teams where League_id = @leagueId and id != @excludedTeamId order by points desc";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@leagueId", leagueId));
                cmd.Parameters.Add(new SqlParameter("@excludedTeamId", excludedTeamId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return dataTable;
        }

        public static League GetLeague(int leagueId)
        {
            League league = new League();
            SqlConnection dbConnection = null;
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select * from Leagues where id = @leagueId";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@leagueId", leagueId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    league.Id = reader.GetInt32(0);
                    league.name = reader.GetString(1);
                    league.country = reader.GetString(2);
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return league;
        }

        public static DataTable GetMatches(int teamId)
        {
            SqlConnection dbConnection = null;
            DataTable dataTable = new DataTable();
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select game.matchDate, homeTeam.name, game.result, awayTeam.name from Games as game, Teams as homeTeam, Teams as awayTeam where awayTeam.Id = game.awayTeam_Id and homeTeam.Id = game.homeTeam_Id and (game.awayTeam_Id=@teamId or game.homeTeam_Id=@teamId) order by game.matchDate";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@teamId", teamId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return dataTable;
        }

        public static DataTable GetPastMatchesWithoutResult(int leagueId)
        {
            SqlConnection dbConnection = null;
            DataTable dataTable = new DataTable();
            DateTime matchEndDateTime = DateTime.Now;
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select game.Id, game.matchDate, homeTeam.name, awayTeam.name from Games as game, Teams as homeTeam, Teams as awayTeam where awayTeam.Id = game.awayTeam_Id and homeTeam.Id = game.homeTeam_Id and game.matchDate < @matchEndDateTime and game.result is null and (homeTeam.League_Id=@leagueId and awayTeam.League_Id=@leagueId) order by game.matchDate";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@leagueId", leagueId));
                cmd.Parameters.Add(new SqlParameter("@matchEndDateTime", matchEndDateTime));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return dataTable;
        }


        public static Footballer GetFootballer(int footballerId)
        {
            Footballer footballer = new Footballer();
            SqlConnection dbConnection = null;
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select * from Footballers where id = @footballerId";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@footballerId", footballerId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    footballer.Id = reader.GetInt32(0);
                    footballer.name = reader.GetString(1);
                    footballer.age = reader.GetString(2);
                    footballer.nationality = reader.GetString(3);
                    footballer.datеOfBirth = reader.GetDateTime(4);
                    footballer.height = reader.GetInt16(5);
                    footballer.weight = reader.GetInt16(6);
                    footballer.number = reader.GetInt16(7);
                    footballer.position = reader.GetString(8);
                    footballer.Team = new Team();
                    footballer.Team.Id = reader.GetInt32(9);
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return footballer;
        }

        public static DataTable GetFootballers(int teamId)
        {
            SqlConnection dbConnection = null;
            DataTable dataTable = new DataTable();
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select * from Footballers where Team_Id = @teamId";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@teamId", teamId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return dataTable;
        }

        public static bool АddFavoriteTeam(int userId, int teamId)
        {
            SqlConnection dbConnection = null;
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "insert into UserTeam(Users_Id, Teams_Id) values(@userId, @teamId)";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                cmd.Parameters.Add(new SqlParameter("@teamId", teamId));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
        }

        public static bool АddGame(int homeTeamId, int awayTeamId, DateTime matchDate)
        {
            SqlConnection dbConnection = null;
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "insert into Games(homeTeam_Id, awayTeam_Id, matchDate) values(@homeTeamId, @awayTeamId, @matchDate)";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@homeTeamId", homeTeamId));
                cmd.Parameters.Add(new SqlParameter("@awayTeamId", awayTeamId));
                cmd.Parameters.Add(new SqlParameter("@matchDate", matchDate));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
        }

        public static bool UpdateGameResult(int gameId, int homeTeamScore, int awayTeamScore)
        {
            SqlConnection dbConnection = null;
            string result = homeTeamScore + ":" + awayTeamScore;
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "update Games set result = @result where id = @gameId";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@result", result));
                cmd.Parameters.Add(new SqlParameter("@gameId", gameId));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
        }

        public static IList<Game> getLatestGamesForTeam(int teamId, int gamesCount) {
            IList<Game> games = new List<Game>();
            using (SqlConnection dbConnection = new SqlConnection(DB_CONNECTION_STRING)) {
                dbConnection.Open();
                string commandText = "select top @gamesCount * from Games as game, Teams as homeTeam, Teams as awayTeam where awayTeam.Id = game.awayTeam_Id and homeTeam.Id = game.homeTeam_Id and (game.awayTeam_Id=@teamId or game.homeTeam_Id=@teamId) order by game.matchDate";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@gamesCount", gamesCount));
                cmd.Parameters.Add(new SqlParameter("@teamId", teamId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    reader.Read();
                    Game game = new Game();
                    game.homeTeam = GetTeam(reader.GetInt32(3));
                    game.awayTeam = GetTeam(reader.GetInt32(4));
                    game.result = reader.GetString(2);
                    games.Add(game);
                }
            }
            return games;
        }
    }
}
