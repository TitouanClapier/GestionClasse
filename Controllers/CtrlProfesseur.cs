using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class CtrlProfesseur
    {
        private RepoProfesseur RepositoryProfesseur;

        public CtrlProfesseur()
        {
            RepositoryProfesseur = new RepoProfesseur();
        }

        public List<ClsProfesseur> GetAllProfesseurs()
        {
            //MessageBox.Show("test Controller");
            return RepositoryProfesseur.FindAll();
        }

        public ClsProfesseur GetProfesseurById(int id)
        {
            return RepositoryProfesseur.GetInfo(id);
        }

        public ClsProfesseur Find(int id)
        {
            return RepositoryProfesseur.Find(id);
        }

        public void AddProfesseur(string nom, string prenom, string matiere)
        {
            RepositoryProfesseur.Create(nom, prenom, matiere);
        }

        public void UpdateProfesseur(int id, string nom, string prenom, string matiere)
        {
            RepositoryProfesseur.Update(id, nom, prenom, matiere);
        }

        public void DeleteProfesseur(int id)
        {
            RepositoryProfesseur.Delete(id);
        }
    }
}
