using System;
using System.Data.SqlClient;

namespace Travel_expense_Splitter.Adapter
{
    internal class DatabaseHelper : IDisposable
    {
        private readonly string _connectionString;
        private SqlConnection _connection;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

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
