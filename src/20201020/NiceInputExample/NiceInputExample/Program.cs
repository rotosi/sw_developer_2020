using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceInputExample
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
           *  Der User soll sein Geburtsjahr eingeben. Daraufhin wird das Alter berechnet und ausgegeben.
           *  - Fehleingaben sollen abgefangen werden (fehlertolerante Eingabe)
           *  - der User soll nach einer Fehleingabe seine Eingabe wiederholen dürfen
           *  - die Anzahl der Versuche ist nicht begrenzt!
           *  - Gültiges Geburtsjahr:
           *      - nicht in der Zukunft
           *      - nicht vor 1870 (max. 150 Jahre) => 150 Jahre ab heute!
           *
           */

            int geburtsJahr = 0;
            int alter = 0;
            string input = string.Empty;
            int geburtsJahrZukunft = 2020;
            int geburtsJahrVergangenheit = 1870;
            const bool validgeburtsJahr = true; // esta es una variable global que se puede definir
            //en el metodo o fuera de este. Cuando es el método se usa solo ahi, y si se declara fuera se usará
            // en toda la clase. Tambien se puede fuera de clase definir


            Console.WriteLine("\nBitte dein Geburstsjahr angeben:\n");
            input = Console.ReadLine();
            geburtsJahr = int.Parse(input);//una de las formas de parsear un entero



            try
            {
                //while (validgeburtsJahr == true)

                if (geburtsJahr < geburtsJahrZukunft)
                {
                    if (geburtsJahr >= geburtsJahrVergangenheit)
                    {
                        alter = DateTime.Now.Year - geburtsJahr;
                        //Alter berechnen
                        alter = DateTime.Now.Year - geburtsJahr;
                        //Ausgabe Ergebnis
                        Console.WriteLine($"Sie sind {alter} Jahre jung!");
                    }
                    else
                    {
                        Console.WriteLine("Geburstsjahr format ist ungültig");
                        Console.WriteLine("\nBitte dein Geburstsjahr angeben:\n");
                        input = Console.ReadLine();
                        geburtsJahr = int.Parse(input);
                    }
                }
                else
                {
                    Console.WriteLine("Geburstsjahr format ist ungültig");
                    Console.WriteLine("\nBitte dein Geburstsjahr angeben:\n");
                    input = Console.ReadLine();
                    geburtsJahr = int.Parse(input);
                }

                // while (validgeburtsJahr == true)// es un boolean no tenemos que comprobar de nuevo se deja (validgebursJahr)    



            }
            catch (Exception e)
            {
                Console.WriteLine("\nUpps! Leider ist was schief gelaufen:" + e.Message);
                Console.WriteLine(e.Message);
                Console.WriteLine("Source: \n" + e.StackTrace);

                Environment.Exit(1);
            }
        }
    }
}







