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

        public float moyenneMatiere(int matiere)
        {
            float moyenne = 0;
            int nb_notes = 0;
            foreach (Note note in notes)
            {
                if (note.matiere == matiere)
                {
                    moyenne += note.note;
                    nb_notes++;
                }
            }
            moyenne /= nb_notes; // FIXME : nombre de chiffre après la virgule
            return moyenne;
        }

        public float moyenneGeneral()
        {
            var moy_mat = new List<float>();
            float moyenne_tot = 0;
            for (int mat = 0; mat < classe.matieres.Count; mat++)
            {
                moyenne_tot += moyenneMatiere(mat);
            }
            moyenne_tot /= classe.matieres.Count;
            return moyenne_tot; // FIXME : precisions après la virgule
        }

        public void ajouterNote(Note note)
        {
            notes.Add(note);
        }
    }
}
