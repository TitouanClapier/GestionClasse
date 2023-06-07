using GestionClasse.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GestionClasse.Repository
{
    public class EleveRepository
    {
        public EleveRepository()
        {

        }

        public List<Eleve> FindAll()
        {
            List<Eleve> lesEleves = new List<Eleve>();

            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT * FROM Eleve";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["IdEleve"]);
                            string nom = Convert.ToString(reader["Nom"]);
                            string prenom = Convert.ToString(reader["Prenom"]);
                            string sexe = Convert.ToString(reader["Sexe"]);

                            lesEleves.Add(new Eleve(id, nom, prenom, sexe));
                        }
                    }
                }

                connection.Close();
            }

            return lesEleves;
        }

        public void Create(string nom, string prenom, string sexe)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string insertSql = "INSERT INTO Eleve (Nom, Prenom, Sexe) VALUES (@Nom, @Prenom, @Sexe)";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@Prenom", prenom);
                    command.Parameters.AddWithValue("@Sexe", sexe);

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
                string deleteSql = "DELETE FROM Eleve WHERE IdEleve = @Id";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(deleteSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void Update(int id, string nom, string prenom, string sexe)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string updateSql = "UPDATE Eleve SET Nom = @Nom, Prenom = @Prenom, Sexe = @Sexe WHERE IdEleve = @Id";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(updateSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@Prenom", prenom);
                    command.Parameters.AddWithValue("@Sexe", sexe);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public Eleve GetInfo(int id)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string selectSql = "SELECT * FROM Eleve WHERE IdEleve = @Id";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nom = Convert.ToString(reader["Nom"]);
                            string prenom = Convert.ToString(reader["Prenom"]);
                            string sexe = Convert.ToString(reader["Sexe"]);

                            return new Eleve(id, nom, prenom, sexe);
                        }
                    }
                }

                connection.Close();
            }

            return null; // Retourner null si aucune correspondance trouvée ou en cas d'erreur
        }
    }
}
