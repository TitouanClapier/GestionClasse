using GestionClasse.Models;
using GestionClasse.Repository;

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

    public void Create(int idEleve, int idMatiere, int valeur)
    {
        noRepository.Create(idEleve, idMatiere, valeur);
    }

    public void Delete(int idNote)
    {
        noRepository.Delete(idNote);
    }

    public void Update(int idNote, int idEleve, int idMatiere, int valeur)
    {
        noRepository.Update(idNote, idEleve, idMatiere, valeur);
    }

    public List<Note> Find(int id)
    {
        return noRepository.Find(id);
    }
}
