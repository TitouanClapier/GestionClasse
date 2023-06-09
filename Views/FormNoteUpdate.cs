using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionClasse.Controllers;
using GestionClasse.Models;
using GestionClasse.Repository;

namespace GestionClasse.Views
{
    public partial class FormNoteUpdate : Form
    {
        private int noteId;
        private int eleveId;
        private CtrlNote ControllerNote;
        private CtrlMatiere ControllerMatiere;

        public FormNoteUpdate(int id)
        {
            InitializeComponent();

            noteId = id;
            ControllerNote = new CtrlNote();
            ControllerMatiere = new CtrlMatiere();

            // Charger les matières dans la ComboBox
            LoadMatiereComboBox();

            // Récupérer la note et la matière correspondante
            ClsNote note = ControllerNote.GetNoteById(noteId);
            ClsMatiere matiere = ControllerMatiere.GetMatiere(note.GetIdMatiere());

            // Trouver l'index de l'élément dans la ComboBox
            int index = CbMatiere.FindStringExact(matiere.GetNom());

            // Sélectionner l'élément dans la ComboBox
            if (index >= 0)
            {
                CbMatiere.SelectedIndex = index;
            }

            TxtValeur.Text = note.GetValeur().ToString();
        }

        private void FormNoteUpdate_Load(object sender, EventArgs e)
        {
            // Charger les informations de la note à partir de la base de données
            CtrlNote ControllerNote = new CtrlNote();
            ClsNote note = ControllerNote.GetNoteById(noteId);

            if (note != null)
            {
                // Remplir les champs du formulaire avec les informations de la note
                CbMatiere.SelectedItem = note.GetIdMatiere();
                TxtValeur.Text = note.GetValeur().ToString();
            }
        }

        private void LoadMatiereComboBox()
        {
            List<ClsMatiere> matieres = ControllerMatiere.GetAllMatieres();
            CbMatiere.DisplayMember = "Text";
            CbMatiere.ValueMember = "Value";
            foreach (ClsMatiere uneMatiere in matieres)
            {
                CbMatiere.Items.Add(new { Text = uneMatiere.GetNom(), Value = uneMatiere.GetId() });
            }
        }

        private void BtnUpdateNote_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("test");

            var matiere = (CbMatiere.SelectedItem as dynamic)?.Value;

            if (matiere == 0 || matiere == null)
            {
                MessageBox.Show("Veuillez sélectionner une matière.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int valeur;
            if (!int.TryParse(TxtValeur.Text, out valeur))
            {
                MessageBox.Show("Veuillez entrer une valeur numérique valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valeur < 0 || valeur > 20)
            {
                MessageBox.Show("La valeur doit être comprise entre 0 et 20.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClsNote existingNote = ControllerNote.GetNoteById(noteId);
            if (existingNote == null)
            {
                MessageBox.Show("La note spécifiée n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Note already exists, perform update
            int eleveId = existingNote.GetIdEleve(); // Récupérer l'identifiant de l'élève depuis l'objet Note
            ControllerNote.Update(noteId, valeur, eleveId, matiere);
            MessageBox.Show("Note mise à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }





        private void TxtValeur_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^([0-9]|1[0-9]|20)$";
            if (!Regex.IsMatch(TxtValeur.Text, pattern))
            {
                MessageBox.Show("Veuillez entrer une valeur entre 0 et 20.");
                e.Cancel = true;
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
