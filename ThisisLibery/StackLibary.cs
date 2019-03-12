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
     //   public static List<string> bookAvaible = new List<string>() {"The Chamber of Secrets", "The Prisoner of Azkaban","The Goblet of Fire",
     //                                                            "The Order of the Phoenix", "The Half-Blood Prince", "The Deathly Hallows", "Harry Potter and the Cursed Child"};

        Book harryPotter1 = new Book("The Philosopher's Stone");
        Book harryPotter2 = new Book("The Chamber of Secrets");
        Book harryPotter3 = new Book("The Prisoner of Azkaban");
        Book harryPotter4 = new Book("The Goblet of Fire");
        Book harryPotter5 = new Book("The Order of the Phoenix");
        Book harryPotter6 = new Book("The Half-Blood Prince");
        Book harryPotter7 = new Book("The Deathly Hallows");
        Book harryPotter8 = new Book("Harry Potter and the Cursed Child");


        public static Stack bookStack = new Stack();
        public void StackFunction()
        {
            //The Peek() method returns the last (top-most) value from the stack.
            //The Push() method adds values into the Stack.
            //You can also retrieve the value using the Pop() method. The Pop() method removes and returns the value that was added last to the Stack. 
            //The Contains() method checks whether the specified item exists in a Stack collection or not.

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
                AddBooksToStack();
                RemoveFromList();
            }else
            { Console.WriteLine("No book");
            }

            //Checks if book is avaible
            //If it is avaible removes from list 
            //And adds it to the stack
            //if (bookAvaible.Contains(Program.userBook))
            //{
            //    AddBooksToStack();
            //    RemoveFromList();
            //}
            //else
            //{
            //    Console.WriteLine("Book is not here");
            //}
        }

        void RemoveFromList()
        {
            // bookAvaible.Remove(Program.userBook);
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
           

            ////For everybook we have
            //foreach (Book book in Book.Books)
            //{
            //    //If the name of the book we are looking at is the same as the book we want to remove
            //    if (book.Name == Program.userBook)
            //    {
            //        //Then remove the book
            //        Book.Books.Remove(book);
            //    }
            //}


        }
        
        public void BooksAvaible()
        {
            foreach (Book book in Book.Books)
            {
                Console.WriteLine(book.Name);
            }
        }

        void AddBooksToStack()
        {
            StackLibary.bookStack.Push(Program.userBook);
            Console.WriteLine("Book {0} added to stack", Program.userBook);
        }

        public void AddBooks()
        {
            //Book.Books.Add(harryPotter1);
            //Book.Books.Add(harryPotter2);
            //Book.Books.Add(harryPotter3);
            //Book.Books.Add(harryPotter4);
            //Book.Books.Add(harryPotter5);
            //Book.Books.Add(harryPotter6);
            //Book.Books.Add(harryPotter7);
        }
    }
}
