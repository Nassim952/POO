using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//MMADI Nasfahdine
 
namespace LigneCommande
{
    public class LigneCommande
    {
        private string nomArticle;
        private double prixUnitaire;
        private int qteCommande;
        //private bool payer;

        public LigneCommande(string nomArticle, double prixUnitaire, int qteCommande) {
            this.nomArticle = nomArticle;
            this.prixUnitaire = prixUnitaire;
            this.qteCommande = qteCommande;
            //this.payer = payer;
        }
        //constructeur de la LigneCommande

        public string ToString()
        {
            return string.Format("nom article : {0}, prix unitaire de : {1} euros, quantité commandée : {2}", nomArticle, prixUnitaire, qteCommande);
        }
        //ToString sur LigneCommande

        private double CalculerMontant(){
            double resultat = this.prixUnitaire * this.qteCommande;
            return resultat;         
        }
        //methode permettant de calculer le montant de la commande en fonction de la quantité

        public double GetMontant() 
        {
            return this.CalculerMontant();  
        }
        //accesseur sur le résultat de la méthode CalculerMotnant(méthode privée)

        public double CalculerReduction(int tauxreduction) {
            double montant = this.prixUnitaire * this.qteCommande;
            double reduc = montant * tauxreduction / 100;
            double reduction = montant - reduc;
            return reduction;
        }
        //methode permettant de calculer la réduction dont beneficie l'user sur sa commande

        public DateTime GetDateLivraison(int delai)
        {
            DateTime livraison = new DateTime();
            livraison = DateTime.Now;
            return livraison.AddDays(delai);
        }
        //methode permettant de calculer la période de livraison estimée en fonction du délai entré en param et de la date actuelle
        
        public double GetPrixUnitaire()
        {
            return this.prixUnitaire;
        }
        //accesseur sur prixUnitaire

        public int QteCommandee
        {
            get
            {
                return this.qteCommande;
            }
            set
            {
                this.qteCommande = value;
            }
        }
        //accesseur en lecture//ecriture sur QteCommandée
    }
}
