using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphisme
{
    class Directeur:Chef
    {
        private string societe;

        public string GetSociete { get => societe; set => societe = value; }

        public Directeur(string nom, string prenom, DateTime dateNaissance, string service, double salaire, string societe)
            : base(nom, prenom, dateNaissance, service, salaire)
        {
            this.societe = societe;
        }

        public override void Afficher()
        {
            Console.WriteLine("nom : {0}\n" +
               "prenom : {1}\n" +
               "dateNaissance : {2}\n" +
               "salaire : {3}\n" +
               "service : {4}\n" +
               "societe : {5}\n", GetNom, GetPrenom, GetDateNaissance, GetSalaire, GetService, GetSociete);
        }
    }
}
