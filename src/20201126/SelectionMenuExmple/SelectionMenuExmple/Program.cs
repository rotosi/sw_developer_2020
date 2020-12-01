using SelectionMenuExample.Items;
using SelectionMenuExmple.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string myData = "Meine Daten";
            ApplicationParameters applicationParameters = new ApplicationParameters();

            IMenu<ApplicationParameters> myMenu = new Menu<ApplicationParameters>();

            //creat selection menu
            myMenu = CreateMenu();

            //myMenu.LoadFromFile("menufile.txt");
            while (true)
            {
                myMenu.Display(35);

                var mySelection = myMenu.SelectItem("Ihre Wahl: ");


                Console.WriteLine($"\nIhre Auswahl: {mySelection.Description}");

                //start execution
                mySelection.Execute(applicationParameters); //este metodo fue definido en la interface IMenuItem            
            }
        }

        private static IMenu<ApplicationParameters> CreateMenu()
        {

            var myMenu = new Menu<ApplicationParameters>(); //metodo

            myMenu.Add(new MenuItem<ApplicationParameters>("Daten laden", ConsoleKey.F1, DatenLaden));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten speichern", ConsoleKey.F2, DatenSpeichern));
            myMenu.Add(new SeparatorItem<ApplicationParameters>('~'));
            myMenu.Add(new EmptyItem<ApplicationParameters>());
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten löschen", ConsoleKey.F3, DatenLoeschen));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten drucken", ConsoleKey.F4, x => Console.WriteLine($"DatenDrucken")));
            myMenu.Add(new EmptyItem<ApplicationParameters>());
            myMenu.Add(new ColoredMenuItem<ApplicationParameters>("Ende", ConsoleKey.Escape, ConsoleColor.Yellow, Ende));

            return myMenu;
        }

        private static void Ende(ApplicationParameters obj)
        {
            Environment.Exit(0);
        }

        private static void DatenDrucken(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void DatenLoeschen(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void DatenSpeichern(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void DatenLaden(ApplicationParameters obj)
        {
            Console.WriteLine($"\n\nDaten werden nun geladen...");
        }
    }
}