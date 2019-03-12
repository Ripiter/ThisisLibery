using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisisLibery
{
    class StackLibary
    {
        Book harryPotter1 = new Book("The Philosopher's Stone");
        Book harryPotter2 = new Book("The Chamber of Secrets");
        Book harryPotter3 = new Book("The Prisoner of Azkaban");
        Book harryPotter4 = new Book("The Goblet of Fire");
        Book harryPotter5 = new Book("The Order of the Phoenix");
        Book harryPotter6 = new Book("The Half-Blood Prince");
        Book harryPotter7 = new Book("The Deathly Hallows");
        Book harryPotter8 = new Book("Harry Potter and the Cursed Child");


        public static Stack bookStack = new Stack();
        public string StackFunction()
        {
            string gotIt;
            //The Peek() method returns the last (top-most) value from the stack.
            //The Push() method adds values into the Stack.
            //You can also retrieve the value using the Pop() method. The Pop() method removes and returns the value that was added last to the Stack. 
            //The Contains() method checks whether the specified item exists in a Stack collection or not.

            //I keep a track of how many time we have went thru
            //And when we find the one we are looking for we set temp to i
            int i = 0;
            int temp = -1;
            foreach (Book book in Book.Books)
            {
                i++;
                if (book.Name == Program.userBook)
                {
                    temp = i;
                }

            }
            if (temp >= 0)
            {
                gotIt = AddBooksToStack();
                RemoveFromList();
            }else
            {
                gotIt = "No book with that name";
            }
            return gotIt;
        }

        void RemoveFromList()
        {
            //We use i and temp to keep track of the foreach loop
            int i = 0;
            int temp = -1;
            //For everybook we have
            foreach (Book book in Book.Books)
            {
                //If the name of the book we are looking at is the same as the book we want to remove
                if (book.Name == Program.userBook)
                {
                    temp = i;
                }
                i++;

            }
                if (temp >= 0) 
                    Book.Books.RemoveAt(temp);
        }
        
        public void BooksAvaible()
        {
            foreach (Book book in Book.Books)
            {
                Console.WriteLine(book.Name);
            }
        }

        string AddBooksToStack()
        {
            StackLibary.bookStack.Push(Program.userBook);
            //   Console.WriteLine("Book {0} added to stack", Program.userBook);
            string gotIt = ("Book " + Program.userBook + " added to stack");
            return gotIt;
        }
    }
}
