using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Distributeur
{
    class Distributeur
    {
        private string nomBanqueAffilie;
        private Banque uneBanque;
        private Client unClient;

        public string GetNomBanque { get => nomBanqueAffilie; set => nomBanqueAffilie = value; }

        public Banque GetUneBanque { get => uneBanque; set => uneBanque = value; }

        internal Client GetUnClient { get => unClient; set => unClient = value; }

        public Distributeur(string nomBanqueAffilie, Banque uneBanque)
        {
            this.nomBanqueAffilie = nomBanqueAffilie;
            this.uneBanque = uneBanque;
        }

        public void InsertionCarte(Client unClient)
        {
            Console.WriteLine("Carte inséreé, controle de validité du code en cours...\n");
            this.unClient = unClient;
            ControleValidite(unClient);
        }

        public void SoldeAutorise(Client unClient)
        {
            Console.WriteLine("Solde autorisée de prélèvement : 654 euros \n");
            unClient.MontantRetrait(this);
        }

        public void ControleValidite(Client unClient)
        {
            Console.WriteLine("Controle ok, demande du code au client\n");
            unClient.Code(this); 
        }

        public void TicketOK(Client unClient)
        {
            Console.WriteLine("Demande ticket enregistrée\n");
            Console.WriteLine("Ejection de la carte, veuillez la récupérée\n");
            unClient.EjectionCarte(this);
            
        }

        public void RecupererCarte(Client client)
        {
            Console.WriteLine("Ejection des billets et ticket veuillez les récupérer\n");
            client.EjectionBilletTicket(this);
        }

        public void RecupererBilletTicket()
        {
            Console.WriteLine("Billet et ticket récupérer, au revoir et a bientôt !\n");
        }

        public void MontantSaisi(Client client)
        {
            Console.WriteLine("Contrôle du montant demandé par rapport au solde disponible...\n");
            this.ControleMontant(client);
        }

        public void ControleMontant(Client unClient)
        {
            Console.WriteLine("Demande de retrait autorisée\n");
            unClient.DemandeTicket(this);
        }

        public void ControleCode()
        {
            Console.WriteLine("Code ok, demande de prélèvement en cours auprès de votre banque...\n");
            uneBanque.DemandeAutorisation(this);
        }
    }
}
