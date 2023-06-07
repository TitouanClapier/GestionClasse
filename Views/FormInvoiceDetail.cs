using AutoFact2.Controllers;
using AutoFact2.Models;
using AutoFact2.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoFact2.Views
{
    public partial class FormInvoiceDetail : Form
    {
        public InvoiceController InController;
        public InvoiceLineController InlineController;
        private Invoice lafacture;
        private CustomerRepository custRepository;

        public FormInvoiceDetail(int id)
        {
            InitializeComponent();
            InController = new InvoiceController();
            InlineController = new InvoiceLineController();
            lafacture = new Invoice(id);
            TxtDate.Text = lafacture.GetDateInvoice().ToShortDateString();
            TxtId.Text = Convert.ToString(id);

            custRepository = new CustomerRepository();
            Customer customerrepo = custRepository.getInfo(lafacture.GetidCustomer());
            string customerName;
            string customerCompany;
            string customerSurname;

            if (customerrepo is Physical)
            {
                Physical physicalCustomer = (Physical)customerrepo;
                customerName = physicalCustomer.GetName();
                customerSurname = physicalCustomer.GetLastname();
                customerCompany = string.Empty;
            }
            else
            {
                Moral moralCustomer = (Moral)customerrepo;
                customerName = string.Empty;
                customerSurname = string.Empty;
                customerCompany = moralCustomer.GetCompanyName();
            }

            TxtName.Text = customerName;
            TxtSurname.Text = customerSurname;
            TxtCompagnyName.Text = customerCompany;

            TxtTotal.Text = lafacture.GetTotal().ToString();
            LoadCustomer(lafacture.GetidCustomer());
            CBCustomer.Enabled = false;
            LeRefresh(id);
        }

        public FormInvoiceDetail()
        {
            InitializeComponent();
            InController = new InvoiceController();
            InlineController = new InvoiceLineController();
            lafacture = new Invoice();
            custRepository = new CustomerRepository();
            TxtDate.Text = DateTime.Now.ToShortDateString();

            LoadCustomer();
            CBCustomer.Enabled = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvInvoiceline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvInvoiceline.Columns["BtnColDelete"].Index && e.RowIndex >= 0)
            {
                Invoiceline invoiceLine = InlineController.FindAll(lafacture.GetId())[e.RowIndex];
                int invoiceLineId = invoiceLine.GetId();

                InlineController.Delete(invoiceLineId);

                LeRefresh(lafacture.GetId());
            }
            else if (e.ColumnIndex == DgvInvoiceline.Columns["BtnColUpdate"].Index && e.RowIndex >= 0)
            {
                Invoiceline invoiceLine = InlineController.FindAll(lafacture.GetId())[e.RowIndex];
                int invoiceLineId = invoiceLine.GetId();

                FormInvoiceLineUpdate updateInvoiceLine = new FormInvoiceLineUpdate(invoiceLineId);
                updateInvoiceLine.ShowDialog();

                LeRefresh(lafacture.GetId());
            }
        }

        private void LoadCustomer(int idcustomerselectionne)
        {
            List<Customer> customers = custRepository.findAll();
            CBCustomer.DisplayMember = "Text";
            CBCustomer.ValueMember = "Value";
            int i = 0;
            foreach (Customer thesustomer in customers)
            {
                CBCustomer.Items.Add(new { Text = thesustomer.GetName() + " " + thesustomer.GetLastname(), Value = thesustomer.GetId() });

                if (thesustomer.GetId() == idcustomerselectionne)
                {
                    CBCustomer.SelectedIndex = i;
                }
                i = i + 1;
            }
        }

        private void LoadCustomer()
        {
            List<Customer> customers = custRepository.findAll();
            CBCustomer.DisplayMember = "Text";
            CBCustomer.ValueMember = "Value";
            int i = 0;
            foreach (Customer thesustomer in customers)
            {
                CBCustomer.Items.Add(new { Text = thesustomer.GetName() + " " + thesustomer.GetLastname(), Value = thesustomer.GetId() });
            }
        }

        public void LeRefresh(int id)
        {
            this.DgvInvoiceline.Rows.Clear();
            ProductController productController = new ProductController();

            foreach (Invoiceline invoiceLine in InlineController.FindAll(id))
            {
                Product product = productController.Find(invoiceLine.GetIdProduct());
                string dgvIdProduct = product.GetLabel();
                string dgvQuantity = invoiceLine.GetQuantity().ToString();
                string dgvPromotion = invoiceLine.GetPromotion().ToString();
                string dgvPrice = invoiceLine.GetPrice().ToString();
                string dgvAmount = invoiceLine.GetAmount().ToString();

                this.DgvInvoiceline.Rows.Add(dgvIdProduct, dgvQuantity, dgvPromotion, dgvPrice, dgvAmount, "Supprimer", "Modifier");
            }
        }

        private void BtnCreateInvoiceLine_Click(object sender, EventArgs e)
        {
            if (CBCustomer.SelectedItem != null)
            {
                if (lafacture.GetId() != 0)
                {
                    FormInvoiceLineCreate CreateInvoiceLine = new FormInvoiceLineCreate(lafacture.GetId());
                    CreateInvoiceLine.ShowDialog();
                    LeRefresh(lafacture.GetId());
                }
                else
                {
                    lafacture.SetIdCustomer(Convert.ToInt32((CBCustomer.SelectedItem as dynamic).Value));
                    lafacture.SetDateInvoice(lafacture.GetDateInvoice());
                    lafacture.Create();

                    if (lafacture.GetId() != 0)
                    {
                        FormInvoiceLineCreate CreateInvoiceLine = new FormInvoiceLineCreate(lafacture.GetId());
                        CreateInvoiceLine.ShowDialog();
                        LeRefresh(lafacture.GetId());
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous devez d'abord sélectionner un client.");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Customer selectedCustomer = (CBCustomer.SelectedItem as dynamic).Value as Customer;
            
            int IDSelectedCustomer = (CBCustomer.SelectedItem as dynamic).Value;



            List<Customer> TheClientList = custRepository.findAll();

            
            foreach (Customer TheClient in TheClientList)
            {
 

                if (TheClient.GetId() == IDSelectedCustomer)
                {
                    TxtName.Text = TheClient.GetName();
                    TxtSurname.Text = TheClient.GetLastname();
                    TxtCompagnyName.Text = TheClient.GetCompanyName();
                }

            }

 

            /*if (selectedCustomer != null) { 
            MessageBox.Show(selectedCustomer.GetName());       
            TxtName.Text = selectedCustomer.GetName();
            TxtSurname.Text = selectedCustomer.GetLastname();
            TxtCompagnyName.Text = selectedCustomer.GetCompanyName();
            }
           */


                
            
        }
    }
}
