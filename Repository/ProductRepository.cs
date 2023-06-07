using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoFact2.Repository
{
    public class ProductRepository
    {
        public ProductRepository()
        {

        }

        public List<Product> FindAll()
        {
            int id;
            string label;
            float unitPrice;
            int idCategory;

            List<Product> lesProducts = new List<Product>();
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT * FROM Product";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    label = Convert.ToString(reader["libel"]);
                    unitPrice = Convert.ToSingle(reader["unitPrice"]);
                    idCategory = Convert.ToInt32(reader["idCategory"]);

                    lesProducts.Add(new Product(id, label, unitPrice, idCategory));
                }
            }
            reader.Close();
            connection.Close();

            return lesProducts;
        }

        public Product Find(int id)
        {
            int productId;
            string label;
            float unitPrice;
            int idCategory;

            string connectionString = "Data Source=../../AutoFact2BDD.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectSql = "SELECT * FROM Product WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            productId = Convert.ToInt32(reader["id"]);
                            label = Convert.ToString(reader["libel"]);
                            unitPrice = Convert.ToSingle(reader["unitPrice"]);
                            idCategory = Convert.ToInt32(reader["idCategory"]);

                            return new Product(productId, label, unitPrice, idCategory);
                        }
                    }
                }
            }

            return null; // If product is not found
        }

        public void Create(string label, float unitPrice, int idCategory)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string insertSql = "INSERT INTO Product (libel, unitPrice, idCategory) " +
                            "VALUES (@Label, @UnitPrice, @IdCategory)";

            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
            {
                command.Parameters.AddWithValue("@Label", label);
                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                command.Parameters.AddWithValue("@IdCategory", idCategory);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void Delete(int id)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string deleteSql = "DELETE FROM Product WHERE id = @Id";

            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(deleteSql, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void Update(int id, string label, float unitPrice, int idCategory)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string updateSql = "UPDATE Product " +
                 "SET libel = @Label, unitPrice = @UnitPrice, idCategory = @IdCategory " +
                 "WHERE id = @Id";

            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(updateSql, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Label", label);
                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                command.Parameters.AddWithValue("@IdCategory", idCategory);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}