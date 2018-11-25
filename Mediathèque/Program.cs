using System;

namespace TpMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n");
            Console.WriteLine("Welcome to the JukeBox V2.0 ! \n");

            Document unCD = new CD("A7", 320, true, "lourd", "SCH", 11);
            Document uneVideo = new Video("Taxi 4", 130, true, "Bon film", "Luc Besson");

            Database bibliotheque = new Database();

            bibliotheque.AddCD(unCD);
            bibliotheque.AddVideo(uneVideo);

            //unCD.Afficher();

            //uneVideo.Afficher();

            bibliotheque.Editer();
            Console.ReadKey();
        }
    }
}
