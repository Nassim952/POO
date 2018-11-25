using System;
using System.Collections.Generic;
using System.Text;

namespace TpMedia
{
    class CD : Document
    {
        protected string artiste;
        protected int nombreDePistes;

        public CD(string titre, int duree, bool enStock, string commentaire, string artiste, int nombreDePistes)
            :base(titre, duree, enStock, commentaire)
        {
            this.artiste = artiste;
            this.nombreDePistes = nombreDePistes;
        }

        public override void Afficher()
        {
            string libelleStock;
            int libelleNombrePiste;

            if(enStock == true)
            {
                libelleStock = "Oui";
            }
            else
            {
                libelleStock = "Non";
            }

            libelleNombrePiste = nombreDePistes;

            Console.WriteLine("Affichage d'un CD ! \n" +
                "\nartiste: "+artiste+
                "\ntitre: "+titre+ 
                "\ndurée: " + duree+ 
                "\nEn stock: " + libelleStock+ 
                "\ncommentaire: "+commentaire+
                "\nnombre de pistes: "+libelleNombrePiste+"\n");
        }
    }
}
