using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionClasse.Controllers;
using GestionClasse.Models;

namespace GestionClasse.Views
{
    public partial class FormClasseDetail : Form
    {
        private ClasseController claController;
        private EleveController elController;
        private ProfesseurController profController; // Ajout du ProfesseurController
        private int classeId;

        public FormClasseDetail(int id)
        {
            InitializeComponent();
            claController = new ClasseController();
            elController = new EleveController();
            profController = new ProfesseurController(); // Initialisation du ProfesseurController
            classeId = id;
        }

        private void FormClassDetail_Load(object sender, EventArgs e)
        {
            Classe classe = claController.GetClasseById(classeId);
            if (classe != null)
            {
                TxtLabel.Text = classe.GetLabel();
                Professeur profPrincipal = profController.GetProfesseurById(classe.GetIdProfPrincipale()); // Utilisation du ProfesseurController
                if (profPrincipal != null)
                {
                    TxtProf.Text = profPrincipal.GetNom() + " " + profPrincipal.GetPrenom();
                }
            }

            LoadElevesDataGridView();
            LoadElevesComboBox();
        }

        private void LoadElevesDataGridView()
        {
            List<Eleve> eleves = elController.GetElevesByClasse(classeId);
            DgvEleve.Rows.Clear();

            foreach (Eleve eleve in eleves)
            {
                DgvEleve.Rows.Add(eleve.GetId(), eleve.GetNom(), eleve.GetPrenom(), eleve.GetSexe());
            }
        }

        private void LoadElevesComboBox()
        {
            List<Eleve> eleves = elController.GetElevesByClasse(classeId);
            CbEleve.DataSource = eleves;
            CbEleve.DisplayMember = "Nom";
            CbEleve.ValueMember = "Id";
        }

        private void CbEleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            Eleve selectedEleve = (Eleve)CbEleve.SelectedItem;
            if (selectedEleve != null)
            {
                TxtNom.Text = selectedEleve.GetNom();
                TxtPrenom.Text = selectedEleve.GetPrenom();
                TxtSexe.Text = selectedEleve.GetSexe();
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Ajouter le code pour ajouter un nouvel élève à la classe
        }
    }
}
