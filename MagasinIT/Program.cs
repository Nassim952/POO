using System;

namespace MagasinIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\nWelcome to the IT Store! \n");

            Catalogue unCatalogue;
            Article unProcesseur;
            Article uneBaretteMemoire;
            Article uneCarteMere;

            unCatalogue = new Catalogue();
            unProcesseur = new Article("I7-8700K", 150.0, 19.6);
            uneBaretteMemoire = new Article("Corsair Vengeance 3000 Mhz", 70.0, 19.6);
            uneCarteMere = new Article("MSI Z370", 140.0, 19.6);

            unCatalogue.AddArticle(unProcesseur);
            unCatalogue.AddArticle(uneBaretteMemoire);
            unCatalogue.AddArticle(uneCarteMere);

            Console.WriteLine("**********************************");

            Console.WriteLine("Affichage du catalogue d'article\n");
            unCatalogue.AfficherCatalogue();

            Console.WriteLine("***********************************");

            unCatalogue.AugmenterPetitPrix(20, uneBaretteMemoire);

            Console.WriteLine("***********************************");

            Console.WriteLine("Affichage du catalogue après augmentation\n");
            unCatalogue.AfficherCatalogue();

            Console.ReadKey();
        }
    }
}
