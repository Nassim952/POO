using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphisme
{
    class ListeEmployes
    {
        private List<Personne> lesPersonnes;

        public ListeEmployes()
        {
            lesPersonnes = new List<Personne>();
        }

        public void AddPersonne(Personne unePersonne)
        {
            lesPersonnes.Add(unePersonne);
        }

        public void AffichageEmploye()
        {
            for(int i=0; i<lesPersonnes.Count;i++)
            {
                lesPersonnes[i].Afficher();
            }
        }
    }
}
