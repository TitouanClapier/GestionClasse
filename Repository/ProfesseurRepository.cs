using GestionClasse.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GestionClasse.Repository
{
    public class ProfesseurRepository
    {
        public ProfesseurRepository()
        {

        }

        public List<Professeur> FindAll()
        {
            List<Professeur> lesProfesseurs = new List<Professeur>();

            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT * FROM Professeur";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idProf = Convert.ToInt32(reader["IdProf"]);
                            string nom = Convert.ToString(reader["Nom"]);
                            string prenom = Convert.ToString(reader["Prenom"]);
                            string sexe = Convert.ToString(reader["Sexe"]);

                            lesProfesseurs.Add(new Professeur(idProf, nom, prenom, sexe));
                        }
                    }
                }

                connection.Close();
            }

            return lesProfesseurs;
        }

        public void Create(string nom, string prenom, string sexe)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string insertSql = "INSERT INTO Professeur (Nom, Prenom, Sexe) VALUES (@Nom, @Prenom, @Sexe)";

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
                string deleteSql = "DELETE FROM Professeur WHERE IdProf = @Id";

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
                string updateSql = "UPDATE Professeur SET Nom = @Nom, Prenom = @Prenom, Sexe = @Sexe WHERE IdProf = @Id";

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

        public Professeur GetInfo(int id)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string selectSql = "SELECT * FROM Professeur WHERE IdProf = @Id";

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

                            return new Professeur(id, nom, prenom, sexe);
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }
    }
}
