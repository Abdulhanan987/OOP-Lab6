using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Author
    {
        private string Name;
        private string Email;
        private char Gender;
        public Author (string Name, string Email, char Gender)
            {
            this.Name = Name;
            this.Email = Email;
            this.Gender = Gender;
}
        public Author() { }
            public string getNameOfAuthor()
        {
                return Name;
        }
        public string getEmail()
        {
            return Email;
        }
        public char getGender() 
        {
            return Gender;
        }

    }
}
