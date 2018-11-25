using System;
using System.Collections.Generic;
using System.Text;

namespace TpMedia
{
    abstract class Document
    {
        protected string titre;
        protected int duree;
        protected bool enStock;
        protected string commentaire;

        public Document(string titre, int duree, bool enStock, string commentaire)
        {
            this.titre = titre;
            this.duree = duree;
            this.enStock = enStock;
            this.commentaire = commentaire;
        }

        public virtual void Afficher()
        {

        }
    }
}
