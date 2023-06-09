using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasse.Models
{
    public class ClsNote
    {
        private int _idNote;
        private int _valeur;
        private int _idEleve;
        private int _idMatiere;

        public ClsNote(int idNote, int valeur, int idEleve, int idMatiere)
        {
            _idNote = idNote;
            _valeur = valeur;
            _idEleve = idEleve;
            _idMatiere = idMatiere;
        }

        public int GetId()
        {
            return _idNote;
        }

        public void SetIdNote(int value)
        {
            _idNote = value;
        }

        public int GetValeur()
        {
            return _valeur;
        }

        public void SetValeur(int value)
        {
            _valeur = value;
        }

        public int GetIdEleve()
        {
            return _idEleve;
        }

        public void SetIdEleve(int value)
        {
            _idEleve = value;
        }

        public int GetIdMatiere()
        {
            return _idMatiere;
        }

        public void SetIdMatiere(int value)
        {
            _idMatiere = value;
        }
    }
}
