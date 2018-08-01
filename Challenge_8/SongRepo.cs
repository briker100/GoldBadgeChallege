using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_8
{
    class SongRepo
    {
        Queue<Song> _songList = new Queue<Song>();


        public void AddSong(Song s)
        {
            _songList.Enqueue(s);
        }

        public Queue<Song> GetSongList()
        {
            return _songList;
        }

        public Song SeeCurrentSong()
        {
            return _songList.Peek();
        }

        public void CurrentSongFinished()
        {
            _songList.Dequeue();
        }

        public void PrintList(Queue<Song> list)
        {
            foreach (Song item in list)
            {
                Console.WriteLine(item);
            }
        }





        //public void GetSongList()
        //{
        //    foreach...
        //}
    }
}
