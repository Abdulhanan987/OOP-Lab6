using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("All in all",120f,12,"Ali","abdlhanan987@gmail.com",'M');
            BookDL.AddBook(book);
           // for (int i = 0; i <BookDL.books.Count; i++) 
           // {
               // Console.WriteLine(BookDL.books[i].GetAuthor().getEmail()+" " + BookDL.books[i].GetAuthor().getNameOfAuthor()+" " + BookDL.books[i].GetAuthor().getGender());
              //  Console.WriteLine(BookDL.books[i].getname() + BookDL.books[i].getPrice() + BookDL.books[i].getQuantity());
           // }
            BookDL.RemoveBook("All in all");
            for (int i = 0; i < BookDL.books.Count; i++)
            {
                Console.WriteLine(BookDL.books[i].GetAuthor().getEmail() + " " + BookDL.books[i].GetAuthor().getNameOfAuthor() + " " + BookDL.books[i].GetAuthor().getGender());
                Console.WriteLine(BookDL.books[i].getname() + BookDL.books[i].getPrice() + BookDL.books[i].getQuantity());
            }
            Console.ReadKey();

        }
    }
}
