using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur
{
    class Banque
    {
        private string nomBanque;
        private Client unClient;

        public string GetNomBanque { get => nomBanque; set => nomBanque = value; }
        public Client GetUnClient { get => unClient; set => unClient = value; }

        public Banque(string nomBanque, Client unClient)
        {
            this.nomBanque = nomBanque;
            this.unClient = unClient;
        }

        public void DemandeAutorisation(Distributeur unDistributeur)
        {
            Console.WriteLine("Traitement en cours...\n\nRetrait autorisée\n");
            unDistributeur.SoldeAutorise(unClient);
        }
    }
}
