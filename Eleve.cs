using System;

namespace HNI_TPmoyennes
{
	class Eleve
	{
        public string prenom {  get; set; }
        public string nom { get; set; }
        public Classe classe { get; set; }
        public List<Note> notes { get; set; } = new List<Note>();

        public Eleve(string name, string surname, Classe cla)
		{
            prenom = name;
            nom = surname;
            classe = cla;
		}

        public double moyenneMatiere(int matiere)
        {
            double moyenne = 0.00f;
            int nb_notes = 0;
            foreach (Note note in notes)
            {
                if (note.matiere == matiere)
                {
                    moyenne += note.note;
                    nb_notes++;
                }
            }
            moyenne /= nb_notes;
            return Math.Round(moyenne, 2);
        }

        public double moyenneGeneral()
        {
            double moyenne_tot = 0.00f;
            for (int mat = 0; mat < classe.matieres.Count; mat++)
            {
                moyenne_tot += moyenneMatiere(mat);
            }
            moyenne_tot /= classe.matieres.Count;
            return Math.Round(moyenne_tot, 2);
        }

        public void ajouterNote(Note note)
        {
            notes.Add(note);
        }
    }
}
