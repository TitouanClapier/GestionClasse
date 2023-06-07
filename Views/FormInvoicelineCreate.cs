using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoFact2.Controllers;
using AutoFact2.Models;
using AutoFact2.Repository;

namespace AutoFact2.Views
{
    public partial class FormInvoiceLineCreate : Form
    {
        private InvoiceLineController invoiceLineController;
        private ProductRepository productRepository;
        private int invoiceId;

        public FormInvoiceLineCreate(int invoiceId)
        {
            InitializeComponent();
            TxtPrice.Text = "0";
            TxtQuantity.Text = "1";
            TxtPromotion.Text = "0";
            invoiceLineController = new InvoiceLineController();
            productRepository = new ProductRepository();
            this.invoiceId = invoiceId;

            LoadProducts();
        }

        private void LoadProducts()
        {
            List<Product> products = productRepository.FindAll();

            foreach (Product product in products)
            {
                CBProduct.Items.Add($"{product.GetId()} - {product.GetLabel()}");
            }
        }
        private void BtnAddInvoiceLine_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int quantity = 0;
                decimal price = 0;
                decimal promotion = 0;

                if (!string.IsNullOrWhiteSpace(TxtQuantity.Text))
                {
                    quantity = Convert.ToInt32(TxtQuantity.Text);
                }

                if (!string.IsNullOrWhiteSpace(TxtPrice.Text))
                {
                    price = Convert.ToDecimal(TxtPrice.Text);
                }

                if (!string.IsNullOrWhiteSpace(TxtPromotion.Text))
                {
                    promotion = Convert.ToDecimal(TxtPromotion.Text);
                }

                int productId = 0;
                string selectedProduct = CBProduct.SelectedItem.ToString();
                int separatorIndex = selectedProduct.IndexOf('-');

                if (separatorIndex != -1)
                {
                    productId = Convert.ToInt32(selectedProduct.Substring(0, separatorIndex).Trim());
                }

                Invoiceline invoiceLine = new Invoiceline(invoiceId, productId, quantity, promotion, price);
                invoiceLineController.Create(invoiceLine);
                //MessageBox.Show(Convert.ToString(invoiceLine.GetId()));
                MessageBox.Show("Invoice line added successfully!");

                ResetForm();

                // Mettez à jour la liste des lignes de facture dans FormInvoiceDetail
                if (Application.OpenForms["FormInvoiceDetail"] is FormInvoiceDetail formInvoiceDetail)
                {
                    formInvoiceDetail.LeRefresh(invoiceId);
                }
            }
            this.Close();
        }

        private bool ValidateInput()
        {
            //MessageBox.Show(TxtQuantity.Text);
            if (string.IsNullOrWhiteSpace(TxtQuantity.Text) || !int.TryParse(TxtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtPrice.Text) || !decimal.TryParse(TxtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtPromotion.Text) || !decimal.TryParse(TxtPromotion.Text, out decimal promotion))
            {
                MessageBox.Show("Please enter a valid promotion.");
                return false;
            }

            if (CBProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            TxtQuantity.Text = string.Empty;
            TxtPrice.Text = string.Empty;
            TxtPromotion.Text = string.Empty;
            CBProduct.SelectedIndex = -1;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productid = 0;

            if (CBProduct.SelectedItem != null)
            {
          
                string selectedProduct = CBProduct.SelectedItem.ToString();
                int separatorIndex = selectedProduct.IndexOf('-');
                ProductRepository repoproduit = new ProductRepository();
                if (separatorIndex != -1)
                {
                    productid = Convert.ToInt32(selectedProduct.Substring(0, separatorIndex).Trim());
                }

                if (productid != 0)
                {
                    TxtPrice.Text =Convert.ToString(repoproduit.Find(productid).GetUnitPrice());
                }
            }
        }  
    }
}