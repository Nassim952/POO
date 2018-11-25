using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgRobot
{
    class Pince
    {
        public void Fermer(BrasArticule leBrasArticule)
        {
            Console.WriteLine("\npièce attraper !");
            Console.WriteLine("\nrepliage du bras en cours..");
            leBrasArticule.Replier();
        }

        public void Ouvrir()
        {
            Console.WriteLine("\nPièce relâché, fin de la séquence !");
        }
    }
}
