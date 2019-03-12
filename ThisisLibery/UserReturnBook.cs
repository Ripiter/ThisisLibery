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
            Console.Clear();
            Console.WriteLine("Books avaible:");
            int i = -1;
            int temp = -1;
            //Write's if there are any books
            //And if there is write all the books
            foreach (string e in StackLibary.bookStack)
            {
                Console.WriteLine(e);
                if(e == null)
                {
                    temp = i;
                }
                i++;
            }
                if (i == -1)
                {
                    Console.WriteLine("No book");
                }
                else
                {
                    ReturnB();
                }
                

        }
        

        void ReturnB()
        {
            Console.WriteLine("Do you want to return the book? yes/no");
            userI = Console.ReadLine().ToLower();
            if (userI != "yes")
                return;           
            //Reason its in try catch is to avoid error that .pop() shows if there are no elements to remove
            try
            {
                //Create's the book that uses stack.pop to create itself
                Book a = new Book(StackLibary.bookStack.Pop().ToString());
            }
            catch
            {
                Console.WriteLine("No book to return");
            }

        }
    }
}
