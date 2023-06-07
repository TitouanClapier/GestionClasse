using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            FormClientList ClientList = new FormClientList();
            ClientList.Show();

        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            FormProductList ProductList = new FormProductList();
            ProductList.Show();
        }

        private void btnInvoiceList_Click(object sender, EventArgs e)
        {
            FormInvoiceList InvoiceList = new FormInvoiceList();
            InvoiceList.Show();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            FormProfil Profil = new FormProfil();
            Profil.Show();
        }
    }
}
