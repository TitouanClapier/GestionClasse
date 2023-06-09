using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class CtrlClasse
    {
        private RepoClasse RepositoryClasse;

        public CtrlClasse()
        {
            RepositoryClasse = new RepoClasse();
        }

        public List<ClsClasse> GetAllClasses()
        {
            return RepositoryClasse.FindAll();
        }

        public ClsClasse GetClasseById(int id)
        {
            return RepositoryClasse.GetInfo(id);
        }

        public void AddClasse(string nom, int niveau)
        {
            RepositoryClasse.Create(nom, niveau);
        }

        public void UpdateClasse(int id, string nom, int niveau)
        {
            RepositoryClasse.Update(id, nom, niveau);
        }

        public void DeleteClasse(int id)
        {
            RepositoryClasse.Delete(id);
        }
    }
}
