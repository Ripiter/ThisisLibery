using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisisLibery
{
    class UserReturnBook
    {
        public string userI;
        public void ReturnBooks()
        {
            StackLibary stackBooks = new StackLibary();
            
            //Write's if there are any books
            try
            {
                foreach(string e in StackLibary.bookStack)
                {
                    Console.WriteLine(e);
                }
            }
            catch
            {
                Console.WriteLine("No book");
            }

            Console.WriteLine("Do you want to return the book? yes/no");
            userI = Console.ReadLine().ToLower();
            if (userI == "yes")
                ReturnB();            
        }


        void ReturnB()
        {
            try
            {
                //Set book back to the list, sadly at the end of the index
                StackLibary.bookAvaible.Add(StackLibary.bookStack.Pop().ToString());
            }
            catch
            {
                Console.WriteLine("No book to return");
            }

        }
    }
}
