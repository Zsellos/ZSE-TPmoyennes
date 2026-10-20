using System;

namespace HNI_TPmoyennes
{
	class Eleve
	{
        // FIXME : add condition to limit the number of notes at 200
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

        public void ajouterNote(Note note)
        {
            if (notes.Count < 200)
            {
                notes.Add(note);
            }
            else
            {
                Console.WriteLine($"L'élève {prenom} {nom} a déjà 200 notes. La nouvelle note {note.note} pour la matiere {note.matiere}:{classe.matieres[note.matiere]} n'a pas pu être rajoutée.");
            }
        }

        public double moyenneMatiere(int matiere)
        {
            double moyenne = 0.00f;
            int nb_notes = 0;
            try
            {
                foreach (Note note in notes)
                {
                    if (note.matiere == matiere)
                    {
                        moyenne += note.note;
                        nb_notes++;
                    }
                }
                moyenne /= nb_notes;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors du calcule de la moyenne de l'élève pour une matière {e}");
            }

            return Math.Round(moyenne, 2);
        }

        public double moyenneGeneral()
        {

            double moyenne_tot = 0.00f;
            try
            {
                for (int mat = 0; mat < classe.matieres.Count; mat++)
                {
                    moyenne_tot += moyenneMatiere(mat);
                }
                moyenne_tot /= classe.matieres.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors du calcule de la moyenne générale de l'élève : {e}");
            }
            return Math.Round(moyenne_tot, 2);
        }
    }
}
