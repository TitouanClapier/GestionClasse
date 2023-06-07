using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Repository
{
    public class ProfilRepository
    {
        public ProfilRepository() 
        {
            
        }   
        public List<Profil> findAll()
        {
            int id;
            string raisonSocial;
            int siren;
            string adresse;
            int cp;
            string ville;
            string tel;
            string mail;

            List<Profil> lesProfils = new List<Profil>();
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT * FROM Profil";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if(reader.HasRows) 
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    raisonSocial = Convert.ToString(reader["socialReason"]);
                    siren = Convert.ToInt32(reader["siren"]);
                    adresse = Convert.ToString(reader["adress"]);
                    cp = Convert.ToInt32(reader["postalCode"]);
                    ville = Convert.ToString(reader["city"]);
                    tel = Convert.ToString(reader["tel"]);
                    mail = Convert.ToString(reader["mail"]);

                    lesProfils.Add(new Profil(id, raisonSocial, siren, adresse, cp, ville, tel, mail));
                }
            }
            reader.Close();
            connection.Close();

            return lesProfils;

        }

        public void update(int id, string socialReason, int siren, string adress, int postalCode, string city, string tel, string mail)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string updateSql = "UPDATE Profil " +
                 "SET socialReason = @SocialReason, siren = @Siren, adress = @Adress, postalCode = @PostalCode, city = @City, tel = @Tel, mail = @Mail " +
                 "WHERE id = @Id";

            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(updateSql, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@SocialReason", socialReason);
                command.Parameters.AddWithValue("@Siren", siren);
                command.Parameters.AddWithValue("@Adress", adress);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Tel", tel);
                command.Parameters.AddWithValue("@Mail", mail);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
