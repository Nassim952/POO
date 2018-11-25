using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlamCrawler
{
    class Program
    {
        static void Main() {
            Personnage bilbo = new Personnage("bilbo",50,0,20,80,80,Peuple.Hobbit,Class.Voleur,Genre.Neutre);
            Personnage Nass = new Personnage("Nass");
            Personnage Azog = new Personnage("Azog", 15, 0, 40, 120, 120, Peuple.Orc, Class.Guerrier, Genre.Mechant);
            Personnage Gauvin = new Personnage("Gauvin");

            Bourse B = new Bourse(150);
            B.Placer(100);
            B.Prendre(350);
            Console.WriteLine(B.GetNombrePiece());

            Arme Dagger = new Arme("Dagger", 5, 1, 4);
            Arme Staff = new Arme("Staff", 10, 1, 5);
            Arme ShortSword = new Arme("Short Sword", 15, 1, 6);

            Arme[] classArme = new Arme[2];
            classArme[0] = Dagger;
            classArme[1] = Staff;
            classArme[2] = ShortSword;


            Armure Robes = new Armure("Robes", 15, 1);
            Armure LeatherArmor = new Armure("Leather Armor", 50, 2);
            Armure ChainMail = new Armure("Chain Mail", 90, 3);

            Armure[] classArmure = new Armure[2];
            classArmure[0] = Robes;
            classArmure[1] = LeatherArmor;
            classArmure[2] = ChainMail;


            Casque helm = new Casque("helm", 100, 1);
            Casque helm1 = new Casque("helm +1", 3000, 2);
            Casque helm2 = new Casque("helm +2", 8000, 3);

            Casque[] classCasque = new Casque[2];
            classCasque[0] = helm;
            classCasque[1] = helm1;
            classCasque[2] = helm2;


            Bouclier SmallShield = new Bouclier("Small Shield", 20, 2);
            Bouclier LargeShield = new Bouclier("Large Shield", 40, 3);
            Bouclier Shield1 = new Bouclier("Shield +1", 1500, 4);

            Bouclier[] classBouclier = new Bouclier[2];
            classBouclier[0] = SmallShield;
            classBouclier[1] = LargeShield;
            classBouclier[2] = Shield1;

            Gants CopperGloves = new Gants("Copper Gloves", 6000, 1);
            Gants SilverGloves = new Gants("Silver Gloves", 60000, 3);

            Gants[] classGants = new Gants[1];
            classGants[0] = CopperGloves;
            classGants[1] = SilverGloves;

         }
         

    }
}
