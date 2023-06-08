using GestionClasse.Models;
using GestionClasse.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GestionClasse.Repository
{
    public class NoteRepository
    {
        public NoteRepository()
        {

        }

        public List<Note> FindAll()
        {
            List<Note> lesNotes = new List<Note>();

            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT * FROM Note";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idNote = Convert.ToInt32(reader["IdNote"]);
                            int valeur = Convert.ToInt32(reader["Valeur"]);
                            int idEleve = Convert.ToInt32(reader["IdEleve"]);
                            int idMatiere = Convert.ToInt32(reader["IdMatiere"]);

                            lesNotes.Add(new Note(idNote, valeur, idEleve, idMatiere));
                        }
                    }
                }

                connection.Close();
            }

            return lesNotes;
        }

        public void Create(int valeur, int idEleve, int idMatiere)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string insertSql = "INSERT INTO Note (Valeur, IdEleve, IdMatiere) VALUES (@Valeur, @IdEleve, @IdMatiere)";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@Valeur", valeur);
                    command.Parameters.AddWithValue("@IdEleve", idEleve);
                    command.Parameters.AddWithValue("@IdMatiere", idMatiere);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void Delete(int idNote)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string deleteSql = "DELETE FROM Note WHERE IdNote = @IdNote";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(deleteSql, connection))
                {
                    command.Parameters.AddWithValue("@IdNote", idNote);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void Update(int idNote, int valeur, int idEleve, int idMatiere)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string updateSql = "UPDATE Note SET Valeur = @Valeur, IdEleve = @IdEleve, IdMatiere = @IdMatiere WHERE IdNote = @IdNote";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(updateSql, connection))
                {
                    command.Parameters.AddWithValue("@IdNote", idNote);
                    command.Parameters.AddWithValue("@Valeur", valeur);
                    command.Parameters.AddWithValue("@IdEleve", idEleve);
                    command.Parameters.AddWithValue("@IdMatiere", idMatiere);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public Note GetInfo(int idNote)
        {
            string connectionString = "Data Source=../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string selectSql = "SELECT * FROM Note WHERE IdNote = @IdNote";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@IdNote", idNote);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int valeur = Convert.ToInt32(reader["Valeur"]);
                            int idEleve = Convert.ToInt32(reader["IdEleve"]);
                            int idMatiere = Convert.ToInt32(reader["IdMatiere"]);

                            return new Note(idNote, valeur, idEleve, idMatiere);
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }
    }
}
