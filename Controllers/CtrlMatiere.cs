using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class CtrlMatiere
    {
        private RepoMatiere RepositoryMatiere;

        public CtrlMatiere()
        {
            RepositoryMatiere = new RepoMatiere();
        }

        public List<ClsMatiere> GetAllMatieres()
        {
            return RepositoryMatiere.FindAll();
        }

        public ClsMatiere GetMatiere(int id)
        {
            return RepositoryMatiere.Find(id);
        }

        public void CreateMatiere(string nom, int idProf)
        {
            RepositoryMatiere.Create(nom, idProf);
        }

        public void DeleteMatiere(int idMatiere)
        {
            RepositoryMatiere.Delete(idMatiere);
        }

        public void UpdateMatiere(int idMatiere, string nom, int idProf)
        {
            RepositoryMatiere.Update(idMatiere, nom, idProf);
        }

        public ClsMatiere GetMatiereInfo(int idMatiere)
        {
            return RepositoryMatiere.GetInfo(idMatiere);
        }
    }
}
