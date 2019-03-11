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
        public static List<string> bookAvaible = new List<string>() { "The Philosopher's Stone", "The Chamber of Secrets", "The Prisoner of Azkaban","The Goblet of Fire",
                                                                 "The Order of the Phoenix", "The Half-Blood Prince", "The Deathly Hallows", "Harry Potter and the Cursed Child"};
        public static Stack bookStack = new Stack();
        public void StackFunction()
        {
            //The Peek() method returns the last (top-most) value from the stack.
            //The Push() method adds values into the Stack.
            //You can also retrieve the value using the Pop() method. The Pop() method removes and returns the value that was added last to the Stack. 
            //The Contains() method checks whether the specified item exists in a Stack collection or not.


            //Checks if book is avaible
            //If it is avaible removes from list 
            //And adds it to the stack
            if (bookAvaible.Contains(Program.userBook))
            {
                AddBooksToStack();
                RemoveFromList();
            }
            else
            {
                Console.WriteLine("Book is not here");
            }
        }

        void RemoveFromList()
        {
            bookAvaible.Remove(Program.userBook);
        }
        
        public void BooksAvaible()
        {
            foreach (string a in bookAvaible)
            {
                Console.WriteLine(a);
            }
        }

        void AddBooksToStack()
        {
            StackLibary.bookStack.Push(Program.userBook);
            Console.WriteLine("Book {0} added to stack", Program.userBook);
        }

        public void AddBooks()
        {
            //bookAvaible.Add("The Philosopher's Stone");
            //bookAvaible.Add("The Chamber of Secrets");
            //bookAvaible.Add("The Prisoner of Azkaban");
            //bookAvaible.Add("The Goblet of Fire");
            //bookAvaible.Add("The Order of the Phoenix");
            //bookAvaible.Add("The Half-Blood Prince");
            //bookAvaible.Add("The Deathly Hallows");
            //bookAvaible.Add("Harry Potter and the Cursed Child");
        }
    }
}
