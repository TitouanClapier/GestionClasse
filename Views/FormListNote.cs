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
using GestionClasse.Repository;

namespace GestionClasse.Views
{
    public partial class FormListNote : Form
    {
        private EleveController elController;
        private NoteController noController;
        private ClasseController claController;
        private MatiereController matController;
        private NoteRepository noteRepository;
        private int eleveId;

        public FormListNote(int id)
        {
            InitializeComponent();
            elController = new EleveController();
            noController = new NoteController();
            claController = new ClasseController();
            matController = new MatiereController();
            noteRepository = new NoteRepository();
            eleveId = id;
        }

        private void FormListNote_Load(object sender, EventArgs e)
        {
            LoadElevesComboBox(); // Charger la ComboBox des élèves
            LoadMatiereComboBox(); // Charger la ComboBox des matières

            Eleve eleve = elController.GetEleveById(eleveId);
            if (eleve != null)
            {
                CbEleve.SelectedItem = eleve; // Sélectionner l'élève dans la ComboBox
                UpdateEleveInformation(eleve); // Mettre à jour les informations de l'élève
            }

            List<Note> notes = noteRepository.Find(eleveId);
            LoadNotesDataGridView(notes);
        }

        private void LoadElevesComboBox()
        {
            List<Eleve> eleves = elController.GetAllEleves();
            CbEleve.DataSource = eleves;
            CbEleve.DisplayMember = "Nom";
            CbEleve.ValueMember = "Id";
        }

        private void LoadMatiereComboBox()
        {
            List<Matiere> matieres = matController.GetAllMatieres();
            CbMatiere.DataSource = matieres;
            CbMatiere.DisplayMember = "Nom";
            CbMatiere.ValueMember = "Id";
        }

        private void UpdateEleveInformation(Eleve eleve)
        {
            TxtNom.Text = eleve.GetNom();
            TxtPrenom.Text = eleve.GetPrenom();
            TxtSexe.Text = eleve.GetSexe();
            Classe classe = claController.GetClasseById(eleve.GetIdClasse());
            TxtClasse.Text = classe.GetLabel();
        }

        private void LoadNotesDataGridView(List<Note> notes)
        {
            DgvNote.Rows.Clear();

            foreach (Note note in notes)
            {
                Matiere matiere = matController.GetMatiere(note.GetIdMatiere());
                DgvNote.Rows.Add(note.GetId(), matiere.GetNom(), note.GetValeur(), "Modifier", "Supprimer");
            }
        }

        private void CbEleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            Eleve selectedEleve = (Eleve)CbEleve.SelectedItem;
            if (selectedEleve != null)
            {
                eleveId = selectedEleve.GetId();
                UpdateEleveInformation(selectedEleve);

                List<Note> notes = noteRepository.Find(eleveId);
                LoadNotesDataGridView(notes);
            }
        }

        private void DgvNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DgvNote.Columns["ColBtnUpdate"].Index)
            {
                // Code pour la mise à jour de la note
                int noteId = (int)DgvNote.Rows[e.RowIndex].Cells["ColNoteId"].Value;
                Matiere matiere = (Matiere)CbMatiere.SelectedItem;
                int valeur = int.Parse(DgvNote.Rows[e.RowIndex].Cells["ColValeur"].Value.ToString());

                // Mettre à jour la note avec les nouvelles informations
                noteRepository.Update(noteId, valeur, eleveId, matiere.GetId());

                // Recharger les notes dans le DataGridView
                List<Note> notes = noteRepository.Find(eleveId);
                LoadNotesDataGridView(notes);
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == DgvNote.Columns["ColBtnDelete"].Index)
            {
                // Code pour la suppression de la note
                int noteId = (int)DgvNote.Rows[e.RowIndex].Cells["ColNoteId"].Value;

                // Supprimer la note de la base de données
                noteRepository.Delete(noteId);

                // Recharger les notes dans le DataGridView
                List<Note> notes = noteRepository.Find(eleveId);
                LoadNotesDataGridView(notes);
            }
        }

        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            Matiere matiere = (Matiere)CbMatiere.SelectedItem;
            int valeur = int.Parse(TxtValeur.Text);

            // Ajouter la nouvelle note à la base de données
            noteRepository.Create(valeur, eleveId, matiere.GetId());

            // Recharger les notes dans le DataGridView
            List<Note> notes = noteRepository.Find(eleveId);
            LoadNotesDataGridView(notes);
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
