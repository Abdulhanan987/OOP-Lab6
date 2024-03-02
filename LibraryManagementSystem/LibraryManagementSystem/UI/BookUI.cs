using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class BookUI
    {
        static public void addBook()
        {
            Console.WriteLine("Enter the book name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the book price: ");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the book Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the author name: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter the author email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the author gender: ");
            char gender = char.Parse(Console.ReadLine());
        }
    }
}
