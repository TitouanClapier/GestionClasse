using GestionClasse.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GestionClasse.Repository
{
    public class MatiereRepository
    {
        public MatiereRepository()
        {

        }

        public List<Matiere> FindAll()
        {
            List<Matiere> lesMatieres = new List<Matiere>();

            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT * FROM Matiere";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idMatiere = Convert.ToInt32(reader["IdMatiere"]);
                            string nom = Convert.ToString(reader["Nom"]);
                            int idProf = Convert.ToInt32(reader["IdProf"]);

                            lesMatieres.Add(new Matiere(idMatiere, nom, idProf));
                        }
                    }
                }

                connection.Close();
            }

            return lesMatieres;
        }

        public void Create(string nom, int idProf)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string insertSql = "INSERT INTO Matiere (Nom, IdProf) VALUES (@Nom, @IdProf)";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@IdProf", idProf);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void Delete(int id)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string deleteSql = "DELETE FROM Matiere WHERE IdMatiere = @Id";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(deleteSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void Update(int id, string nom, int idProf)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string updateSql = "UPDATE Matiere SET Nom = @Nom, IdProf = @IdProf WHERE IdMatiere = @Id";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(updateSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@IdProf", idProf);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public Matiere GetInfo(int id)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string selectSql = "SELECT * FROM Matiere WHERE IdMatiere = @Id";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nom = Convert.ToString(reader["Nom"]);
                            int idProf = Convert.ToInt32(reader["IdProf"]);

                            return new Matiere(id, nom, idProf);
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }
    }
}
