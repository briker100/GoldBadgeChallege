using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_8
{
    class Song
    {
        public string Title { get; set; }
        public double Duration { get; set; }
        public string Artist { get; set; }

        public Song(string t, double d, string a)
        {
            Title = t;
            Duration = d;
            Artist = a;
        }

        public override string ToString()
        {
            return $"Title: {Title}\n" +
                $"Duration: { Duration}\n" +
                $"Artist: {Artist}";

        }
    }
}
