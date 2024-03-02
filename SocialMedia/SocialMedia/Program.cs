using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User  user = new User("123","Abdul Hanan","abdlhanan987@gmail.com","1234");
            List <string> Comments = new List<string>();
            Comments.Add("This is a good video");
            Comments.Add("You need to improve ypur video");
            List<string> likes = new List<string>();
            likes.Add("1.Good");
            likes.Add("2.Good");
            user.addPost("My first day at Uni",Comments,likes);
            user.print();
            User user1 = new User("1234","Safwan","1234@gmail.com","765"); 
            user.addUser(user1);
            user.getfollowrs();
            Console.ReadKey();
        }
    }
}
