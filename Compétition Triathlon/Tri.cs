using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitionTri
{
    class Tri
    {
        private string nature;
        private Epreuve natation;
        private Epreuve velo;
        private Epreuve course;
        private List<Participant> lesParticipants;

        //Constructeur de Tri
        public Tri(string nature, int distanceNatation, int distanceVelo, int distanceCourse)
        {
            this.nature = nature;
            natation = new Epreuve("natation", distanceNatation);
            velo = new Epreuve("velo", distanceVelo);
            course = new Epreuve("course", distanceCourse);
            lesParticipants = new List<Participant>();
        }

        //Accesseur sur le champ Nature
        public string GetNature
        {
            get => nature;
        }

        //Accesseur sur Epreuve attend en parametre le nom de l'épreuve et retourne l'épreuve correspondante
        public Epreuve GetEpreuve(string nomEpreuve)
        {
            switch (nomEpreuve)
            {
                case "natation":
                    return natation;
                case "velo":
                    return velo;
                default:
                    return course;
            }
        }

        //Accesseur sur un participant en fonction de son ID unique attend en paramètre un ID
        public Participant GetParticipantById(int id)
        {
            foreach(Participant p in lesParticipants)
            {
                if(p.GetId() == id)
                {
                    return p;
                }          
            }
            return null;
        }

        //
        public string GetParticipant()
        {
            foreach(Participant p in lesParticipants)
            {
                return p.Afficher();
            }
            return null;
        }

        //retourne la liste de participant qui ne sont pas hors délai
        public List<Participant> GetLesTemps()
        {
            foreach(Participant p in lesParticipants)
            {
                if(p.HorsDelai() == false)
                {
                    lesParticipants.Add(p);
                }
            }
            return null;
        }

        //retourne la distance totale du triathlon pour les trois épreuves
        public int GetDistanceTotal()
        {
            int distanceTotal;
            distanceTotal = velo.GetDistance() + natation.GetDistance() + course.GetDistance();
            return distanceTotal;
        }

        //ajoute un participant a la liste
        public void AddParticipant(Participant unParticipant)
        {
            lesParticipants.Add(unParticipant);
        }
    }
}
