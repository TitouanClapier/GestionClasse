using AutoFact2.Controllers;
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
    public partial class FormProductList : Form
    {
        public ProductController productController;
        public FormProductList()
        {
            InitializeComponent();
            productController = new ProductController();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FormProductCreate ProductCreate = new FormProductCreate();
            ProductCreate.ShowDialog();
            DgvProduct.Refresh();
            GetData();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            this.DgvProduct.Rows.Clear();

            foreach (var unProduit in productController.FindAll())
            {
                string dgvId = unProduit.GetId().ToString();
                string dgvLibel = unProduit.GetLabel();
                string dgvUnitPrice = unProduit.GetUnitPrice().ToString();
                string dgvIdCategory = unProduit.GetIdCategory().ToString();
                this.DgvProduct.Rows.Add(dgvId, dgvLibel, dgvUnitPrice, dgvIdCategory, "Modifier", "Supprimer");
            }
        }

        private void DgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvProduct.Columns[e.ColumnIndex].Name == "ColBtnUpdate")
            {
                int id = Convert.ToInt32(DgvProduct.Rows[e.RowIndex].Cells["ColId"].Value);
                FormProductUpdate ProductUpdate = new FormProductUpdate(id);
                ProductUpdate.ShowDialog();
                //MessageBox.Show("sortis boite.");
                DgvProduct.Refresh();
                GetData();
            }

            if (this.DgvProduct.Columns[e.ColumnIndex].Name == "ColBtnDelete")
            {

                // Récupérez la valeur de l'ID de la ligne correspondante
                int id = Convert.ToInt32(DgvProduct.Rows[e.RowIndex].Cells["ColId"].Value);

                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet enregistrement ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Vérifier si l'utilisateur a cliqué sur le bouton Oui
                if (result == DialogResult.Yes)
                {
                    // Appeler la fonction de suppression avec l'ID récupéré
                    productController.delete(id);
                    GetData();
                }

            }
        }
    }
}
