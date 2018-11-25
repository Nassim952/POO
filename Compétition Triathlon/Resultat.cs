using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionTri
{
    class Resultat
    {
        private int tempsRealise;
        Participant unParticipant;
        Epreuve uneEpreuve;

        //constructeur de Resultat
        public Resultat(Participant unParticipant, Epreuve uneEpreuve, int tempsRealise)
        {
            this.tempsRealise = tempsRealise;
        }

        //accesseur sur Epreuve
        public Epreuve GetEpreuve()
        {
            return uneEpreuve;
        }

        //accesseur sur tempsRealise
        public int GetTempsRealise
        {
            get
            {
                return tempsRealise;
            }
        }
    }
}
