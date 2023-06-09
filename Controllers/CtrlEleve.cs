using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class CtrlEleve
    {
        private RepoEleve RepositoryEleve;

        public CtrlEleve()
        {
            RepositoryEleve = new RepoEleve();
        }

        public List<ClsEleve> GetAllEleves()
        {
            return RepositoryEleve.FindAll();
        }

        public ClsEleve GetEleveById(int id)
        {
            return RepositoryEleve.GetInfo(id);
        }

        public List<ClsEleve> GetElevesByClasse(int classeId)
        {
            return RepositoryEleve.GetElevesByClasse(classeId);
        }

        public void AddEleve(string nom, string prenom, string sexe, int idClasse)
        {
            RepositoryEleve.Create(nom, prenom, sexe, idClasse);
        }

        public void UpdateEleve(int id, string nom, string prenom, string sexe, int idClasse)
        {
            RepositoryEleve.Update(id, nom, prenom, sexe, idClasse);
        }

        public void DeleteEleve(int id)
        {
            RepositoryEleve.Delete(id);
        }

        public void UpdateClasse(int eleveId, int newClasseId)
        {
            ClsEleve eleve = RepositoryEleve.GetInfo(eleveId);
            if (eleve != null)
            {
                eleve.SetIdClasse(newClasseId);
                RepositoryEleve.Update(eleve.GetId(), eleve.GetNom(), eleve.GetPrenom(), eleve.GetSexe(), eleve.GetIdClasse());
            }
        }
    }
}
