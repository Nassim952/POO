using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphisme
{
    class Chef : Employe
    {
        private string service;

        public string GetService { get => service; set => service = value; }

        public Chef(string nom, string prenom, DateTime dateNaissance, string service, double salaire)
            : base(nom, prenom, dateNaissance, salaire)
        {
            this.service = service;
        }

        public override void Afficher()
        {
            Console.WriteLine("nom : {0}\n" +
               "prenom : {1}\n" +
               "dateNaissance : {2}\n" +
               "salaire : {3}\n" +
               "service : {4}\n", GetNom, GetPrenom, GetDateNaissance ,GetSalaire, GetService);
        }
    }
}
