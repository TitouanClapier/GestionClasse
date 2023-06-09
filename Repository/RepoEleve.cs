using GestionClasse.Models;
using GestionClasse.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GestionClasse.Repository
{
    public class RepoEleve
    {
        public RepoEleve()
        {

        }

        public List<ClsEleve> FindAll()
        {
            List<ClsEleve> lesEleves = new List<ClsEleve>();

            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT * FROM Eleves ORDER BY E_Nom, E_Prenom;";
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

                            lesEleves.Add(new ClsEleve(id, nom, prenom, sexe, idClasse));
                        }
                    }
                }

                connection.Close();
            }

            return lesEleves;
        }

        public List<ClsEleve> GetElevesByClasse(int classeId)
        {
            List<ClsEleve> eleves = new List<ClsEleve>();

            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT * FROM Eleves WHERE E_FK_C_ID = @ClasseId ORDER BY E_Nom, E_Prenom;";
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

                            eleves.Add(new ClsEleve(idEleve, nom, prenom, sexe, idClasse));
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
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string updateSql = "UPDATE Eleves SET E_Nom = @Nom, E_Prenom = @Prenom, E_Sexe = @Sexe, E_FK_C_ID = @IdClasse WHERE E_ID = @Id";

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

        public ClsEleve GetInfo(int id)
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

                            return new ClsEleve(id, nom, prenom, sexe, idClasse);
                        }
                    }
                }

                connection.Close();
            }

            return null; // Retourner null si aucune correspondance trouvée ou en cas d'erreur
        }
    }
}
