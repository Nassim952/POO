using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlamCrawler
{
    class Gants
    {
        private string nomGants;
        private int valeur;
        private int AC;
      
        public Gants(string nomGants, int valeur, int AC)
        {
            this.nomGants = nomGants;
            this.valeur = valeur;
            this.AC = AC;
        }

        public string ToStringGants()
        {
            string gant;
            gant = string.Format("Gants : {0} \n Valeur : {1} \n AC : {2}",this.nomGants, this.valeur, this.AC);
            return gant;
        }
    }
}
