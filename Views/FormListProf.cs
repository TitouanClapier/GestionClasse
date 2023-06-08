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
        private ProfesseurController profController;
        private MatiereRepository matiereRepository;

        public FormListProf()
        {
            InitializeComponent();
            profController = new ProfesseurController();
            matiereRepository = new MatiereRepository();
        }

        private void FormListProf_Load(object sender, EventArgs e)
        {
            // Charger les données des professeurs dans le DataGridView
            List<Professeur> professeurs = profController.GetAllProfesseurs();
            LoadProfesseursDataGridView(professeurs);
        }

        private void LoadProfesseursDataGridView(List<Professeur> professeurs)
        {
            DgvProf.Rows.Clear();

            foreach (Professeur professeur in professeurs)
            {
                // Récupérer la matière du professeur en utilisant son ID
                Matiere matiere = matiereRepository.Find(professeur.GetId());

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
