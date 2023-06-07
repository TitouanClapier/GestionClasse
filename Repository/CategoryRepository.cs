using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Repository
{
    public class CategoryRepository
    {
        public CategoryRepository()
        {

        }

        public List<Category> findAll()
        {
            int id;
            string label;

            List<Category> lesCategories = new List<Category>();
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT * FROM Category";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    label = Convert.ToString(reader["libel"]);

                    lesCategories.Add(new Category(id, label));
                }
            }
            reader.Close();
            connection.Close();

            return lesCategories;
        }
    }
}
