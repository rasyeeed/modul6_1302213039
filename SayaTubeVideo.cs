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
            Debug.Assert(title.Length <= 200 && title != null, "judul video memiliki panjang maksimal 100 karakter dan tidak null.");
            this.title = title;
            var random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = id;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 25000000, "Input penambahan play count maksimal 50 pada setiap panggilan method-nya.");
            try
            {
                this.playCount = checked(this.playCount + playCount);
            }
            catch (OverflowException exep)
            {
                Console.WriteLine("Overflow exception : " + exep.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("playCount : " + playCount);
        }

    }
}
