using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionClasse.Models;
using GestionClasse.Repository;

namespace GestionClasse.Controllers
{
    public class CtrlNote
    {
        public RepoNote RepositoryNote;

        public CtrlNote()
        {
            RepositoryNote = new RepoNote();
        }

        public List<ClsNote> FindAll()
        {
            return RepositoryNote.FindAll();
        }

        public void Create(int idEleve, int idMatiere, int valeur)
        {
            RepositoryNote.Create(idEleve, idMatiere, valeur);
        }

        public void Delete(int idNote)
        {
            RepositoryNote.Delete(idNote);
        }

        public void Update(int idNote, int idEleve, int idMatiere, int valeur)
        {
            RepositoryNote.Update(idNote, idEleve, idMatiere, valeur);
        }

        public List<ClsNote> Find(int id)
        {
            return RepositoryNote.Find(id);
        }

        public ClsNote GetNoteById(int id)
        {
            return RepositoryNote.GetNoteById(id);
        }
    }
}
