using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_8
{
    class Program
    {
        static void Main(string[] args)
        {

            SongRepo GodsPlayList = new SongRepo();


            Song s1 = new Song("Title of The Song", 4.00, "Artist");
            Song s2 = new Song("Downfall of us All", 6.00, "A Day to Remember");
            Song s3 = new Song("Give Up The Funk", 6.23, "Parlament");
            Song s4 = new Song("Purple Rain", 5.42, "Prince");

            GodsPlayList.AddSong(s2);
            GodsPlayList.AddSong(s3);
            GodsPlayList.AddSong(s1);
            GodsPlayList.AddSong(s4);

            GodsPlayList.PrintList(GodsPlayList.GetSongList());
            Console.WriteLine("Has the Song Finished");

            string response = Console.ReadLine();

            if (response == "yes")
            {
                GodsPlayList.CurrentSongFinished();
                
            }

            Console.WriteLine("Here Is Your Current List");

            GodsPlayList.PrintList(GodsPlayList.GetSongList());

            Console.ReadLine(); 

        }
    }
}
