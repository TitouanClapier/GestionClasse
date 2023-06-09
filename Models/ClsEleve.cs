using System;

namespace GestionClasse.Models
{
    public class ClsEleve
    {
        private int _idEleve;
        private string _nom;
        private string _prenom;
        private string _sexe;
        private int _idClasse;

        public ClsEleve(int idEleve, string nom, string prenom, string sexe, int idClasse)
        {
            _idEleve = idEleve;
            _nom = nom;
            _prenom = prenom;
            _sexe = sexe;
            _idClasse = idClasse;
        }

        public int GetId()
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

        public int GetIdClasse()
        {
            return _idClasse;
        }

        public void SetIdClasse(int value)
        {
            _idClasse = value;
        }
    }
}
