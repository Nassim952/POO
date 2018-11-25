using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionTri
{
    class Participant
    {
        private DateTime dateInscription;
        private int id;
        private string nom;
        private List<Resultat> lesResultats;

        //constructeur participant
        public Participant(DateTime dateInscription, string nom)
        {
            this.dateInscription = dateInscription;
            this.nom = nom;

        }

        public string Afficher()
        {
            return ("Son nom est " + nom + " sa date d'inscription est le " + dateInscription);
        }

        //accesseur sur id
        public int GetId()
        {
            return id;
        }

        //Determine si un participant est hors delai ou pas. 
        //il est hors délai lorsqu'il dépasse 
        //le temps eliminatoire d'au moins une épreuve.

        //la détérmination se fait dans l'ordre des épreuves.
        //il n'y a pas de limite de temps dans la course à pied.
        public bool HorsDelai()
        {
            //bool horsDelai;
            //horsDelai = false;
            for (int i=0; i<lesResultats.Count; i++)
            {
                if (lesResultats[i].GetTempsRealise > lesResultats[i].GetEpreuve().GetTempsEliminatoire && lesResultats[i].GetEpreuve().GetNom != "course")
                {
                    return true;
                }
            }
            return false;
        }

        //accesseur sur dateInscription
        public DateTime GetDateInscription()
        {
            return dateInscription;
        }

        //accesseur sur nom
        public string GetNom()
        {
            return nom;
        }

        //calcule le temps total réalisé par le participant à une épreuve de triathlon pour les trois épreuves
        public int GetTempsTotal
        {
            get
            {
                int i = 0;
                int tempsTotal;
                return tempsTotal = lesResultats[i].GetTempsRealise;
            }
        }

        //vérifie qu'une épreuve est présente dans la collection de résultats
        public bool resultatPresent(Epreuve uneEpreuve)
        {
            for(int i = 0; i < lesResultats.Count; i++)
            {
                if(lesResultats[i].GetEpreuve().GetNom == uneEpreuve.GetNom)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
