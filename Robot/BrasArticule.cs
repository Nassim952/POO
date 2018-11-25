using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgRobot
{
    class BrasArticule
    {
        private Robot leRobot;
        private Pince laPince;

        public BrasArticule(Robot leRobot, Pince laPince)
        {
            this.leRobot = leRobot;
            this.laPince = laPince;
        }

        public void PrendrePiece(Robot leRobot)
        {
            Console.WriteLine("Lancement du programme *Prendre une pièce*");
            leRobot.PrendrePiece(this);
        }

        public void Deplier()
        {
            Console.WriteLine("\nDépliage du bras en cours..");
            Console.WriteLine("\ndépliage réussi, attrapage de la piece en cours...");
            laPince.Fermer(this);
        }

        public void Replier()
        {
            Console.WriteLine("\nbras replié !");
            Console.WriteLine("\nRelachement de la piece en cours..");
            laPince.Ouvrir();
        }
    }
}
