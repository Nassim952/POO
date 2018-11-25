using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot leRobot = new Robot();
            Pince laPince = new Pince();
            BrasArticule leBrasArticule = new BrasArticule(leRobot, laPince);

            leBrasArticule.PrendrePiece(leRobot);
            Console.ReadKey();
        }
    }
}
