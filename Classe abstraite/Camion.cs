using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Abstraite
{
    class Camion:Vehicule
    {
        public Camion(int matricule, int anneeModele, int prix)
            : base(matricule, anneeModele, prix) { }

        public override void Accelerer()
        {
            Console.WriteLine("Méthode accélerer du camion enclenché");
        }

        public override void Demarrer()
        {
            Console.WriteLine("Méthode démarrer du camion enclenché");
        }
    }
}
