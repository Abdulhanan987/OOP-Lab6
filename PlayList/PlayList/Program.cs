using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song("Tanhai","Atif Aslam");
            List<Song> list = new List<Song>();
            list.Add(song);
            Playlist playList = new Playlist(list);
            Console.WriteLine(song.getSinger());
            for (int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine(playList.GetTitle(i));
            }
           
            Console.ReadKey();
        }
    }
}
