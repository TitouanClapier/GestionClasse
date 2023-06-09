﻿using GestionClasse.Models;
using GestionClasse.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GestionClasse.Repository
{
    public class RepoClasse
    {
        public RepoClasse()
        {

        }

        public List<ClsClasse> FindAll()
        {
            List<ClsClasse> lesClasses = new List<ClsClasse>();

            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                //MessageBox.Show(connectionString);
                string selectSql = "SELECT * FROM Classes";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        //MessageBox.Show(Convert.ToString( reader.Read()));
                        while (reader.Read())
                        {
                            //MessageBox.Show(Convert.ToString(reader["C_ID"]));
                            int idClasse = Convert.ToInt32(reader["C_ID"]);
                            string label = Convert.ToString(reader["C_Label"]);
                            int idProfPrincipale = Convert.ToInt32(reader["C_FK_P_ID"]);

                            lesClasses.Add(new ClsClasse(idClasse, label, idProfPrincipale));
                        }
                    }
                }

                connection.Close();
            }

            return lesClasses;
        }

        public void Create(string label, int idProfPrincipale)
        {
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string insertSql = "INSERT INTO Classes (Label, IdProfPrincipale) VALUES (@Label, @IdProfPrincipale)";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@Label", label);
                    command.Parameters.AddWithValue("@IdProfPrincipale", idProfPrincipale);

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
                string deleteSql = "DELETE FROM Classes WHERE IdClasse = @Id";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(deleteSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void Update(int id, string label, int idProfPrincipale)
        {
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string updateSql = "UPDATE Classes SET Label = @Label, IdProfPrincipale = @IdProfPrincipale WHERE IdClasse = @Id";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(updateSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Label", label);
                    command.Parameters.AddWithValue("@IdProfPrincipale", idProfPrincipale);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public ClsClasse GetInfo(int id)
        {
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string selectSql = "SELECT * FROM Classes WHERE C_ID = @Id";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string label = Convert.ToString(reader["C_Label"]);
                            int idProfPrincipale = Convert.ToInt32(reader["C_FK_P_ID"]);

                            return new ClsClasse(id, label, idProfPrincipale);
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }
    }
}
