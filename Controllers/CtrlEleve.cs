using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class CtrlEleve
    {
        private RepoEleve elRepository;

        public CtrlEleve()
        {
            elRepository = new RepoEleve();
        }

        public List<ClsEleve> GetAllEleves()
        {
            return elRepository.FindAll();
        }

        public ClsEleve GetEleveById(int id)
        {
            return elRepository.GetInfo(id);
        }

        public List<ClsEleve> GetElevesByClasse(int classeId)
        {
            return elRepository.GetElevesByClasse(classeId);
        }

        public void AddEleve(string nom, string prenom, string sexe, int idClasse)
        {
            elRepository.Create(nom, prenom, sexe, idClasse);
        }

        public void UpdateEleve(int id, string nom, string prenom, string sexe, int idClasse)
        {
            elRepository.Update(id, nom, prenom, sexe, idClasse);
        }

        public void DeleteEleve(int id)
        {
            elRepository.Delete(id);
        }

        public void UpdateClasse(int eleveId, int newClasseId)
        {
            ClsEleve eleve = elRepository.GetInfo(eleveId);
            if (eleve != null)
            {
                eleve.SetIdClasse(newClasseId);
                elRepository.Update(eleve.GetId(), eleve.GetNom(), eleve.GetPrenom(), eleve.GetSexe(), eleve.GetIdClasse());
            }
        }
    }
}
