using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class ProfesseurController
    {
        private ProfesseurRepository professeurRepository;

        public ProfesseurController()
        {
            professeurRepository = new ProfesseurRepository();
        }

        public List<Professeur> GetAllProfesseurs()
        {
            return professeurRepository.FindAll();
        }

        public Professeur GetProfesseurById(int id)
        {
            return professeurRepository.GetInfo(id);
        }

        public void AddProfesseur(string nom, string prenom, string matiere)
        {
            professeurRepository.Create(nom, prenom, matiere);
        }

        public void UpdateProfesseur(int id, string nom, string prenom, string matiere)
        {
            professeurRepository.Update(id, nom, prenom, matiere);
        }

        public void DeleteProfesseur(int id)
        {
            professeurRepository.Delete(id);
        }
    }
}
