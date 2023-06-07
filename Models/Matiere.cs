using System;

namespace GestionClasse.Views
{
    public class Matiere
    {
        public int IdMatiere { get; set; }
        public string Nom { get; set; }
        public int IdProf { get; set; }

        public Matiere()
        {

        }

        public Matiere(int idMatiere, string nom, int idProf)
        {
            IdMatiere = idMatiere;
            Nom = nom;
            IdProf = idProf;
        }

        public int GetIdMatiere()
        {
            return IdMatiere;
        }

        public void SetIdMatiere(int idMatiere)
        {
            IdMatiere = idMatiere;
        }

        public string GetNom()
        {
            return Nom;
        }

        public void SetNom(string nom)
        {
            Nom = nom;
        }

        public int GetIdProf()
        {
            return IdProf;
        }

        public void SetIdProf(int idProf)
        {
            IdProf = idProf;
        }
    }
}
