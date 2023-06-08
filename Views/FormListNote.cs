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
    public partial class FormListNote : Form
    {
        private EleveController elController;
        private NoteController noController;
        private ClasseController claController;
        private MatiereController matController; // Ajout du contrôleur de Matière
        private int eleveId;

        public FormListNote(int id)
        {
            InitializeComponent();
            elController = new EleveController();
            noController = new NoteController();
            claController = new ClasseController();
            matController = new MatiereController(); // Initialisation du contrôleur de Matière
            eleveId = id;
        }

        private void FormListNote_Load(object sender, EventArgs e)
        {
            Eleve eleve = elController.GetEleveById(eleveId);
            if (eleve != null)
            {
                TxtNom.Text = eleve.GetNom();
                TxtPrenom.Text = eleve.GetPrenom();
                TxtSexe.Text = eleve.GetSexe();
                Classe classe = claController.GetClasseById(eleve.GetIdClasse());
                TxtClasse.Text = classe.GetLabel();
            }

            List<Note> notes = noController.Find(eleveId);
            LoadNotesDataGridView(notes);
        }

        private void LoadNotesDataGridView(List<Note> notes)
        {
            DgvNote.Rows.Clear();

            foreach (Note note in notes)
            {
                Matiere matiere = matController.GetMatiere(note.GetIdMatiere());
                DgvNote.Rows.Add(note.GetId(), matiere.GetNom(), note.GetValeur());
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
