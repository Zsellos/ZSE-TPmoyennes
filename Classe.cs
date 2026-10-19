using System;

namespace HNI_TPmoyennes
{
	public class Classe
	{
        public string nomClasse { get; set; }
        public List<Eleve> eleves { get; set; } = new List<Eleve>();
        public List<string> matieres { get; set; } = new List<string>();
        // FIXME : Might need to create a class for matiere
        // Or an enum

        public Classe(string nom)
		{
			nomClasse = nom;
		}

        public void ajouterEleve(string prenom, string nom)
        {
            var eleve = new Eleve(prenom, nom);
            eleves.Add(eleve);
        }

        public void ajouterMatiere(string matiere)
        {
            matieres.Add(matiere);
        }

        public string moyenneMatiere(int v)
        {
            // FIXME : revise return type and type of parameters
            throw new NotImplementedException();
        }

        public string moyenneGeneral()
        {
            // FIXME
            throw new NotImplementedException();
        }
    }
}
