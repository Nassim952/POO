using System;
using System.Collections.Generic;
using System.Text;

namespace MagasinIT
{
    class Catalogue
    {
        //déclaration collection d'articles
        private List<Article> leCatalogue;

        public Catalogue()
        {
            leCatalogue = new List<Article>();
        }

        public void AddArticle(Article unArticle)
        {
            Console.WriteLine("Ajout de l'article {0} dans le catalogue \n", unArticle.GetDesignation);
            leCatalogue.Add(unArticle);
        }

        //augmenter les prix en prenant compte la désignation d'un article 
        public void AugmenterPetitPrix(double augmentation, Article unArticle)
        {
            Console.WriteLine("\nAugmentation du prix de {0} de {1}%\n", unArticle.GetDesignation, augmentation);
            for (int i = 0; i < leCatalogue.Count; i++)
            {
                if (leCatalogue[i].GetDesignation == unArticle.GetDesignation)
                {
                    leCatalogue[i].GetPrixHorsTaxe = leCatalogue[i].GetPrixHorsTaxe * (1 + augmentation / 100);
                }
            }
        }

        //augmenter les prix du catalogue entier 
        public void AugmenterPetitPrix(double augmentation)
        {
            Console.WriteLine("Augmentation des prix de tout les articles de {0}%\n", augmentation);

            for (int i = 0; i < leCatalogue.Count; i++)
            {
               leCatalogue[i].GetPrixHorsTaxe = leCatalogue[i].GetPrixHorsTaxe * (1 + augmentation / 100);
            }
        }

        public void AfficherCatalogue()
        {
            //Console.WriteLine("Affichage du catalogue d'article\n");
            for (int i = 0; i < leCatalogue.Count; i++)
            {
                leCatalogue[i].Affichage();
            }
        }
    }
}
