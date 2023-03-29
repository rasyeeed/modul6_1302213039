using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213039
{
    internal class SayaTubeVideo
    {
        public int id;
        public string title;
        public int playCount;

        public SayaTubeVideo(String title)
        {
            Debug.Assert(title.Length <= 100 && title != null, "judul video memiliki panjang maksimal 100 karakter dan tidak null.");
            this.title = title;
            var random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = id;
        }

        public void IncreasePlayCount(int playCount)
        {
            playCount++;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("playCount : " + playCount);
        }

    }
}
