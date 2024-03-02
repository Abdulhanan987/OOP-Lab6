using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        private string Name;
        private float Price;
        private int Quantity;
        private Author authors;
        public Book(string bookname,float price,int quantity,string name , string email, char gender)
        {
            authors = new Author(name,email,gender);
           Name = bookname;
            Price = price;
            Quantity = quantity;

        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public void setPrice(int price) 
        {
            this.Price = price;
        }
        public void setQuantity(int quantity)
        {
            this.Quantity = quantity;
        }

        public string getname()
        {
            return this.Name;
        }
        public float getPrice()
        {
            return Price;
        }
        public int getQuantity()
        {
            return Quantity;
        }
        public Author GetAuthor()
        {
            return authors;
        }
    }
}
