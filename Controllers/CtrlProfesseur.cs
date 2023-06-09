using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class CtrlProfesseur
    {
        private RepoProfesseur profRepository;

        public CtrlProfesseur()
        {
            profRepository = new RepoProfesseur();
        }

        public List<ClsProfesseur> GetAllProfesseurs()
        {
            //MessageBox.Show("test Controller");
            return profRepository.FindAll();
        }

        public ClsProfesseur GetProfesseurById(int id)
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
