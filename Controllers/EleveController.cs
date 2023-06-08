using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class EleveController
    {
        private EleveRepository elRepository;

        public EleveController()
        {
            elRepository = new EleveRepository();
        }

        public List<Eleve> GetAllEleves()
        {
            return elRepository.FindAll();
        }

        public Eleve GetEleveById(int id)
        {
            return elRepository.GetInfo(id);
        }

        public List<Eleve> GetElevesByClasse(int classeId)
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
    }
}
