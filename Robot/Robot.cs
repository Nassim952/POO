using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgRobot
{
    class Robot
    {
        public void PrendrePiece(BrasArticule leBrasArticule)
        {
            Console.WriteLine("\nExecution du programme prendre piece..");
            leBrasArticule.Deplier();
        }
    }
}
