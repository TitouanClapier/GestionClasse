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
        private CtrlMatiere matController;
        private CtrlProfesseur profController;

        public FormListMatiere()
        {
            InitializeComponent();
            matController = new CtrlMatiere();
            profController = new CtrlProfesseur();
        }

        private void FormListMatiere_Load(object sender, EventArgs e)
        {
            // Charger les données des matieres dans le DataGridView
            List<ClsMatiere> matieres = matController.GetAllMatieres();
            LoadMatieresDataGridView(matieres);
        }

        private void LoadMatieresDataGridView(List<ClsMatiere> matieres)
        {
            DgvMatiere.Rows.Clear();

            foreach (ClsMatiere matiere in matieres)
            {
                //MessageBox.Show(Convert.ToString(matiere.GetIdProf()));
                ClsProfesseur professeur = profController.GetProfesseurById(matiere.GetIdProf());
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
