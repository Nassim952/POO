using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlamCrawler
{
    class Arme
    {
        private int dommage;
        private string nomArme;
        private int valeur;
        private int degatMinimum;
        private int degatMaximum;

        public Arme(string nomArme, int valeur, int degatMinimum, int degatMaximum)
        {
            Random R = new Random();
            this.nomArme = nomArme;
            this.valeur = valeur;
            this.degatMinimum = degatMinimum;
            this.degatMaximum = degatMaximum;
            this.dommage = R.Next(degatMinimum, degatMaximum);
        }

        public string ToStringArme()
        {
            string weapon;
            weapon = string.Format("Arme : {0} \n \n Valeur : {1} \n Dommage : {2} \n Degat Min : {3} \n Degats Max {4}",  
                this.nomArme, 
                this.valeur, 
                this.dommage,
                this.degatMinimum,
                this.degatMaximum);
            return weapon;
        }
    }
}
