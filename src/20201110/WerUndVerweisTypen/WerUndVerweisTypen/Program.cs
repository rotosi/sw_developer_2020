using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerUndVerweisTypen
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();

            myBook.Title = "Die unendliche Geschichte";
            myBook.Author = "Michael Ende";
            myBook.Price = 15.99m;

            Book dummyBook = null; //no se puede asignar directamente a null por que puede dar una null exeption hay que manejar este valor 
            Book myNewBook = myBook;
            //int x = 4;
            //int y = x;

            //bool erg = x ==y;
            bool erg = myBook == myNewBook;
            Console.WriteLine($"Ergebnis Vergleich: {erg}");

            myBook.Title = "Vom Mythos des Mann-Monats";

            DisplayBookInfos(myBook);
            Console.WriteLine($"Ausgabe im Main(): {myBook.Title}");
            DisplayBookInfos(myNewBook);
        }

        static void DisplayBookInfos(Book bookToDisplay)
        {
            
            Console.WriteLine($"'{bookToDisplay.Title.ToUpper()}' von {bookToDisplay.Author} => EUR {bookToDisplay.Price}"); //ToUpper mara las mayusculas

            bookToDisplay.Title += "[Modified]" + bookToDisplay.Title;
        }
    }
}
