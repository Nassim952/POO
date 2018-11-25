using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphisme
{
    class Employe:Personne
    {
        private double salaire;

        public double GetSalaire { get => salaire; set => salaire = value; }

        public Employe(string nom, string prenom, DateTime dateNaissance, double salaire)
            :base(nom,prenom,dateNaissance)
        {
            this.salaire = salaire;
        }

        public override void Afficher()
        {
            Console.WriteLine("nom : {0}\n" +
               "prenom : {1}\n" +
               "dateNaissance : {2}\n" +
               "salaire : {3}\n",GetNom, GetPrenom, GetDateNaissance, GetSalaire); 
        }
    }
}
