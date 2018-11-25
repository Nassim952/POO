using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Abstraite
{
    class Vehicule
    {
        private int matricule;
        private int anneeModele;
        private int prix;

        public Vehicule(int matricule, int anneeModele, int prix)
        {
            this.matricule = matricule;
            this.anneeModele = anneeModele;
            this.prix = prix;
        }

        public int GetMatricule { get { return matricule; } }

        public int GetAnneeModele { get { return anneeModele; } }

        public int GetPrix { get { return prix; } }

        public virtual void Demarrer()
        {

        }

        public virtual void Accelerer()
        {

        }

        public override string ToString()
        {
            return string.Format(" Matricule : {0}\n Année modèle : {1}\n Prix : {2}", matricule, anneeModele, prix);
        }
    }
}
