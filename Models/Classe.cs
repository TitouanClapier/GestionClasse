using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasse.Views
{
    public class Classe
    {
        private int _idClasse;
        private string _label;
        private int _idProfPrincipale;

        public Classe(int idClasse, string label, int idProfPrincipale)
        {
            _idClasse = idClasse;
            _label = label;
            _idProfPrincipale = idProfPrincipale;
        }

        public int GetIdClasse()
        {
            return _idClasse;
        }

        public void SetIdClasse(int value)
        {
            _idClasse = value;
        }

        public string GetLabel()
        {
            return _label;
        }

        public void SetLabel(string value)
        {
            _label = value;
        }

        public int GetIdProfPrincipale()
        {
            return _idProfPrincipale;
        }

        public void SetIdProfPrincipale(int value)
        {
            _idProfPrincipale = value;
        }
    }

}
