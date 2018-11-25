using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Abstraite
{
    class Voiture:Vehicule
    {
        public Voiture(int matricule, int anneeModele, int prix)
            : base(matricule, anneeModele, prix) { }

        public override void Accelerer()
        {
            Console.WriteLine("Méthode accélerer de la voiture enclenché");
        }

        public override void Demarrer()
        {
            Console.WriteLine("Méthode démarrer de la voiture enclenché");
        }
    }
}
