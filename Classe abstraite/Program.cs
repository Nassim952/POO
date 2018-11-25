using System;

namespace Classe_Abstraite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Vehicule uneVoiture = new Voiture(1, 2000, 1000);
            Vehicule unCamion = new Camion(2, 2000, 1800);

            uneVoiture.Accelerer();

            Console.WriteLine("**************\n");

            unCamion.Accelerer();

            Console.WriteLine("**************\n");

            uneVoiture.Demarrer();

            Console.WriteLine("**************\n");

            unCamion.Demarrer();

            Console.ReadKey();

        }
    }
}
