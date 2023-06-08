using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class ClasseController
    {
        private ClasseRepository claRepository;

        public ClasseController()
        {
            claRepository = new ClasseRepository();
        }

        public List<Classe> GetAllClasses()
        {
            return claRepository.FindAll();
        }

        public Classe GetClasseById(int id)
        {
            return claRepository.GetInfo(id);
        }

        public void AddClasse(string nom, int niveau)
        {
            claRepository.Create(nom, niveau);
        }

        public void UpdateClasse(int id, string nom, int niveau)
        {
            claRepository.Update(id, nom, niveau);
        }

        public void DeleteClasse(int id)
        {
            claRepository.Delete(id);
        }
    }
}
