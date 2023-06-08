using GestionClasse.Models;
using GestionClasse.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionClasse.Views
{
    public partial class FormListClasse : Form
    {
        private ClasseRepository claRepository;
        private ProfesseurRepository profRepository;

        public FormListClasse()
        {
            InitializeComponent();
            claRepository = new ClasseRepository();
            profRepository = new ProfesseurRepository();
        }

        private void FormListClasse_Load(object sender, EventArgs e)
        {
            // Charger les données des classes dans le DataGridView
            List<Classe> classes = claRepository.FindAll();
            LoadClassesDataGridView(classes);
        }

        private void LoadClassesDataGridView(List<Classe> classes)
        {
            DgvClasse.Rows.Clear();

            foreach (Classe classe in classes)
            {
                Professeur professeurPrincipal = profRepository.Find(classe.GetIdProfPrincipale());
                string nomPrenomProfesseurPrincipal = professeurPrincipal != null ? $"{professeurPrincipal.GetNom()} {professeurPrincipal.GetPrenom()}" : "";

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
