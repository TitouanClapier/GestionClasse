using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Models
{
    public class DbConnect
    {
        private SQLiteConnection sqliteConnection;

        public DbConnect()
        {
            sqliteConnection = new SQLiteConnection("Data Source=../../AutoFact2BDD.db");
        }

        public void OpenConnection()
        {
            if (sqliteConnection.State != System.Data.ConnectionState.Open)
            {
                sqliteConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqliteConnection.State != System.Data.ConnectionState.Closed)
            {
                sqliteConnection.Close();
            }
        }

        public SQLiteDataReader ExecuteQuery(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, sqliteConnection);
            return command.ExecuteReader();
        }

        // Autres méthodes pour exécuter des requêtes et interagir avec la base de données

    }
}