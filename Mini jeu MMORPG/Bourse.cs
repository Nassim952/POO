using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlamCrawler
{
    class Bourse
    {
        private int nombrePiece;
        public Bourse(int nombrePiece)
        {
            this.nombrePiece = nombrePiece;
            nombrePiece = 0;
        }

        public void Placer(int quantite)
        {
            nombrePiece = nombrePiece + quantite;
        }

        public void Prendre(int quantite)
        {
            if (quantite <= nombrePiece)
            {
                nombrePiece = nombrePiece - quantite;
            }
            else
            {
                Console.WriteLine("tu n'as pas assez de pièce pour retirer {0}", quantite);
            }
        }

        //ToString Bourse
        public string ToStringBourse()
        {
            string argent;
            argent = string.Format("{0} pieces d'or", this.nombrePiece);
            return argent;
        }

        //Accesseurs sur Bourse
        public int GetNombrePiece()
        {
            return this.nombrePiece;
        }
    }
}
