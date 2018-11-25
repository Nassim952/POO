using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TpMedia
{
    class Database
    {
        private ArrayList cds;
        private ArrayList videos;
        
        public Database()
        {
            cds = new ArrayList();
            videos = new ArrayList();
        }

        public void AddCD(Document unCd)
        {
            cds.Add(unCd);
        }

        public void AddVideo(Document uneVideo)
        {
            videos.Add(uneVideo);
        }

        public void Editer()
        {
            //affiche une liste de CD
            for(int i=0;i<cds.Count;i++)
            {
                CD cd = (CD)cds[i];
                cd.Afficher();
                Console.WriteLine();
            }

            //affiche une liste de videos
            for (int i = 0; i < videos.Count; i++)
            {
                Video video = (Video)videos[i];
                video.Afficher();
                Console.WriteLine();
            }
        }
    }
}
