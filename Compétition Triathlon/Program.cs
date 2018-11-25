using System;

namespace CompetitionTri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructeur Participant
            Participant p1 = new Participant(DateTime.Now, "Florent");
            Participant p2 = new Participant(DateTime.Now, "Albert");
            Participant p3 = new Participant(DateTime.Now, "Charles");

            //Constructeur Triathlon
            Tri compet1 = new Tri("XS", 400, 10000, 2500);
            Tri compet2 = new Tri("S", 750, 20000, 5000);
            Tri compet3 = new Tri("M", 1500, 40000, 10000);

            compet1.AddParticipant(p1);
            compet1.AddParticipant(p2);
            compet1.AddParticipant(p3);

            compet2.AddParticipant(p2);
            compet3.AddParticipant(p3);
    

            //Constructeur Epreuve
            Epreuve e1 = new Epreuve("natation", 400, 10);
            Epreuve e2 = new Epreuve("course à pied", 30000);
            Epreuve e3 = new Epreuve("cyclisme", 30, 30);

            //Constructeur Resultat
            Resultat r1 = new Resultat(p1, e1, 47);
            Resultat r2 = new Resultat(p2, e2, 589);
            Resultat r3 = new Resultat(p3, e3, 248);

            

            //test accesseur nature
            //Console.WriteLine(compet1.GetNature);

            //test accesseur sur l'épreuve en fonction du paramètre rentrer
            Console.WriteLine(compet2.GetEpreuve("natation"));

            //test accesseur GetParticipant
            Console.WriteLine(compet1.GetParticipant());

            //test Temps Eliminatoire
            Console.WriteLine(e1.GetTempsEliminatoire);

            //test hors délai
            Console.WriteLine(p1.HorsDelai());

            Console.ReadKey();
        }
    }
}
