using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList
{
    internal class Playlist
    {
        private List<Song> songs;
        public Playlist(List<Song> songs)
        {
            this.songs = songs;
        }
        public List<Song> getSongs()
        { 
            return songs;
        }
        public string GetTitle(int i) 
        {
            return songs[i].getSinger();
        }
    }
}
