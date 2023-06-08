using GestionClasse.Models;
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

            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT * FROM Eleves";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["E_ID"]);
                            string nom = Convert.ToString(reader["E_Nom"]);
                            string prenom = Convert.ToString(reader["E_Prenom"]);
                            string sexe = Convert.ToString(reader["E_Sexe"]);
                            int idClasse = Convert.ToInt32(reader["E_FK_C_ID"]);

                            lesEleves.Add(new Eleve(id, nom, prenom, sexe, idClasse));
                        }
                    }
                }

                connection.Close();
            }

            return lesEleves;
        }

        public List<Eleve> GetElevesByClasse(int classeId)
        {
            List<Eleve> eleves = new List<Eleve>();

            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT * FROM Eleve WHERE E_FK_C_ID = @ClasseId";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@ClasseId", classeId);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idEleve = Convert.ToInt32(reader["E_ID"]);
                            string nom = reader["E_Nom"].ToString();
                            string prenom = reader["E_Prenom"].ToString();
                            string sexe = reader["E_Sexe"].ToString();
                            int idClasse = Convert.ToInt32(reader["E_FK_C_ID"]);

                            eleves.Add(new Eleve(idEleve, nom, prenom, sexe, idClasse));
                        }
                    }
                }

                connection.Close();
            }

            return eleves;
        }
        public void Create(string nom, string prenom, string sexe, int idClasse)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string insertSql = "INSERT INTO Eleve (Nom, Prenom, Sexe, IdClasse) VALUES (@Nom, @Prenom, @Sexe, @IdClasse)";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@Prenom", prenom);
                    command.Parameters.AddWithValue("@Sexe", sexe);
                    command.Parameters.AddWithValue("@IdClasse", idClasse);

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

        public void Update(int id, string nom, string prenom, string sexe, int idClasse)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string updateSql = "UPDATE Eleve SET Nom = @Nom, Prenom = @Prenom, Sexe = @Sexe, IdClasse = @IdClasse WHERE IdEleve = @Id";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(updateSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@Prenom", prenom);
                    command.Parameters.AddWithValue("@Sexe", sexe);
                    command.Parameters.AddWithValue("@IdClasse", idClasse);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public Eleve GetInfo(int id)
        {
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string selectSql = "SELECT * FROM Eleves WHERE E_ID = @Id";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nom = Convert.ToString(reader["E_Nom"]);
                            string prenom = Convert.ToString(reader["E_Prenom"]);
                            string sexe = Convert.ToString(reader["E_Sexe"]);
                            int idClasse = Convert.ToInt32(reader["E_FK_C_ID"]);

                            return new Eleve(id, nom, prenom, sexe, idClasse);
                        }
                    }
                }

                connection.Close();
            }

            return null; // Retourner null si aucune correspondance trouvée ou en cas d'erreur
        }
    }
}
