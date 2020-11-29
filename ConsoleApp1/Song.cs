using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Song : IComparable
    {
        // Properties
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre MusicGenre { get; set; }


        // Constructors
        public Song(string title, string artist, double duration, Genre musicGenre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            MusicGenre = musicGenre;
        }

        public Song(string title, string artist) : this(title, artist, 0, Genre.Other)
        {

        }

        public Song() : this("Unknown", "Unknown")
        {

        }


        // Methods
        public override string ToString()
        {
            return string.Format($"{Title} {Artist} {Duration} {MusicGenre}");
        }

        public int CompareTo(object other)
        {
            Song that = (Song)other;

            int returnValue = this.Artist.CompareTo(that.Artist); // This will sort my artist

            if (returnValue == 0)
            {
                returnValue = this.Title.CompareTo(that.Title); // If artist is the same, sort by title
            }

            return returnValue;
        }
    }

    public enum Genre{ Rock, Pop, Dance, Other}
}
