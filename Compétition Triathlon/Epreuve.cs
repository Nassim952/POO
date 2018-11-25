using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionTri
{
    class Epreuve
    {
        private int distance;
        private string nom;
        private int tempsEliminatoire;

        public Epreuve(string nom, int distance, int tempsEliminatoire)
        {
            this.nom = nom;
            this.distance = distance;
            this.tempsEliminatoire = tempsEliminatoire;
        }

        public Epreuve(string nom, int distance)
        {
            this.nom = nom;
            this.distance = distance;
        }

        //accesseur sur nom
        public string GetNom { get => nom;}

        //accesseur sur TempsEliminatoire
        public int GetTempsEliminatoire
        {
            get
            {
                return tempsEliminatoire;
            }
        }

        //setter du temps maximal d'une épreuve sur TempsEliminatoire
        public void SetTempsEliminatoire(int tempsEliminatoire) { this.tempsEliminatoire = tempsEliminatoire; }

        //accesseur sur distance
        public int GetDistance()
        {
            return distance;
        }

    }
}
