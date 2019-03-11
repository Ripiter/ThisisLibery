using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisisLibery
{
    class Program
    {
        public static string userBook;
        public string userMenu;


        static void Main(string[] args)
        {
            Program a = new Program();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu 1 or 2");
                a.userMenu = Console.ReadLine();

                a.Menu();

                Console.ReadLine();
            }
        }




        void Menu() {
            switch (userMenu)
            {
                case "1":
                    TakeBook();
                    break;
                case "2":
                    ReturnBuk();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }



        void TakeBook()
        {
            StackLibary stack = new StackLibary();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Books avaible");
                stack.BooksAvaible();
                Console.WriteLine("");
                Console.WriteLine("What book you want to take?");
                userBook = Console.ReadLine();

                stack.StackFunction();
                return;
            }
        }
            void ReturnBuk()
            {
                UserReturnBook urb = new UserReturnBook();
                urb.ReturnBooks();
            }
    }
}
