using System;

namespace HNI_TPmoyennes
{
	class Classe
	{
        public string nomClasse { get; set; }
        public List<Eleve> eleves { get; set; } = new List<Eleve>();
        public List<string> matieres { get; set; } = new List<string>();

        public Classe(string nom)
		{
			nomClasse = nom;
		}

        public void ajouterEleve(string prenom, string nom)
        {
            var eleve = new Eleve(prenom, nom, this);
            eleves.Add(eleve);
        }

        public void ajouterMatiere(string matiere)
        {
            matieres.Add(matiere);
        }

        public float moyenneMatiere(int matiere)
        {
            float moyenne = 0;
            foreach (var eleve in eleves)
            {
                moyenne += eleve.moyenneMatiere(matiere);
            }
            moyenne /= eleves.Count;
            Console.WriteLine($"Moy mat : {moyenne}");
            return moyenne; // FIXME : precision of number
        }

        public float moyenneGeneral()
        {
            float moyenne_gen = 0.00f;
            for (int mat = 0; mat < matieres.Count; mat++)
            {
                moyenne_gen += moyenneMatiere(mat);
            }
            moyenne_gen /= matieres.Count;
            Console.WriteLine($"Moy gen : {moyenne_gen}");
            return moyenne_gen; // FIXME : precisions après la virgule
        }
    }
}
