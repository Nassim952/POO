using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlamCrawler
{
    class Personnage
    {
        private int force;
        private int intelligence;
        private Peuple peuple;
        private int vitalite;
        private int agilite;
        private int chance;
        private int pointDeVie;
        private int pointDeVieMaximun;
        private string nom;
        private Class classe;
        private Genre genre;
        private Bourse bourse;
        private Casque casque;
        private Bouclier bouclier;
        private Gants gants;
        private Arme arme;
        private Armure armure;

        public Personnage(string nom, int agilite, int chance, int force, int pointDeVie, int pointDeVieMaximum, Peuple peuple, Class classe, Genre genre)
        {
            this.pointDeVie = pointDeVie;
            this.pointDeVieMaximun = pointDeVieMaximum;
            this.force = force;
            this.agilite = agilite;
            this.nom = nom;
            this.chance = chance;
            this.peuple = peuple;
            this.classe = classe;
            this.genre = genre;
        }

        public Personnage(string nom)
        {
            Random r = new Random();
            this.nom = nom;

            this.pointDeVieMaximun = r.Next(6,15);
            this.pointDeVie = this.pointDeVieMaximun;
            this.force = r.Next(6, 15);
            this.agilite = r.Next(6, 15);
            this.nom = nom;
            this.chance = r.Next(6, 15);
            this.peuple = (Peuple)r.Next(0, 7);
            this.classe = (Class)r.Next(0, 3);
            this.genre = (Genre)r.Next(0, 3); ;
        }

        public void Deplacer(int direction) { }
        public void Regarder(int distance, int direction) { }
        public void Frapper(Personnage adversaire, int degats) { }
        public void RecevoirCoup(int degats) { }
        public void Boire(Potion potion) { }
        public bool EstVivant() { return true; }
        private void mourir() { }

        //Accesseurs sur nom
        public string GetNom()
        {
            return this.nom;
        }

        //Accesseurs sur Agilite
        public int GetAgilite()
        {
            return this.agilite;
        }

        //Accesseurs sur force
        public int GetForce()
        {
            return this.force;
        }

        //Accesseurs sur Point de vie Max
        public int GetPointDeVieMaximum()
        {
            return this.pointDeVieMaximun;
        }

        //Accesseurs sur Point de vie
        public int GetPointDeVie()
        {
            return this.pointDeVie;
        }

        //Accesseurs sur Chance
        public int GetChance()
        {
            return this.chance;
        }

        //Accesseur sur nom Lecture/Ecriture
        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        //Methode ToString
        public string ToString()
        {
           string caracteristiques;
           caracteristiques = string.Format("{0} appartenant au peuple {1} de la classe {2} du genre {3} \n \n HP Max : {4} \n HP : {5} \n Force : {6} \n Agilite : {7} \n Chance : {8}", 
               this.nom, 
               this.peuple, 
               this.classe, 
               this.genre,
               this.pointDeVieMaximun, 
               this.pointDeVie, 
               this.force, 
               this.agilite, 
               this.chance);
           return caracteristiques;
        }
    }
}
