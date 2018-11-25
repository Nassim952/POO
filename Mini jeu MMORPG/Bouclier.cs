using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlamCrawler
{
    class Bouclier
    {
        private string nomBouclier;
        private int valeur;
        private int AC;
      
        public Bouclier(string nomBouclier, int valeur, int AC)
        {
            this.nomBouclier = nomBouclier;
            this.valeur = valeur;
            this.AC = AC;
        }

        public string ToStringBouclier()
        {
            string shield;
            shield = string.Format("Bouclier : {0} \n Valeur : {1} \n AC : {2}", this.nomBouclier, this.valeur, this.AC);
            return shield;
        }
    }
}
