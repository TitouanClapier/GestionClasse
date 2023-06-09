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
    public partial class FormClasseDetail : Form
    {
        private CtrlClasse ControllerClasse;
        private CtrlEleve ControllerEleve;
        private CtrlProfesseur ControllerProfesseur;
        private int classeId;

        public FormClasseDetail(int id)
        {
            InitializeComponent();
            ControllerClasse = new CtrlClasse();
            ControllerEleve = new CtrlEleve();
            ControllerProfesseur = new CtrlProfesseur();
            classeId = id;
        }

        private void FormClassDetail_Load(object sender, EventArgs e)
        {
            ClsClasse classe = ControllerClasse.GetClasseById(classeId);
            if (classe != null)
            {
                TxtLabel.Text = classe.GetLabel();
                ClsProfesseur profPrincipal = ControllerProfesseur.GetProfesseurById(classe.GetIdProfPrincipale());
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
            List<ClsEleve> eleves = ControllerEleve.GetElevesByClasse(classeId);
            DgvEleve.Rows.Clear();

            foreach (ClsEleve eleve in eleves)
            {
                DgvEleve.Rows.Add(eleve.GetId(), eleve.GetNom(), eleve.GetPrenom(), eleve.GetSexe());
            }
        }

        private void LoadElevesComboBox()
        {
            List<ClsEleve> eleves = ControllerEleve.GetAllEleves();
            CbEleve.DisplayMember = "Text";
            CbEleve.ValueMember = "Value";

            foreach (ClsEleve eleve in eleves)
            {
                CbEleve.Items.Add(new { Text = eleve.GetPrenom() + " " + eleve.GetNom(), Value = eleve.GetId() });
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
                    TxtNom.Text = unEleve.GetNom();
                    TxtPrenom.Text = unEleve.GetPrenom();
                    TxtSexe.Text = unEleve.GetSexe();
                }
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int idEleve = (CbEleve.SelectedItem as dynamic).Value;
            ClsEleve eleve = ControllerEleve.GetEleveById(idEleve);

            if (eleve != null)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir ajouter cet élève à la classe ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    eleve.SetIdClasse(classeId);
                    ControllerEleve.UpdateEleve(eleve.GetId(), eleve.GetNom(), eleve.GetPrenom(), eleve.GetSexe(), classeId);
                    MessageBox.Show("L'élève a été ajouté à la classe avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadElevesDataGridView();
                }
            }
        }
    }
}
