using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("Beautiful People", "Ed Sheeran", 3.15, Genre.Pop);
            Song s2 = new Song("Dance Monkey", "Tones & 1", 4.20, Genre.Dance);
            Song s3 = new Song("Circles", "Post Malone", 3.25, Genre.Pop);
            Song s4 = new Song("Ride It", "Regard", 3.37, Genre.Dance);
            Song s5 = new Song("South of The Border", "Ed Sheeran", 4.26, Genre.Pop);

            List<Song> playlist = new List<Song>();

            playlist.Add(s1);
            playlist.Add(s2);
            playlist.Add(s3);
            playlist.Add(s4);
            playlist.Add(s5);

            foreach (Song song in playlist)
            {
                Console.WriteLine(song);
            }
        }
    }
}
