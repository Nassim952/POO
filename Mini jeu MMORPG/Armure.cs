using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlamCrawler
{
    class Armure
    {
        private string nomArmure;
        private int valeur;
        private int AC;
      
        public Armure(string nomArmure, int valeur, int AC)
        {
            this.nomArmure = nomArmure;
            this.valeur = valeur;
            this.AC = AC;
        }

        public string ToStringArmure()
        {
            string armor;
            armor = string.Format("Armure : {0} \n Valeur : {1} \n AC : {2}", this.nomArmure, this.valeur, this.AC);
            return armor;
        }
    }
}
