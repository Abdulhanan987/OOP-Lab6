using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList
{
    internal class Song
    {
        private string Name;
        private string Singer;
        public Song(string name , string singer)
        {
           this.Name = name;
            this.Singer = singer;
        }
        public void setname(string name)
        {
            this.Name = name;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getSinger()
        {
            return this.Singer;
        }
        public void setSinger(string singer)
        {
            this.Singer = singer;
        }
    }
}
