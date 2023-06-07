using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasse.Models
{

    public class Eleve
    {
        private int _idEleve;
        private string _nom;
        private string _prenom;
        private string _sexe;

        public Eleve(int idEleve, string nom, string prenom, string sexe)
        {
            _idEleve = idEleve;
            _nom = nom;
            _prenom = prenom;
            _sexe = sexe;
        }

        public int GetIdEleve()
        {
            return _idEleve;
        }

        public void SetIdEleve(int value)
        {
            _idEleve = value;
        }

        public string GetNom()
        {
            return _nom;
        }

        public void SetNom(string value)
        {
            _nom = value;
        }

        public string GetPrenom()
        {
            return _prenom;
        }

        public void SetPrenom(string value)
        {
            _prenom = value;
        }

        public string GetSexe()
        {
            return _sexe;
        }

        public void SetSexe(string value)
        {
            _sexe = value;
        }
    }
}
