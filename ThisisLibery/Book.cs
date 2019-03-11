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
        Book harryPotter1 = new Book("The Philosopher's Stone");
        Book harryPotter2 = new Book("The Chamber of Secrets");
        Book harryPotter3 = new Book("The Prisoner of Azkaban");
        Book harryPotter4 = new Book("The Goblet of Fire ");
        Book harryPotter5 = new Book("The Order of the Phoenix");
        Book harryPotter6 = new Book("The Half-Blood Prince");
        Book harryPotter7 = new Book("The Deathly Hallows");
        Book harryPotter8 = new Book("Harry Potter and the Cursed Child");
    }
}
