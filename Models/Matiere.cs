using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasse.Views
{
    public class Matiere
    {
        private int _idMatiere;
        private string _nom;
        private int _idProf;

        public Matiere(int idMatiere, string nom, int idProf)
        {
            _idMatiere = idMatiere;
            _nom = nom;
            _idProf = idProf;
        }

        public int GetIdMatiere()
        {
            return _idMatiere;
        }

        public void SetIdMatiere(int value)
        {
            _idMatiere = value;
        }

        public string GetNom()
        {
            return _nom;
        }

        public void SetNom(string value)
        {
            _nom = value;
        }

        public int GetIdProf()
        {
            return _idProf;
        }

        public void SetIdProf(int value)
        {
            _idProf = value;
        }
    }

}
