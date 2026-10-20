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

        public double moyenneMatiere(int matiere)
        {
            double moyenne = 0.00f;
            foreach (var eleve in eleves)
            {
                moyenne += eleve.moyenneMatiere(matiere);
            }
            moyenne /= eleves.Count;
            return Math.Round(moyenne, 2);
        }

        public double moyenneGeneral()
        {
            double moyenne_gen = 0.00f;
            for (int mat = 0; mat < matieres.Count; mat++)
            {
                moyenne_gen += moyenneMatiere(mat);
            }
            moyenne_gen /= matieres.Count;
            return Math.Round(moyenne_gen, 2);
        }
    }
}
