using System;

namespace HNI_TPmoyennes
{
	public class Eleve
	{
        public string prenom {  get; set; }
        public string nom { get; set; }
        public List<Note> notes { get; set; } = new List<Note>();

        public Eleve(string name, string surname)
		{
            prenom = name;
            nom = surname;
		}

        public string moyenneMatiere(int matiere)
        {
            // TODO : Caculate mean from all note with the right matiere number
            throw new NotImplementedException();
        }

        public string moyenneGeneral()
        {
            // TODO : Calculate mean for all matiere
            // Then, mean
            // Adding variable for storing the general mean ?
            throw new NotImplementedException();
        }

        public void ajouterNote(Note note)
        {
            notes.Add(note);
        }
    }
}
