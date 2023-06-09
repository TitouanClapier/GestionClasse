using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class CtrlMatiere
    {
        private RepoMatiere matrepository;

        public CtrlMatiere()
        {
            matrepository = new RepoMatiere();
        }

        public List<ClsMatiere> GetAllMatieres()
        {
            return matrepository.FindAll();
        }

        public ClsMatiere GetMatiere(int id)
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

        public ClsMatiere GetMatiereInfo(int idMatiere)
        {
            return matrepository.GetInfo(idMatiere);
        }
    }
}
