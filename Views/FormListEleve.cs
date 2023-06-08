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
    public partial class FormListEleve : Form
    {
        private EleveController eleveController;
        private ClasseController classeController;

        public FormListEleve()
        {
            InitializeComponent();
            eleveController = new EleveController();
            classeController = new ClasseController();
        }

        private void FormListEleve_Load(object sender, EventArgs e)
        {
            List<Eleve> eleves = eleveController.GetAllEleves();
            LoadElevesDataGridView(eleves);
        }

        private void LoadElevesDataGridView(List<Eleve> eleves)
        {
            DgvEleve.Rows.Clear();

            foreach (Eleve eleve in eleves)
            {
                Classe classe = classeController.GetClasseById(eleve.GetIdClasse());
                DgvEleve.Rows.Add(eleve.GetId(), eleve.GetNom(), eleve.GetPrenom(), eleve.GetSexe(), classe.GetLabel(), "Voir", "Notes");
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvEleve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int eleveId = Convert.ToInt32(DgvEleve.Rows[e.RowIndex].Cells["ColId"].Value);
                Eleve eleve = eleveController.GetEleveById(eleveId);

                if (eleve != null)
                {
                    if (e.ColumnIndex == DgvEleve.Columns["ColClasse"].Index)
                    {
                        Classe classe = classeController.GetClasseById(eleve.GetIdClasse());
                        MessageBox.Show($"Nom : {eleve.GetNom()}\nPrénom : {eleve.GetPrenom()}\nSexe : {eleve.GetSexe()}\nClasse : {classe.GetLabel()}", "Détails de l'élève");
                    }
                    else if (e.ColumnIndex == DgvEleve.Columns["ColBtnNote"].Index)
                    {
                        FormListNote formListNote = new FormListNote(eleveId);
                        formListNote.ShowDialog();
                    }
                }
            }
        }
    }
}
