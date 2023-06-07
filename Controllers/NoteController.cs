using GestionClasse.Repository;
using GestionClasse.Views;
using System;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class NoteController
    {
        public NoteRepository noteRepository;

        public NoteController()
        {
            noteRepository = new NoteRepository();
        }

        public List<Note> FindAll()
        {
            return noteRepository.FindAll();
        }

        public void Create(int valeur, int idEleve, int idMatiere)
        {
            noteRepository.Create(valeur, idEleve, idMatiere);
        }

        public void Delete(int idNote)
        {
            noteRepository.Delete(idNote);
        }

        public void Update(int idNote, int valeur, int idEleve, int idMatiere)
        {
            noteRepository.Update(idNote, valeur, idEleve, idMatiere);
        }
    }
}
