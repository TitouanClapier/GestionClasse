using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Repository
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {

        }
        public List<Customer> findAll()
        {
            int id;
            string nom;
            string prenom;
            string nomEntreprise;
            string adresse;
            int cp;
            string ville;
            string mail;
            string tel;

            List<Customer> lesClients = new List<Customer>();
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT * FROM Customer";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    nom = Convert.ToString(reader["name"]);
                    prenom = Convert.ToString(reader["lastName"]);
                    nomEntreprise = Convert.ToString(reader["companyName"]);
                    adresse = Convert.ToString(reader["adress"]);
                    cp = Convert.ToInt32(reader["postalCode"]);
                    ville = Convert.ToString(reader["city"]);
                    mail = Convert.ToString(reader["mail"]);
                    tel = Convert.ToString(reader["tel"]);

                    if (string.IsNullOrEmpty(nom) && string.IsNullOrEmpty(prenom))
                    {
                        lesClients.Add(new Moral(id, nomEntreprise, adresse, cp, ville, mail, tel));
                    }
                    else if (string.IsNullOrEmpty(nomEntreprise))
                    {
                        lesClients.Add(new Physical(id, nom, prenom, adresse, cp, ville, mail, tel));
                    }
                }
            }
            reader.Close();
            connection.Close();

            return lesClients;
        }

        
        public void create(string name, string lastName, string companyName, string address, int postalCode, string city, string mail, string tel)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string insertSql = "";

            if (name == "" && lastName == "")
            {
                insertSql = "INSERT INTO Customer (name, lastName, companyName, adress, postalCode, city, mail, tel) " +
                            "VALUES (NULL, NULL, @CompanyName, @Address, @PostalCode, @City, @Mail, @Tel)";
            }
            else if (companyName == "")
            {
                insertSql = "INSERT INTO Customer (name, lastName, companyName, adress, postalCode, city, mail, tel) " +
                            "VALUES (@Name, @LastName, NULL, @Address, @PostalCode, @City, @Mail, @Tel)";
            }

            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@CompanyName", companyName);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Mail", mail);
                command.Parameters.AddWithValue("@Tel", tel);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void delete(int id)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string deleteSql = "";

                deleteSql = "DELETE FROM Customer WHERE id = @id; " +
                            "VALUES (@id)";
            

            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(deleteSql, connection))
            {
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
            connection.Close();


        }

        public void update(int id, string name, string lastName, string companyName, string address, int postalCode, string city, string mail, string tel)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string updateSql = "";

            if (name == "" && lastName == "")
            {
                updateSql = "UPDATE Customer " +
                 "SET name = NULL, lastName = NULL, companyName = @CompanyName, adress = @Address, postalCode = @PostalCode, city = @City, mail = @Mail, tel = @Tel " +
                 "WHERE id = @Id";

            }
            else if (companyName == "")
            {
                updateSql = "UPDATE Customer " +
                 "SET name = @Name, lastName = @LastName, companyName = NULL, adress = @Address, postalCode = @PostalCode, city = @City, mail = @Mail, tel = @Tel " +
                 "WHERE id = @Id";

            }

            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(updateSql, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@CompanyName", companyName);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Mail", mail);
                command.Parameters.AddWithValue("@Tel", tel);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public Customer getInfo(int id)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string larequete = "SELECT Name, LastName, CompanyName, Adress, PostalCode, City, Mail, Tel FROM Customer WHERE id = @Id";

            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(larequete, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string lastName = reader["LastName"].ToString();
                        string companyName = reader["CompanyName"].ToString();
                        string adress = reader["Adress"].ToString();
                        int postalCode = Convert.ToInt32(reader["PostalCode"]);
                        string city = reader["City"].ToString();
                        string email = reader["Mail"].ToString();
                        string telephone = reader["Tel"].ToString();

                        if (string.IsNullOrEmpty(companyName))
                        {
                            return new Physical(id, name, lastName, adress, postalCode, city, email, telephone);
                        }
                        else
                        {
                            return new Moral(id, companyName, adress, postalCode, city, email, telephone);
                        }
                    }
                }
            }

            connection.Close();

            return null; // Retourner null si aucune correspondance trouvée ou en cas d'erreur
        }
        




    }
}
