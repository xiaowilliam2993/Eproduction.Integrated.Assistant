using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Eproduction.Integrated.Assistant.Common.Worker {
    public static class MySqlWorker {
        public static DataTable Execute(string connectionString, string commandText) {
            if (string.IsNullOrEmpty(connectionString)) {
                throw new ArgumentNullException("connectionString");
            }
            if (string.IsNullOrEmpty(commandText)) {
                throw new ArgumentNullException("commandText");
            }

            DataTable dataTable = new DataTable();
            MySqlConnection connection = null;
            try {
                using (connection = new MySqlConnection(connectionString)) {
                    connection.Open();
                    using (var command = new MySqlCommand(commandText, connection)) {
                        using (var adapter = new MySqlDataAdapter(command)) {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            } catch (Exception) { throw; } finally {
                if (connection != null && connection.State == ConnectionState.Open) {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return dataTable;
        }
    }
}
