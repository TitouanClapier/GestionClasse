using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GestionClasse.Controllers;
using GestionClasse.Models;
using GestionClasse.Repository;

namespace GestionClasse.Views
{
    public partial class FormListNote : Form
    {
        private CtrlEleve ControllerEleve;
        private CtrlNote ControllerNote;
        private CtrlClasse ControllerClasse;
        private CtrlMatiere ControllerMatiere;
        //private CtrlNote ControllerNote;
        private int eleveId;

        public FormListNote(int id)
        {
            InitializeComponent();
            ControllerEleve = new CtrlEleve();
            ControllerNote = new CtrlNote();
            ControllerClasse = new CtrlClasse();
            ControllerMatiere = new CtrlMatiere();
            //ControllerNote = new CtrlNote();
            eleveId = id;
        }

        private void FormListNote_Load(object sender, EventArgs e)
        {
            LoadElevesComboBox(); // Charger la ComboBox des élèves
            LoadMatiereComboBox(); // Charger la ComboBox des matières

            ClsEleve eleve = ControllerEleve.GetEleveById(eleveId);
            if (eleve != null)
            {
                CbEleve.SelectedItem = eleve; // Sélectionner l'élève dans la ComboBox
                UpdateEleveInformation(eleve); // Mettre à jour les informations de l'élève
            }

            List<ClsNote> notes = ControllerNote.Find(eleveId);
            LoadNotesDataGridView(notes);
        }

        private void LoadElevesComboBox()
        {
            List<ClsEleve> eleves = ControllerEleve.GetAllEleves();
            CbEleve.DisplayMember = "Text";
            CbEleve.ValueMember = "Value";
            int i = 0;
            foreach (ClsEleve uneleve in eleves)
            {
                CbEleve.Items.Add(new { Text = uneleve.GetPrenom() + " " + uneleve.GetNom(), Value = uneleve.GetId() });
            }
        }

        private void LoadMatiereComboBox()
        {
            List<ClsMatiere> matieres = ControllerMatiere.GetAllMatieres();
            CbMatiere.DisplayMember = "Text";
            CbMatiere.ValueMember = "Value";
            int i = 0;
            foreach (ClsMatiere unematiere in matieres)
            {
                CbMatiere.Items.Add(new { Text = unematiere.GetNom(), Value = unematiere.GetId() });
            }
        }

        private void UpdateEleveInformation(ClsEleve eleve)
        {
            TxtNom.Text = eleve.GetNom();
            TxtPrenom.Text = eleve.GetPrenom();
            TxtSexe.Text = eleve.GetSexe();
            ClsClasse classe = ControllerClasse.GetClasseById(eleve.GetIdClasse());
            TxtClasse.Text = classe.GetLabel();
        }

        private void LoadNotesDataGridView(List<ClsNote> notes)
        {
            DgvNote.Rows.Clear();

            foreach (ClsNote note in notes)
            {
                ClsMatiere matiere = ControllerMatiere.GetMatiere(note.GetIdMatiere());
                DgvNote.Rows.Add(note.GetId(), matiere.GetNom(), note.GetValeur(), "Modifier", "Supprimer");
            }
        }

        private void CbEleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDSelectedEleve = (CbEleve.SelectedItem as dynamic).Value;

            List<ClsEleve> LaListEleve = ControllerEleve.GetAllEleves();
            foreach (ClsEleve unEleve in LaListEleve)
            {
                if (unEleve.GetId() == IDSelectedEleve)
                {
                    eleveId = unEleve.GetId();
                    UpdateEleveInformation(unEleve);

                    List<ClsNote> notes = ControllerNote.Find(eleveId);
                    LoadNotesDataGridView(notes);
                }
            }
        }

        private void DgvNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DgvNote.Columns["ColBtnUpdate"].Index)
            {
                int noteId = (int)DgvNote.Rows[e.RowIndex].Cells["ColId"].Value;

                // Ouvrir la forme FormNoteUpdate en tant que boîte de dialogue modale
                FormNoteUpdate formNoteUpdate = new FormNoteUpdate(noteId);
                formNoteUpdate.FormClosed += FormNoteUpdate_FormClosed; // Écouter l'événement de fermeture de la fenêtre de mise à jour
                formNoteUpdate.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == DgvNote.Columns["ColBtnDelete"].Index)
            {
                int noteId = (int)DgvNote.Rows[e.RowIndex].Cells["ColId"].Value;

                // Supprimer la note de la base de données
                ControllerNote.Delete(noteId);

                // Recharger les notes dans le DataGridView
                List<ClsNote> notes = ControllerNote.Find(eleveId);
                LoadNotesDataGridView(notes);
            }
        }

        private void FormNoteUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Recharger les notes dans le DataGridView après la fermeture de la fenêtre de mise à jour
            List<ClsNote> notes = ControllerNote.Find(eleveId);
            LoadNotesDataGridView(notes);
        }

        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            var matiere = (CbMatiere.SelectedItem as dynamic)?.Value;
            if (matiere == 0 || matiere == null)
            {
                MessageBox.Show("Veuillez sélectionner une matière.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string valeurText = TxtValeur.Text;
            int valeur;
            if (int.TryParse(valeurText, out valeur))
            {
                if (valeur >= 0 && valeur <= 20)
                {
                    ControllerNote.Create(valeur, eleveId, matiere);

                    List<ClsNote> notes = ControllerNote.Find(eleveId);
                    LoadNotesDataGridView(notes);
                }
                else
                {
                    MessageBox.Show("La valeur de la note doit être comprise entre 0 et 20.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La valeur de la note doit être un nombre entier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
