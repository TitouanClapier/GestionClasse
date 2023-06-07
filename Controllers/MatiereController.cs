using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class MatiereController
    {
        private MatiereRepository matiereRepository;

        public MatiereController()
        {
            matiereRepository = new MatiereRepository();
        }

        public List<Matiere> GetAllMatieres()
        {
            return matiereRepository.FindAll();
        }

        public Matiere GetMatiereById(int id)
        {
            return matiereRepository.GetInfo(id);
        }

        public void AddMatiere(string nom)
        {
            matiereRepository.Create(nom);
        }

        public void UpdateMatiere(int id, string nom)
        {
            matiereRepository.Update(id, nom);
        }

        public void DeleteMatiere(int id)
        {
            matiereRepository.Delete(id);
        }
    }
}
