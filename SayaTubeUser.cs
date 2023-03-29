using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213039
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        static private Random rnd = new Random();
        public SayaTubeUser(string username)
        {
            this.Username = username;
            id = rnd.Next(1000, 9999);
            uploadedVideos = new List<SayaTubeVideo>();

        }

        public int GetTotalVideoPlayCount()
        {
            return uploadedVideos.Count;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " Review Film" + " judul: " + uploadedVideos[i].title + " Oleh Rasyid");
            }
        }
    }
}
