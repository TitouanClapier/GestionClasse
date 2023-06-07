using GestionClasse.Repository;
using GestionClasse.Views;
using System;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class MatiereController
    {
        private MatiereRepository _repository;

        public MatiereController()
        {
            _repository = new MatiereRepository();
        }

        public List<Matiere> GetAllMatieres()
        {
            return _repository.FindAll();
        }

        public void CreateMatiere(string nom, int idProf)
        {
            _repository.Create(nom, idProf);
        }

        public void DeleteMatiere(int idMatiere)
        {
            _repository.Delete(idMatiere);
        }

        public void UpdateMatiere(int idMatiere, string nom, int idProf)
        {
            _repository.Update(idMatiere, nom, idProf);
        }

        public Matiere GetMatiereInfo(int idMatiere)
        {
            return _repository.GetInfo(idMatiere);
        }
    }
}
