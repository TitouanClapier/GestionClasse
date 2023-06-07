using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace GestionClasse.Models
{
    public class Note
    {
        private int _idNote;
        private int _valeur;
        private int _idEleve;
        private int _idMatiere;

        public Note(int idNote, int valeur, int idEleve, int idMatiere)
        {
            _idNote = idNote;
            _valeur = valeur;
            _idEleve = idEleve;
            _idMatiere = idMatiere;
        }

        public int IdNote
        {
            get { return _idNote; }
            set { _idNote = value; }
        }

        public int Valeur
        {
            get { return _valeur; }
            set { _valeur = value; }
        }

        public int IdEleve
        {
            get { return _idEleve; }
            set { _idEleve = value; }
        }

        public int IdMatiere
        {
            get { return _idMatiere; }
            set { _idMatiere = value; }
        }
    }
}
