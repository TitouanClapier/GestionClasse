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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutoFact2.Views
{
    public partial class FormClientCreate : Form
    {
        public CustomerController customerController;
        public FormClientCreate()
        {
            InitializeComponent();
            customerController = new CustomerController();
            TxtMail.TextChanged += TxtMail_TextChanged;
            TxtPostalCode.TextChanged += TxtPostalCode_TextChanged;
            TxtTel.TextChanged += TxtTel_TextChanged;
            TxtSurname.TextChanged += TxtSurname_TextChanged;
            TxtName.TextChanged += TxtName_TextChanged;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            string name = TxtName.Text;
            string lastName = TxtSurname.Text;
            string companyName = TxtCompanyname.Text;
            string address = TxtAdresse.Text;
            string postalCode = TxtPostalCode.Text;
            string city = TxtCity.Text;
            string mail = TxtMail.Text;
            string tel = TxtTel.Text;

            string namePattern = @"^[a-zA-Z]+$";
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string telPattern = @"^(0|\+33)\d{9}$";
            string postalCodePattern = @"^\d{5}$";
            string surnamePattern = @"^[a-zA-Z]+$";

            bool isValid = true;
            string errorMessage = "";

            if (!Regex.IsMatch(name, namePattern))
            {
                isValid = false;
                errorMessage += "Le nom est invalide. Il ne doit contenir que des lettres.\n";
            }

            if (!Regex.IsMatch(mail, emailPattern))
            {
                isValid = false;
                errorMessage += "L'email est invalide. Veuillez saisir une adresse email valide.\n";
            }

            if (!Regex.IsMatch(tel, telPattern))
            {
                isValid = false;
                errorMessage += "Le numéro de téléphone est invalide. Veuillez saisir un numéro de téléphone valide.\n";
            }

            if (!Regex.IsMatch(postalCode, postalCodePattern))
            {
                isValid = false;
                errorMessage += "Le code postal est invalide. Veuillez saisir un code postal valide (5 chiffres).\n";
            }

            if (!Regex.IsMatch(lastName, surnamePattern))
            {
                isValid = false;
                errorMessage += "Le nom de famille est invalide. Il ne doit contenir que des lettres.\n";
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Erreurs de validation");
                return;
            }

            if (isValid)
            {
                customerController.create(name, lastName, companyName, address, Convert.ToInt32(postalCode), city, mail, tel);

                MessageBox.Show("Le client a bien été ajouté à la base de données.");

                ResetTextBoxes();
                this.Close();
            }


            
        }
        private void ResetTextBoxes()
        {
            TxtName.Text = string.Empty;
            TxtSurname.Text = string.Empty;
            TxtCompanyname.Text = string.Empty;
            TxtAdresse.Text = string.Empty;
            TxtPostalCode.Text = string.Empty;
            TxtCity.Text = string.Empty;
            TxtMail.Text = string.Empty;
            TxtTel.Text = string.Empty;
        }

        private void TxtMail_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string email = textBox.Text.Trim();

            // Expression régulière pour valider le format de l'adresse e-mail
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValidEmail = Regex.IsMatch(email, emailPattern);

            if (isValidEmail)
            {
                // L'adresse e-mail est valide
                textBox.ForeColor = Color.Black;
            }
            else
            {
                // L'adresse e-mail est invalide
                textBox.ForeColor = Color.Red;
            }
        }

        private void TxtPostalCode_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string postalCode = textBox.Text.Trim();

            // Expression régulière pour valider le format du code postal (exemple pour la France)
            string postalCodePattern = @"^\d{5}$";
            bool isValidPostalCode = Regex.IsMatch(postalCode, postalCodePattern);

            if (isValidPostalCode)
            {
                // Le code postal est valide
                textBox.ForeColor = Color.Black;
            }
            else
            {
                // Le code postal est invalide
                textBox.ForeColor = Color.Red;
            }
        }
        private void TxtTel_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string tel = textBox.Text.Trim();

            // Expression régulière pour valider le format du numéro de téléphone (exemple pour les numéros français)
            string telPattern = @"^(0|\+33)\d{9}$";
            bool isValidTel = Regex.IsMatch(tel, telPattern);

            if (isValidTel)
            {
                // Le numéro de téléphone est valide
                textBox.ForeColor = Color.Black;
            }
            else
            {
                // Le numéro de téléphone est invalide
                textBox.ForeColor = Color.Red;
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string tel = textBox.Text.Trim();

            // Expression régulière pour valider le format du numéro de téléphone (exemple pour les numéros français)
            string namePattern = @"^[a-zA-Z]+$";
            bool isValidTel = Regex.IsMatch(tel, namePattern);

            if (isValidTel)
            {
                // Le numéro de téléphone est valide
                textBox.ForeColor = Color.Black;
            }
            else
            {
                // Le numéro de téléphone est invalide
                textBox.ForeColor = Color.Red;
            }
        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string tel = textBox.Text.Trim();

            // Expression régulière pour valider le format du numéro de téléphone (exemple pour les numéros français)
            string surnamePattern = @"^[a-zA-Z]+$";
            bool isValidTel = Regex.IsMatch(tel, surnamePattern);

            if (isValidTel)
            {
                // Le numéro de téléphone est valide
                textBox.ForeColor = Color.Black;
            }
            else
            {
                // Le numéro de téléphone est invalide
                textBox.ForeColor = Color.Red;
            }
        }

    }
}
