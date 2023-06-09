using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionClasse.Views
{
    public partial class FormListProf : Form
    {
        private CtrlProfesseur profController;
        private RepoMatiere matiereRepository;

        public FormListProf()
        {
            InitializeComponent();
            profController = new CtrlProfesseur();
            matiereRepository = new RepoMatiere();
        }

        private void FormListProf_Load(object sender, EventArgs e)
        {
            // Charger les données des professeurs dans le DataGridView
            List<ClsProfesseur> professeurs = profController.GetAllProfesseurs();
            LoadProfesseursDataGridView(professeurs);
        }

        private void LoadProfesseursDataGridView(List<ClsProfesseur> professeurs)
        {
            DgvProf.Rows.Clear();

            foreach (ClsProfesseur professeur in professeurs)
            {
                // Récupérer la matière du professeur en utilisant son ID
                ClsMatiere matiere = matiereRepository.Find(professeur.GetId());

                DgvProf.Rows.Add(professeur.GetId(), professeur.GetNom(), professeur.GetPrenom(), professeur.GetSexe(), matiere != null ? matiere.GetNom() : "");
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            // Code pour retourner à la fenêtre précédente
            this.Close();
        }
    }
}
