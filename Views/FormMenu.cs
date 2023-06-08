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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BtnClasse_Click(object sender, EventArgs e)
        {
            FormListClasse ClasseList = new FormListClasse();
            ClasseList.Show();
        }

        private void BtnEleve_Click(object sender, EventArgs e)
        {
            FormListEleve EleveList = new FormListEleve();
            EleveList.Show();
        }

        private void BtnProf_Click(object sender, EventArgs e)
        {
            FormListProf ProfList = new FormListProf();
            ProfList.Show();
        }

        private void BtnMatiere_Click(object sender, EventArgs e)
        {
            FormListMatiere MatiereList = new FormListMatiere();
            MatiereList.Show();
        }
    }
}
