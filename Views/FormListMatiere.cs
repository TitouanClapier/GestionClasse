using GestionClasse.Controllers;
using GestionClasse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClasse.Views
{
    public partial class FormListMatiere : Form
    {
        private MatiereController matController;
        private ProfesseurController profController;

        public FormListMatiere()
        {
            InitializeComponent();
            matController = new MatiereController();
            profController = new ProfesseurController();
        }

        private void FormListMatiere_Load(object sender, EventArgs e)
        {
            // Charger les données des matieres dans le DataGridView
            List<Matiere> matieres = matController.GetAllMatieres();
            LoadMatieresDataGridView(matieres);
        }

        private void LoadMatieresDataGridView(List<Matiere> matieres)
        {
            DgvMatiere.Rows.Clear();

            foreach (Matiere matiere in matieres)
            {
                //MessageBox.Show(Convert.ToString(matiere.GetIdProf()));
                Professeur professeur = profController.GetProfesseurById(matiere.GetIdProf());
                string prenomNomProfesseur = professeur != null ? $"{professeur.GetPrenom()} {professeur.GetNom()}" : "";

                DgvMatiere.Rows.Add(matiere.GetId(), matiere.GetNom(), prenomNomProfesseur);
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            // Code pour retourner à la fenêtre précédente
            this.Close();
        }
    }
}
