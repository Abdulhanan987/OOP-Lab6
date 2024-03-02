using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    internal class User
    {
        private string id;
        private string name;
        private string email;
        private string password;
        private List<Post> posts;
        private List<User> followers=new List<User>();
        public User(string id, string name, string email,string password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            posts = new List<Post>();
        }
        public void setid(string id) { this.id = id;}
        public void setname(string name) {  this.name = name;}
        public void setemail(string email) {  this.email = email;}
        public void setpassword(string password) {  this.password = password;}
        public string getpassword() { return this.password;}
        public string getId() { return this.id;}
        public string getName() { return this.name;}
        public string getemail()
        {
            return this.email;
        }
        public List<Post> getposts() {  return posts; }
        public void setPosts(List<Post> posts) { this.posts = posts; }
        public void addUser(User user)
        {
            this.followers.Add(user);
        }
        public void addPost(string name,List<string> comments,List<string> likes)
        {
            posts.Add(new Post(comments,likes,name));
        }
        public void print()
        {
            Console.WriteLine(name);
            foreach (Post post in posts)
            {
                Console.WriteLine(post.getpost());
                post.getLikes();
                post.getName();
            }
        }
        public void getfollowrs()
        {
            foreach (User item in followers)
            {
                Console.WriteLine(item.name);
            }
        }

    }
}
