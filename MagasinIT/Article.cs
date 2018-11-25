using System;
using System.Collections.Generic;
using System.Text;

namespace MagasinIT
{
    class Article
    {
        private string designation;
        private double prixHorsTaxe;
        private double TauxTva;

        public Article(string designation, double prixHorsTaxe, double TauxTva)
        {
            this.designation = designation;
            this.prixHorsTaxe = prixHorsTaxe;
            this.TauxTva = TauxTva;
        }

        public double GetTauxTva
        {
            get
            {
                return TauxTva;
            }
        }

        public double GetPrixTaxe
        {
            get
            {
                return prixHorsTaxe * TauxTva;
            }
        }

        public double GetPrixHorsTaxe
        {
            get
            {
                return prixHorsTaxe;
            }
            set
            {
                prixHorsTaxe = value;
            }
        }

        public string GetDesignation
        {
            get
            {
                return designation;
            }
            set
            {
                designation = value;
            }
        }

        public void Affichage()
        {
            Console.WriteLine("designation : " + designation + "\nprix hors taxe : " + prixHorsTaxe +" euros \ntaux TVA : " + TauxTva+"\n");
        }
    }
}
