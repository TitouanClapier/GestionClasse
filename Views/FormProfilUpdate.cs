using AutoFact2.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact2.Views
{
    public partial class FormProfilUpdate : Form
    {
        public ProfilController profilController;
        public FormProfilUpdate(int id)
        {
            InitializeComponent();
            profilController = new ProfilController();

            foreach (var unProfil in profilController.findAll())
            {
                if (unProfil.GetId() == id)
                {
                    txtRaisonSocial.Text = unProfil.GetSocialReason();
                    txtSiren.Text = unProfil.GetSiren().ToString();
                    txtAdresse.Text = unProfil.GetAdress();
                    txtCP.Text = unProfil.GetPostalCode().ToString();
                    txtVille.Text = unProfil.GetCity();
                    txtTel.Text = unProfil.GetTel();
                    txtEmail.Text = unProfil.GetMail();
                }
            }
        }

        private void FormProfilUpdate_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            int id = 1;
            string socialReason = txtRaisonSocial.Text;
            int siren = Convert.ToInt32(txtSiren.Text);
            string adress = txtAdresse.Text;
            int postalCode = Convert.ToInt32(txtCP.Text);
            string city = txtVille.Text;
            string tel = txtTel.Text;
            string mail = txtEmail.Text;

            profilController.update(id, socialReason, siren, adress, postalCode, city, tel, mail);
            MessageBox.Show("Le profil a bien été modifié dans la base de données.");
            this.Close();
        }
    }
}
