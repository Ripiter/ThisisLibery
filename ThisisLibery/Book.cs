using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisisLibery
{
    class Book
    {
        string name;

        public static List<Book> Books
        {
            get
            {
                return books;
            }
            set
            {
                books = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
            }
        }

        static List<Book> books = new List<Book>();
        public Book(string name)
        {
            this.name = name;
            books.Add(this);
        }   
    }
}
