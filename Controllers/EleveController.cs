using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class EleveController
    {
        private EleveRepository eleveRepository;

        public EleveController()
        {
            eleveRepository = new EleveRepository();
        }

        public List<Eleve> GetAllEleves()
        {
            return eleveRepository.FindAll();
        }

        public Eleve GetEleveById(int id)
        {
            return eleveRepository.GetInfo(id);
        }

        public void AddEleve(string nom, string prenom, string sexe)
        {
            eleveRepository.Create(nom, prenom, sexe);
        }

        public void UpdateEleve(int id, string nom, string prenom, string sexe)
        {
            eleveRepository.Update(id, nom, prenom, sexe);
        }

        public void DeleteEleve(int id)
        {
            eleveRepository.Delete(id);
        }
    }
}
