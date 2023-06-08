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

        private EleveController matController;

        public FormListEleve()
        {
            InitializeComponent();
            matController = new EleveController();

        }

        private void FormListEleve_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("test Load");
            // Charger les données des eleves dans le DataGridView
            List<Eleve> eleves = matController.GetAllEleves();
            LoadElevesDataGridView(eleves);

        }

        private void LoadElevesDataGridView(List<Eleve> eleves)
        {
            DgvEleve.Rows.Clear();

            foreach (Eleve eleve in eleves)
            {
                DgvEleve.Rows.Add(eleve.GetId(), eleve.GetNom(), eleve.GetPrenom(), eleve.GetSexe(), "Voir");
            }
        }


        private void BtnRetour_Click(object sender, EventArgs e)
        {
            // Code pour retourner à la fenêtre précédente
            this.Close();
        }

        private void DgvEleve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
