using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class ProfesseurController
    {
        private ProfesseurRepository profRepository;

        public ProfesseurController()
        {
            profRepository = new ProfesseurRepository();
        }

        public List<Professeur> GetAllProfesseurs()
        {
            MessageBox.Show("test Controller");
            return profRepository.FindAll();
        }

        public Professeur GetProfesseurById(int id)
        {
            return profRepository.GetInfo(id);
        }

        public void AddProfesseur(string nom, string prenom, string matiere)
        {
            profRepository.Create(nom, prenom, matiere);
        }

        public void UpdateProfesseur(int id, string nom, string prenom, string matiere)
        {
            profRepository.Update(id, nom, prenom, matiere);
        }

        public void DeleteProfesseur(int id)
        {
            profRepository.Delete(id);
        }
    }
}
