using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//MMADI Nasfahdine

namespace LigneCommande
{
    public class Commande
    {
        private static int lastId;
        private int id;

        List<LigneCommande> ligneCom;

        public Commande()
        {
            ligneCom = new List<LigneCommande>();
            lastId += 1;
            id = lastId;
        }
        //on créer notre constructeur avec à l'intérieur notre liste ligneCommande

        public void AddLigneCommande(LigneCommande ligne)
        {
            ligneCom.Add(ligne);
        }
        //cette méthode permet d'ajouter une commande dans notre liste

        public void AddLigneCommande(String nomArt,int qte,double prixUnitaire)
        {
            ligneCom.Add(new LigneCommande(nomArt,prixUnitaire, qte));
        }
        //de même que notre méthode AddLigneCommande

        public void RemoveLigneCommande(int indice)
        {
            ligneCom.RemoveAt(indice);
        }
        //cette méthode permet de retirer une commande a une position précise de notre liste

        public void Afficher()
        {
            ligneCom.ToString();
        }
        //methode permettant d'afficher notre ligneCom

        public void ToString() { 
        }
    }
}
