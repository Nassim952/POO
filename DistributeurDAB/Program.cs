using System;

namespace Distributeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Client nassim = new Client("MMADI", "Nassim");
            Client mehdi = new Client("Oualed", "Mehdi");

            Banque BNP = new Banque("BNP", nassim);
            Distributeur DAB = new Distributeur("Crédit Agricole", BNP);

            mehdi.Starter(DAB);

            Console.ReadKey();
        }
    }
}
