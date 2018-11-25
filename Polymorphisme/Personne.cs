using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphisme
{
    abstract class Personne
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        public string GetNom { get => nom; set => nom = value; }

        public string GetPrenom { get => prenom; set => prenom = value; }

        public DateTime GetDateNaissance { get => dateNaissance; set => dateNaissance = value; }

        public virtual void Afficher()
        {
           
        }
    }
}
