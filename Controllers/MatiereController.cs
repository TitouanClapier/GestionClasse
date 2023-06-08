using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class MatiereController
    {
        private MatiereRepository matrepository;

        public MatiereController()
        {
            matrepository = new MatiereRepository();
        }

        public List<Matiere> GetAllMatieres()
        {
            return matrepository.FindAll();
        }

        public Matiere GetMatiere(int id)
        {
            return matrepository.Find(id);
        }

        public void CreateMatiere(string nom, int idProf)
        {
            matrepository.Create(nom, idProf);
        }

        public void DeleteMatiere(int idMatiere)
        {
            matrepository.Delete(idMatiere);
        }

        public void UpdateMatiere(int idMatiere, string nom, int idProf)
        {
            matrepository.Update(idMatiere, nom, idProf);
        }

        public Matiere GetMatiereInfo(int idMatiere)
        {
            return matrepository.GetInfo(idMatiere);
        }
    }
}
