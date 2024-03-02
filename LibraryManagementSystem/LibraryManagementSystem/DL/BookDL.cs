using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class BookDL
    {
        public static List<Book> books = new List<Book>();
        static public void AddBook(Book book)
        {
            books.Add(book);
        }
        public static void RemoveBook(string name) 
        {
          

            for (int i = 0; i < books.Count; i++) 
            {
                if (name == BookDL.books[i].getname()) 
                {
                    books.RemoveAt(i);
                }
                
            }
            
        }
    }
}
