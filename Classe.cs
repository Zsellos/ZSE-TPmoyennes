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
            if (eleves.Count < 30)
            {
                var eleve = new Eleve(prenom, nom, this);
                eleves.Add(eleve);
            }
            else
            {
                Console.WriteLine($"Il y a déjà 30 élèves dans la class {nomClasse}. {prenom} {nom} n'a pas pu être rajouté.");
            }
            
        }

        public void ajouterMatiere(string matiere)
        {
            if (matieres.Count < 10)
            {
                matieres.Add(matiere);
            }
            else
            {
                Console.WriteLine($"La matiere {matiere} n'a pas pu être rajoutée, la classe {nomClasse} a déjà 10 matières.");
            }
            
        }

        public double moyenneMatiere(int matiere)
        {
            double moyenne = 0.00f;
            try
            {
                foreach (var eleve in eleves)
                {
                    moyenne += eleve.moyenneMatiere(matiere);
                }
                moyenne /= eleves.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors du calcule de la moyenne de classe pour une matière : {e}");
            }
            return Math.Round(moyenne, 2);
        }

        public double moyenneGeneral()
        {
            double moyenne_gen = 0.00f;
            try
            {
                for (int mat = 0; mat < matieres.Count; mat++)
                {
                    moyenne_gen += moyenneMatiere(mat);
                }
                moyenne_gen /= matieres.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors du calcule de la moyenne générale de la classe : {e}");
            }
            
            return Math.Round(moyenne_gen, 2);
        }
    }
}
