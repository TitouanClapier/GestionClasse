using GestionClasse.Models;
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

        public List<Note> Find(int id)
        {
            List<Note> lesNotes = new List<Note>();

            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT * FROM Notes WHERE N_FK_E_ID = @IdEleve";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@IdEleve", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idNote = Convert.ToInt32(reader["N_id"]);
                            int valeur = Convert.ToInt32(reader["N_Valeur"]);
                            int idMatiere = Convert.ToInt32(reader["N_FK_M_ID"]);

                            lesNotes.Add(new Note(idNote, valeur, id, idMatiere));
                        }
                    }
                }

                connection.Close();
            }

            return lesNotes;
        }

        public void Create(int valeur, int idEleve, int idMatiere)
        {
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string insertSql = "INSERT INTO Notes (N_Valeur, N_FK_E_ID, N_FK_M_ID) VALUES (@Valeur, @IdEleve, @IdMatiere)";

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
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string deleteSql = "DELETE FROM Notes WHERE N_id = @IdNote";

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
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string updateSql = "UPDATE Notes SET N_Valeur = @Valeur, N_FK_E_ID = @IdEleve, N_FK_M_ID = @IdMatiere WHERE N_id = @IdNote";

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
            string connectionString = "Data Source=../../../DBgestionclasse.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string selectSql = "SELECT * FROM Notes WHERE N_id = @IdNote";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@IdNote", idNote);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int valeur = Convert.ToInt32(reader["N_Valeur"]);
                            int idEleve = Convert.ToInt32(reader["N_FK_E_ID"]);
                            int idMatiere = Convert.ToInt32(reader["N_FK_M_ID"]);

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
