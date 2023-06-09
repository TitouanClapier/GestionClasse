using GestionClasse.Models;
using GestionClasse.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GestionClasse.Repository
{
    public class RepoProfesseur
    {
        public RepoProfesseur()
        {

        }

        public List<ClsProfesseur> FindAll()
        {
            //MessageBox.Show("test");
            List<ClsProfesseur> lesProfesseurs = new List<ClsProfesseur>();


            // string connectionString = "Data Source= " + Application.StartupPath + "../../../DBgestionclasse.db";
            string connectionString = "Data Source=../../../DBgestionclasse.db";

            //MessageBox.Show(connectionString);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT * FROM Professeurs;";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["P_Id"]);
                            string nom = Convert.ToString(reader["P_Nom"]);
                            string prenom = Convert.ToString(reader["P_Prenom"]);
                            string sexe = Convert.ToString(reader["P_Sexe"]);

                            lesProfesseurs.Add(new ClsProfesseur(id, nom, prenom, sexe));
                        }
                    }
                }

                connection.Close();
            }

            return lesProfesseurs;
        }

        public ClsProfesseur Find(int id)
        {
            ClsProfesseur professeur = null;

            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT * FROM Professeurs WHERE P_Id = @Id;";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nom = Convert.ToString(reader["P_Nom"]);
                            string prenom = Convert.ToString(reader["P_Prenom"]);
                            string sexe = Convert.ToString(reader["P_Sexe"]);

                            professeur = new ClsProfesseur(id, nom, prenom, sexe);
                        }
                    }
                }

                connection.Close();
            }

            return professeur;
        }

        public void Create(string nom, string prenom, string sexe)
        {
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string insertSql = "INSERT INTO Professeurs (Nom, Prenom, Sexe) VALUES (@Nom, @Prenom, @Sexe)";

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
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string deleteSql = "DELETE FROM Professeurs WHERE IdProf = @Id";

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
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string updateSql = "UPDATE Professeurs SET Nom = @Nom, Prenom = @Prenom, Sexe = @Sexe WHERE IdProf = @Id;";

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

        public ClsProfesseur GetInfo(int id)
        {
            //MessageBox.Show(Convert.ToString(id));
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string selectSql = "SELECT * FROM Professeurs WHERE P_ID = @Id;";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nom = Convert.ToString(reader["P_Nom"]);
                            string prenom = Convert.ToString(reader["P_Prenom"]);
                            string sexe = Convert.ToString(reader["P_Sexe"]);

                            return new ClsProfesseur(id, nom, prenom, sexe);
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }
    }
}
