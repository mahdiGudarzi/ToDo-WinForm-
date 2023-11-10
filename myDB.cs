using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;
using System.Data;

namespace ToDo
{


    internal class MyDatabase
    {
        private string connectionString;

        public MyDatabase()
        {
           
            connectionString = "Data Source=myDatabase.sqlite;Version=3;";
            
            if (!File.Exists("./myDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("./myDatabase.sqlite");
            }
        }

        #region Table!
        public void CreateTableIfNotExists(string tableName)
        {
            var connection = new SQLiteConnection(connectionString);
            connection.Open();

            var command = new SQLiteCommand($"CREATE TABLE IF NOT EXISTS  {tableName} (Id INT PRIMARY KEY, Task TEXT NOT NULL)", connection);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }


        public List<string> GetTableNames()
        {

            var result = new List<string>();
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            var command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table'", connection);
            var adapter = new SQLiteDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                result.Add(row["name"].ToString());
            }
            adapter.Dispose();
            command.Dispose();
            connection.Close();
            return result;
        }

        public void RemoveTableIfExists(string tableName)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand($"DROP TABLE IF EXISTS {tableName}", connection);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }


        #endregion

        #region Task
        public List<string> GetTask(string tableName)
        {
            List<string> iTask = new List<string>();
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            string sql = $"SELECT Task FROM {tableName}";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                iTask.Add(row["Task"].ToString());
               
            }
            adapter.Dispose();
            command.Dispose();
            connection.Close();
            return iTask;
        }



        public void InsertTask(string tableName, string iTask)
        {
            string sql = $"INSERT INTO {tableName} (Task) VALUES ('{iTask}')";
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            var command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }

        public void RemoveTask(string tableName, string dataName)
        {
           
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            string sql = $"DELETE FROM {tableName} WHERE Task = '{dataName}'";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }


    }

    #endregion

}
