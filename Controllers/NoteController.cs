using GestionClasse.Models;
using GestionClasse.Repository;
using GestionClasse.Views;
using System;
using System.Collections.Generic;

namespace GestionClasse.Controllers
{
    public class NoteController
    {
        public NoteRepository noRepository;

        public NoteController()
        {
            noRepository = new NoteRepository();
        }

        public List<Note> FindAll()
        {
            return noRepository.FindAll();
        }

        public void Create(int valeur, int idEleve, int idMatiere)
        {
            noRepository.Create(valeur, idEleve, idMatiere);
        }

        public void Delete(int idNote)
        {
            noRepository.Delete(idNote);
        }

        public void Update(int idNote, int valeur, int idEleve, int idMatiere)
        {
            noRepository.Update(idNote, valeur, idEleve, idMatiere);
        }
    }
}
