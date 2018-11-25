using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlamCrawler
{
    class Casque
    {
        private string nomCasque;
        private int valeur;
        private int AC;
      
        public Casque(string nomCasque, int valeur, int AC)
        {
            this.nomCasque = nomCasque;
            this.valeur = valeur;
            this.AC = AC;
        }

        public string ToStringCasque()
        {
            string helmet;
            helmet = string.Format("Casque : {0} \n Valeur : {1} \n AC : {2}", this.nomCasque, this.valeur, this.AC);
            return helmet;
        }
    }
}
