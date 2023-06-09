using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionClasse.Views
{
    public partial class FormListClasse : Form
    {
        private CtrlClasse claRepository;
        private CtrlProfesseur ControllerProfesseur;

        public FormListClasse()
        {
            InitializeComponent();
            claRepository = new CtrlClasse();
            ControllerProfesseur = new CtrlProfesseur();
        }

        private void FormListClasse_Load(object sender, EventArgs e)
        {
            // Charger les données des classes dans le DataGridView
            List<ClsClasse> classes = claRepository.GetAllClasses();
            LoadClassesDataGridView(classes);
        }

        private void LoadClassesDataGridView(List<ClsClasse> classes)
        {
            DgvClasse.Rows.Clear();

            foreach (ClsClasse classe in classes)
            {
                ClsProfesseur professeurPrincipal = ControllerProfesseur.Find(classe.GetIdProfPrincipale());
                string nomPrenomProfesseurPrincipal = professeurPrincipal != null ? $"{professeurPrincipal.GetPrenom()} {professeurPrincipal.GetNom()}" : "";

                DgvClasse.Rows.Add(classe.GetIdClasse(), classe.GetLabel(), nomPrenomProfesseurPrincipal, "Voir");
            }
        }

        private void DgvClasse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si le bouton ColBtnEleve a été cliqué
            if (e.ColumnIndex == ColBtnEleve.Index && e.RowIndex >= 0)
            {
                // Récupérer l'ID de la classe sélectionnée
                int idClasse = Convert.ToInt32(DgvClasse.Rows[e.RowIndex].Cells[ColId.Index].Value);

                // Afficher FormClasseDetail avec l'ID de la classe en paramètre
                FormClasseDetail formClasseDetail = new FormClasseDetail(idClasse);
                formClasseDetail.ShowDialog();
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            // Code pour retourner à la fenêtre précédente
            this.Close();
        }
    }
}
