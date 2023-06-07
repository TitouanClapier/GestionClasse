using AutoFact2.Controllers;
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
    public partial class FormClientList : Form
    {
        public CustomerController cuController;
        public FormClientList()
        {
            InitializeComponent();
            cuController = new CustomerController();
        }

        public static int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvClient.Columns[e.ColumnIndex].Name == "ColBtnUpdate")
            {
                int id = Convert.ToInt32(DgvClient.Rows[e.RowIndex].Cells["ColId"].Value);
                FormClientUpdate ClientUpdate = new FormClientUpdate(id);
                ClientUpdate.ShowDialog();
                //MessageBox.Show("sortis boite.");
                DgvClient.Refresh();
                LeRefresh();


            }

            if (this.DgvClient.Columns[e.ColumnIndex].Name == "ColBtnDelete")
            {

                // Récupérez la valeur de l'ID de la ligne correspondante
                int id = Convert.ToInt32(DgvClient.Rows[e.RowIndex].Cells["ColId"].Value);

                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet enregistrement ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Vérifier si l'utilisateur a cliqué sur le bouton Oui
                if (result == DialogResult.Yes)
                {
                    // Appeler la fonction de suppression avec l'ID récupéré
                    cuController.delete(id);
                    LeRefresh();
                }

            } 
        }

        private void BtnCreateClient_Click(object sender, EventArgs e)
        {
            FormClientCreate ClientCreate = new FormClientCreate();
            ClientCreate.ShowDialog();
            LeRefresh();
            DialogResult result = MessageBox.Show("Voulez vous crée un nouveaux client ?", "Confirmation de l'enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool leresult = false;
            // Vérifier si l'utilisateur a cliqué sur le bouton Oui
            if (result == DialogResult.Yes)
            {
                leresult = true;
                
                while (leresult == true)
                {
                    leresult = LeCreate();
                }
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClientList_Load(object sender, EventArgs e)
        {
            LeRefresh();
        }

        //Fonction de rafraichissement du datagriedview.
        public void LeRefresh()
        {
            this.DgvClient.Rows.Clear();
            foreach (var unClient in cuController.findAll())
            {
                string dgvId = unClient.GetId().ToString();
                string dgvName = unClient.GetName();
                string dgvLastName = unClient.GetLastname();
                string dgvCompanyName = unClient.GetCompanyName();
                string dgvAdress = unClient.GetAdress();
                string dgvPostalCode = unClient.GetPostalCode().ToString();
                string dgvCity = unClient.GetCity();
                string dgvMail = unClient.GetMail();
                string dgvTel = unClient.GetTel();
                this.DgvClient.Rows.Add(dgvId, dgvName, dgvLastName, dgvCompanyName, dgvAdress, dgvPostalCode, dgvCity, dgvMail, dgvTel, "Modifier", "Supprimer");
            }
        }

        public bool LeCreate()
        {
            FormClientCreate ClientCreate = new FormClientCreate();
            ClientCreate.ShowDialog();
            LeRefresh();
            DialogResult result = MessageBox.Show("Voulez vous crée un nouveaux client ?", "Confirmation de l'enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
