using AutoFact2.Controllers;
using AutoFact2.Models;
using AutoFact2.Repository;
using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AutoFact2
{
    public partial class FormInvoiceList : Form
    {
        public InvoiceController InController;
        public CustomerRepository custRepository;

        public static int id;

        public FormInvoiceList()
        {
            InitializeComponent();
            InController = new InvoiceController();
            custRepository = new CustomerRepository();
        }

        private void FormInvoiceList_Load(object sender, EventArgs e)
        {
            LeRefresh();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvInvoice.Columns[e.ColumnIndex].Name == "ColBtnUpdate")
            {
                int id = Convert.ToInt32(DgvInvoice.Rows[e.RowIndex].Cells["ColId"].Value);
                DgvInvoice.Refresh();
            }

            if (this.DgvInvoice.Columns[e.ColumnIndex].Name == "ColBtnPDF")
            {
                int id = Convert.ToInt32(DgvInvoice.Rows[e.RowIndex].Cells["ColIdInvoice"].Value);
                Invoice thefacture = new Invoice(id);
                thefacture.GenerateInvoicePDF();
                return;
            }

            if (this.DgvInvoice.Columns[e.ColumnIndex].Name == "ColBtnDetail")
            {
                int id = Convert.ToInt32(DgvInvoice.Rows[e.RowIndex].Cells["ColIdInvoice"].Value);
                FormInvoiceDetail InvoiceDetail = new FormInvoiceDetail(id);
                InvoiceDetail.ShowDialog();
            }
        }

        private void BtnCreateInvoice_Click(object sender, EventArgs e)
        {
            FormInvoiceDetail InvoiceDetail = new FormInvoiceDetail();
            InvoiceDetail.ShowDialog();
        }

        public void LeRefresh()
        {
            this.DgvInvoice.Rows.Clear();
            foreach (var uneFacture in InController.findAll())
            {
                string dgvId = uneFacture.GetId().ToString();
                int dgvIdInvoice = uneFacture.GetidCustomer();
                DateTime dgvDateInvoice = uneFacture.GetDateInvoice();

                Customer customer = custRepository.getInfo(dgvIdInvoice);
                string customerName;
                string customerCompany;
                string customerSurname;

                if (customer is Physical)
                {
                    Physical physicalCustomer = (Physical)customer;
                    customerName = physicalCustomer.GetName();
                    customerSurname = physicalCustomer.GetLastname();
                    customerCompany = string.Empty; // Pas de nom de société pour les clients physiques
                }
                else
                {
                    Moral moralCustomer = (Moral)customer;
                    customerName = string.Empty; // Pas de prénom pour les clients moraux
                    customerSurname = string.Empty; // Pas de nom de famille pour les clients moraux
                    customerCompany = moralCustomer.GetCompanyName();
                }

                this.DgvInvoice.Rows.Add(dgvId, customerName, customerSurname, customerCompany, dgvDateInvoice, "Generer PDF", "Détails");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LeRefresh();
        }
    }
}