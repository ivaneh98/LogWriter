using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogWriter
{
    public class DatabaseLogger:Logger
    {
        private string dbPath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">Строка подключения к бд.</param>
        public DatabaseLogger(string path)
        {
            dbPath = path;
        }
        internal override void WriteLog(string log)

        {
            base.WriteLog(log);

            SqliteConnection connect = new SqliteConnection(dbPath);
            SqliteCommand command = connect.CreateCommand();

            connect.Open();

            command.CommandText = @"CREATE TABLE IF NOT EXISTS Logs (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, log TEXT)";
            command.ExecuteNonQuery();

            command.CommandText = @"INSERT INTO Logs (log) VALUES (@log)";
            command.Parameters.AddWithValue("@log", log);
            command.ExecuteNonQuery();

            connect.Close();
        }
    }
}
