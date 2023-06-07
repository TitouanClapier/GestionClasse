using AutoFact2.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoFact2.Views
{
    public partial class FormProductUpdate : Form
    {
        public ProductController productController;

        public FormProductUpdate(int id)
        {
            InitializeComponent();
            productController = new ProductController();

            foreach (var unProduit in productController.FindAll())
            {
                if (unProduit.GetId() == id)
                {
                    TxtId.Text = unProduit.GetId().ToString();
                    TxtLabel.Text = unProduit.GetLabel();
                    TxtUnitPrice.Text = unProduit.GetUnitPrice().ToString();

                    int idCategory = unProduit.GetIdCategory();
                    if (idCategory == 1)
                    {
                        ComboCategory.Text = "1. Service";
                    }
                    else if (idCategory == 2)
                    {
                        ComboCategory.Text = "2. Produit";
                    }
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductUpdate_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtId.Text);
            string label = TxtLabel.Text;
            float unitPrice = Convert.ToSingle(TxtUnitPrice.Text);
            int idCategory;

            if (ComboCategory.Text == "1. Service")
            {
                idCategory = 1;
                productController.update(id, label, unitPrice, idCategory);
                MessageBox.Show("Le service a bien été modifié dans la base de données.");
                this.Close();
            }
            else if (ComboCategory.Text == "2. Produit")
            {
                idCategory = 2;
                productController.update(id, label, unitPrice, idCategory);
                MessageBox.Show("Le produit a bien été modifié dans la base de données.");
                this.Close();
            }
        }
    }
}
