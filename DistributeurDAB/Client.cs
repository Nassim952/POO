using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur
{
    class Client
    {
        private string nom;
        private string prenom;

        public string GetNom { get => nom; set => nom = value; }
        public string GetPrenom { get => prenom; set => prenom = value; }

        public Client(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public void Starter(Distributeur distributeur)
        {
            Console.WriteLine("Le client se présente devant la machine de distribution de billets automatique\n");
            distributeur.InsertionCarte(this);
        }

        public void Code(Distributeur distributeur)
        {
            Console.WriteLine("Code inséré, vérification en cours...\n");
            distributeur.ControleCode();
        }

        public void MontantRetrait(Distributeur unDistributeur)
        {
            string montant;
            Console.WriteLine("Saisissez le montant de retrait souhaiter\n");
            montant = Console.ReadLine();
            Console.WriteLine("\nVous avez choisi de retirer : {0} euros\n", montant);
            unDistributeur.MontantSaisi(this);
        }

        public void DemandeTicket(Distributeur distributeur)
        {
            Console.WriteLine("Un ticket est demandé par le client\n");
            distributeur.TicketOK(this);
        }

        public void EjectionCarte(Distributeur distributeur)
        {
            Console.WriteLine("Le client récupère sa carte...\n");
            distributeur.RecupererCarte(this);
        }

        public void EjectionBilletTicket(Distributeur distributeur)
        {
            Console.WriteLine("Récupération des billets et ticket par le client...\n");
            distributeur.RecupererBilletTicket();
        }
    }
}
