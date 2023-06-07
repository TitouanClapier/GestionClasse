using GestionClasse.Repository;
using GestionClasse.Views;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class ClasseController
    {
        private ClasseRepository classeRepository;

        public ClasseController()
        {
            classeRepository = new ClasseRepository();
        }

        public List<Classe> GetAllClasses()
        {
            return classeRepository.FindAll();
        }

        public Classe GetClasseById(int id)
        {
            return classeRepository.GetInfo(id);
        }

        public void AddClasse(string nom, int niveau)
        {
            classeRepository.Create(nom, niveau);
        }

        public void UpdateClasse(int id, string nom, int niveau)
        {
            classeRepository.Update(id, nom, niveau);
        }

        public void DeleteClasse(int id)
        {
            classeRepository.Delete(id);
        }
    }
}
