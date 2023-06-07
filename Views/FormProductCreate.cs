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
    public partial class FormProductCreate : Form
    {
        public ProductController productController;

        public FormProductCreate()
        {
            InitializeComponent();
            productController = new ProductController();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string label = TxtLabel.Text;
            string unitPrice = TxtUnitPrice.Text;
            string category = ComboCategory.Text;

            if (category == "1. Service")
            {
                productController.create(label, Convert.ToSingle(unitPrice), 1);
                MessageBox.Show("Le service a bien été ajouté à la base de données.");
                this.Close();
            }
            else if (category == "2. Produit")
            {
                productController.create(label, Convert.ToSingle(unitPrice), 2);
                MessageBox.Show("Le produit a bien été ajouté à la base de données.");
                this.Close();
            }
        }
    }
}
