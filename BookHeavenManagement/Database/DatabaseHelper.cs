using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BookHeavenManagement.Database
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["BookHeavenConnection"].ConnectionString;

        public static DataTable ExecuteQuery(string query, SqlParameter[]? parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public static int ExecuteBobQuery(string query, SqlParameter[]? parameters = null)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public static object ExecuteScalar(string query, SqlParameter[]? parameters = null)
        {
            object? result = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    result = command.ExecuteScalar();
                }
            }
            return result;
        }
    }
}
