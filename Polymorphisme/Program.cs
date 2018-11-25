using System;

namespace polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nass's Start-up");
            Console.WriteLine("\nPrésentation des employés\n");

            ListeEmployes listeEmployes;
            listeEmployes = new ListeEmployes();

            Personne naim = new Employe("Naim", "Mmadi",DateTime.Now, 2460.0);
            Personne denis = new Employe("Denis", "Papaing", DateTime.Now, 1490.0);
            Personne emma = new Employe("Emma", "Duchalet", DateTime.Now, 3490.0);
            Personne faled = new Employe("Faled", "Bouziani", DateTime.Now, 4490.0);
            Personne momo = new Employe("Mohamed", "Khalid", DateTime.Now, 5490.0);

            Personne mehdi = new Chef("Mehdi", "Halaoued", DateTime.Now, "Budget", 4560.0);
            Personne nassim = new Chef("Nassim", "Mmadi", DateTime.Now, "R&D", 8760.0);

            Personne charles = new Directeur("Charles", "Tapis", DateTime.Now, "Comptable", 894651.0, "Commerce");

            listeEmployes.AddPersonne(naim);
            listeEmployes.AddPersonne(denis);
            listeEmployes.AddPersonne(emma);
            listeEmployes.AddPersonne(faled);
            listeEmployes.AddPersonne(momo);
            listeEmployes.AddPersonne(mehdi);
            listeEmployes.AddPersonne(nassim);
            listeEmployes.AddPersonne(charles);

            listeEmployes.AffichageEmploye();

            Console.ReadKey();
        }
    }
}
