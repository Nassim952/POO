using System;
using System.Collections.Generic;
using System.Text;

namespace TpMedia
{
    class Video:Document
    {
        protected string metteurEnScene;

        public Video(string titre, int duree, bool enStock, string commentaire, string metteurEnScene)
            :base(titre, duree, enStock, commentaire)
        {
            this.metteurEnScene = metteurEnScene;
        }

        public override void Afficher()
        {
            string libelleStock;

            if (enStock == true)
            {
                libelleStock = "Oui";
            }
            else
            {
                libelleStock = "Non";
            }

            Console.WriteLine("Affichage d'une Video ! \n" +
                "\ntitre: " + titre +
                "\ndurée: " + duree +
                "\nEn stock: " + libelleStock +
                "\ncommentaire: " + commentaire +
                "\nmetteur en scène: "+metteurEnScene+"\n");
        }
    }
}
