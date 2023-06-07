using System;

namespace GestionClasse.Models
{
    public class Matiere
    {
        private int _idMatiere;
        private string _nom;
        private int _idProf;

        public Matiere()
        {

        }

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

        public void SetIdMatiere(int idMatiere)
        {
            _idMatiere = idMatiere;
        }

        public string GetNom()
        {
            return _nom;
        }

        public void SetNom(string nom)
        {
            _nom = nom;
        }

        public int GetIdProf()
        {
            return _idProf;
        }

        public void SetIdProf(int idProf)
        {
            _idProf = idProf;
        }
    }
}
