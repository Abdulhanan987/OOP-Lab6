using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    internal class Post
    {
        private string postname;
       private List<string> Comments;
        private List<string> Likes;
        public Post(List<string> comments, List<string> Likes, string postname)
        {
            this.Comments = comments;
            this.Likes = Likes;
            this.postname = postname;
        }
      
        public void setName(List<string> name)
        {
            this.Comments=name;
        }
        public void setpost(string postname) { this.postname=postname; }
        public string getpost()
        {
            return this.postname;
        }
        public void getName() 
        {
            foreach(string item in this.Comments)
            {
                Console.WriteLine(item);
            }
        }
        public void getLikes()
        {
            foreach (string item in Likes)
            {
                Console.WriteLine(item);
            }
        }
        public void setLikes(List<string> Likes)
        { this.Likes = Likes;}
    }
}
