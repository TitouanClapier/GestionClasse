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

        public void AddEleve(string nom, string prenom, string sexe)
        {
            elRepository.Create(nom, prenom, sexe);
        }

        public void UpdateEleve(int id, string nom, string prenom, string sexe)
        {
            elRepository.Update(id, nom, prenom, sexe);
        }

        public void DeleteEleve(int id)
        {
            elRepository.Delete(id);
        }
    }
}
