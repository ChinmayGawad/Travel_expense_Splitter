using System;
using System.Data.SqlClient;

namespace Travel_expense_Splitter.Adapter
{
    internal class DatabaseHelper : IDisposable
    {
        private static string _connectionString = "Server=CHINMAY-N3P5PKK\\SQLEXPRESS;Database=travel_expenses;Integrated Security=True;";
        private SqlConnection _connection;

        public DatabaseHelper()
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Connection string is not initialized.");
            }

            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public static string ConnectionString
        {
            get => _connectionString;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Connection string cannot be null or empty.");
                }
                _connectionString = value;
            }
        }

        public SqlConnection Connection => _connection;

        public SqlDataReader ExecuteReader(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection.Dispose();
                _connection = null;
            }
        }
    }
}
