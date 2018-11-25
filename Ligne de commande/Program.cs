using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//MMADI Nasfahdine

namespace LigneCommande
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LigneCommande> ligneCom;
            ligneCom = new List<LigneCommande>();
            //on instancie une liste qui va stockée toutes nos commandes

            string saisieDemandeNvlLigneCom;

            do
            {
                Console.WriteLine("saisissez le nom du produit commandée");
                string saisieNomArt;
                saisieNomArt = Console.ReadLine();

                Console.WriteLine("Quel est son prix ?");
                double saisiePrixUnit;
                saisiePrixUnit = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("quel quantité ?");
                int saisieQteCom;
                saisieQteCom = Convert.ToInt32(Console.ReadLine());

                LigneCommande commande;
                commande = new LigneCommande(saisieNomArt, saisiePrixUnit, saisieQteCom);
                //on instancie les saisies du client dans notre constructeur

                Console.WriteLine("Le montant de la ligne commande contenant un {1} au prix unitaire de {2} euros à la quantité de {3} est de {0} euros", commande.GetMontant(), saisieNomArt, saisiePrixUnit, saisieQteCom);
                //afichage de sa commande complète

                string saisieRep;

                do
                {
                    Console.WriteLine("avez-vous bénéficier d'une réduction? (répondez par oui ou non)");
                    saisieRep = Console.ReadLine();
                    //on demande a l'user si il a bénéficier d'une remise sur son produit

                    if (saisieRep == "oui" || saisieRep == "non")
                    {
                        if (saisieRep == "oui")
                        {
                            Console.WriteLine("quel est le montant de la remise?");
                            int remise;
                            remise = Convert.ToInt32(Console.ReadLine());
                            commande.CalculerReduction(remise);
                            Console.WriteLine("le montant de la ligne commande avec remise est de {0} euros", commande.CalculerReduction(remise));
                            break;
                        }
                        //application de la remise du client puis on sort de la boucle

                        else
                        {
                            Console.WriteLine("votre prix reste le même");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("vous avez saisi ni oui ni non, veuillez répondre par oui ou non svp");
                    }

                } while (saisieRep != "non");

                string saisieQuestionQteCom;

                do
                {
                    Console.WriteLine("désirez-vous modifier la quantité commandée de votre commande?");
                    saisieQuestionQteCom = Console.ReadLine();
                    //on demande a l'utilisateur si il veux modifier la quantité d'article commandée

                    if (saisieQuestionQteCom == "oui" || saisieQuestionQteCom == "non")
                    {
                        if (saisieQuestionQteCom == "oui")
                        {
                            Console.WriteLine("entrez la nouvelle quantité que vous désirez");
                            int nvlQteCom;
                            nvlQteCom = Convert.ToInt32(Console.ReadLine());
                            //l'utilisateur entre la nouvelle qte d'article de sa commande
                            do
                            {
                                if (nvlQteCom > 0)
                                {
                                    commande.QteCommandee = nvlQteCom;
                                    Console.WriteLine("Nouvelle ligne commande : {0} avec un prix total de {1} euros", commande.ToString(), commande.GetMontant());
                                    break;
                                    //on affiche le nouveau montant de sa commande
                                }
                                else
                                {
                                    Console.WriteLine("veuillez entrez une valeur strictement positive");
                                }
                            } while (nvlQteCom <= 0);
                        }

                        else
                        {
                            Console.WriteLine("vous ne désirez pas modifier la quantite d'article de votre commande");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vous avez saisi ni oui ni non, veuillez répondre svp");
                    }
                } while (saisieQuestionQteCom != "non");

                Console.WriteLine("la livraison de votre commande sera effectué le {0}", commande.GetDateLivraison(4)); //on affiche la date a laquelle l'utilisateur sera livrée                   

                while (true)
                {
                    Console.WriteLine("désirez vous effectuer une autre ligne commande ? (oui ou non)");
                    saisieDemandeNvlLigneCom = Console.ReadLine();
                    //on demande au client si il veut effectuer une autre commande

                    if (saisieDemandeNvlLigneCom == "oui" || saisieDemandeNvlLigneCom == "non")
                    {
                        if (saisieDemandeNvlLigneCom == "oui")
                        {
                            ligneCom.Add(commande); //ajout de la commande complète du client dans une liste dynamique nommée "ligneCom"
                            break;
                        }

                        else
                        {
                            Console.WriteLine("vous ne désirez pas saisir une autre ligne commande");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("vous n'avez pas répondu correctement à la question, veuillez répondre par oui ou non");
                    }
                }
            } while (saisieDemandeNvlLigneCom == "oui");
            //tant que le client répondra oui a la question on réitère les processus de saisie d'une nouvelle commande
         } 
    }
}
