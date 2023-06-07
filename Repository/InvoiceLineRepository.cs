using AutoFact2.Models;
using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AutoFact2.Repository
{
    public class InvoiceLineRepository
    {
        public List<Invoiceline> FindAll(int invoiceId)
        {
            List<Invoiceline> invoiceLines = new List<Invoiceline>();
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectSql = "SELECT * FROM Invoiceline WHERE idInvoice = @invoiceId";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@invoiceId", invoiceId);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idinvoice = Convert.ToInt32(reader["idInvoice"]);
                            int productId = Convert.ToInt32(reader["idProduct"]);
                            int quantity = Convert.ToInt32(reader["quantity"]);
                            decimal promotion = Convert.ToDecimal(reader["promotion"]);
                            decimal price = Convert.ToDecimal(reader["Prix"]);
                            int id = Convert.ToInt32(reader["id"]);
                            Invoiceline invoiceLine = new Invoiceline(idinvoice, productId, quantity, promotion, price);
                            invoiceLine.SetId(id);
                            invoiceLines.Add(invoiceLine);
                        }
                    }
                }
            }
            return invoiceLines;
        }

        public Invoiceline Find(int id)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectSql = "SELECT * FROM Invoiceline WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idInvoice = Convert.ToInt32(reader["idInvoice"]);
                            int idProduct = Convert.ToInt32(reader["idProduct"]);
                            int quantity = Convert.ToInt32(reader["quantity"]);
                            decimal promotion = Convert.ToDecimal(reader["promotion"]);
                            decimal price = Convert.ToDecimal(reader["Prix"]);
                            int invoiceLineId = Convert.ToInt32(reader["id"]);
                            Invoiceline invoiceLine = new Invoiceline(idInvoice, idProduct, quantity, promotion, price);
                            invoiceLine.SetId(invoiceLineId);
                            return invoiceLine;
                        }
                    }
                }
            }
            return null; // Return null if the invoice line with the specified ID was not found
        }

        public int Create(Invoiceline invoiceLine)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertSql = "INSERT INTO Invoiceline (idInvoice, idProduct, quantity, promotion, Prix) " +
                                   "VALUES (@invoiceId, @productId, @quantity, @promotion, @price); " +
                                   "SELECT last_insert_rowid();";
                using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@invoiceId", invoiceLine.GetIdInvoice());
                    command.Parameters.AddWithValue("@productId", invoiceLine.GetIdProduct());
                    command.Parameters.AddWithValue("@quantity", invoiceLine.GetQuantity());
                    command.Parameters.AddWithValue("@promotion", invoiceLine.GetPromotion());
                    command.Parameters.AddWithValue("@price", invoiceLine.GetPrice());

                    int id = Convert.ToInt32(command.ExecuteScalar());
                    invoiceLine.SetId(id);
                    return id;
                }
            }
        }

        public void Update(Invoiceline invoiceLine)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateSql = "UPDATE Invoiceline " +
                                   "SET idProduct = @productId, quantity = @quantity, promotion = @promotion, Prix = @price " +
                                   "WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(updateSql, connection))
                {
                    command.Parameters.AddWithValue("@productId", invoiceLine.GetIdProduct());
                    command.Parameters.AddWithValue("@quantity", invoiceLine.GetQuantity());
                    command.Parameters.AddWithValue("@promotion", invoiceLine.GetPromotion());
                    command.Parameters.AddWithValue("@price", invoiceLine.GetPrice());
                    command.Parameters.AddWithValue("@id", invoiceLine.GetId());
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int invoicelineId)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteSql = "DELETE FROM Invoiceline WHERE id = @invoicelineId";
                using (SQLiteCommand command = new SQLiteCommand(deleteSql, connection))
                {
                    command.Parameters.AddWithValue("@invoicelineId", invoicelineId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
