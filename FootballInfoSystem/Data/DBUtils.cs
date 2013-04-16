﻿using System;
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
        
        public static DataTable GetFavoriteTeams(int userId)
        {
            SqlConnection dbConnection = null;
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
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    return dataTable;
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return new DataTable();
        }

        public static DataTable GetLeagues()
        {
            SqlConnection dbConnection = null;
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select * from Leagues";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    return dataTable;
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return new DataTable();
        }

        public static DataTable GetTeamsInLeague(int leagueId)
        {
            SqlConnection dbConnection = null;
            try
            {
                dbConnection = new SqlConnection(DB_CONNECTION_STRING);
                dbConnection.Open();
                string commandText = "select * from Teams where League_id = @leagueId";
                SqlCommand cmd = new SqlCommand(commandText, dbConnection);
                cmd.Parameters.Add(new SqlParameter("@leagueId", leagueId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    return dataTable;
                }
            }
            finally
            {
                if (dbConnection != null)
                {
                    dbConnection.Close();
                }
            }
            return new DataTable();
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

    }
}