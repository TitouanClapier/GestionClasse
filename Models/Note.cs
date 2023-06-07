using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasse.Views
{
    public class Note
    {
        private int _idNote;
        private double _valeur;
        private int _idEleve;
        private int _idMatiere;

        public Note(int idNote, double valeur, int idEleve, int idMatiere)
        {
            _idNote = idNote;
            _valeur = valeur;
            _idEleve = idEleve;
            _idMatiere = idMatiere;
        }

        public int GetIdNote()
        {
            return _idNote;
        }

        public void SetIdNote(int value)
        {
            _idNote = value;
        }

        public double GetValeur()
        {
            return _valeur;
        }

        public void SetValeur(double value)
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
