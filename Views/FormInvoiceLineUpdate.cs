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
using AutoFact2.Views;

namespace AutoFact2.Views
{
    public partial class FormInvoiceLineUpdate : Form
    {
        private InvoiceLineController invLineController;
        private int invoiceLineId;
        private ProductRepository proRepository;

        public FormInvoiceLineUpdate(int id)
        {
            InitializeComponent();
            invoiceLineId = id;
            invLineController = new InvoiceLineController();
            proRepository = new ProductRepository();



            // Afficher les détails de la ligne de facture à mettre à jour
            Invoiceline invoiceLine = invLineController.Find(invoiceLineId);
            if (invoiceLine != null)
            {
                //CBProduct.SelectedValue = invoiceLine.GetIdProduct();
                TxtQuantity.Text = invoiceLine.GetQuantity().ToString();
                TxtPrice.Text = invoiceLine.GetPrice().ToString();
                TxtPromotion.Text = invoiceLine.GetPromotion().ToString();
            }
            // Charger les produits dans la ComboBox
            LoadProducts(invoiceLine.GetIdProduct());   
        }

       

        private void LoadProducts(int idproductselectionne)
        {
            List<Product> products = proRepository.FindAll();
            CBProduct.DisplayMember = "Text";
            CBProduct.ValueMember = "Value";
            int i = 0;
            foreach (Product product in products)
            {
                CBProduct.Items.Add(new { Text = product.GetLabel(), Value = product.GetId() });
                
                if (product.GetId() == idproductselectionne)
                {
                    CBProduct.SelectedIndex = i;
                }
                i = i + 1;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            //int productId = Convert.ToInt32(CBProduct.SelectedValue);
            int productId = Convert.ToInt32((CBProduct.SelectedItem as dynamic).Value);
            int quantity = Convert.ToInt32(TxtQuantity.Text);
            decimal price = Convert.ToDecimal(TxtPrice.Text);
            decimal promotion = Convert.ToDecimal(TxtPromotion.Text);

            //MessageBox.Show(Convert.ToString(CBProduct.SelectedItem));
            //MessageBox.Show(Convert.ToString(CBProduct.SelectedText));
            //MessageBox.Show(Convert.ToString(CBProduct.SelectedValue));
            invLineController.Update(invoiceLineId, productId, quantity, price, promotion);

            // Afficher un message de succès
            MessageBox.Show("La ligne de facture a été mise à jour avec succès.");

            // Fermer le formulaire
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
