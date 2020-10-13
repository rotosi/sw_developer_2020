using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EingabenNumerischeWerte
{
    class Program
    {
        static void Main(string[] args)
        {
            int geburtsJahr = 0;
            int alter = 0;
            string input = string.Empty;

            //Geburtsjahr einlesen
            Console.WriteLine("Bitte Geburstjahr eingeben: " );
            input = Console.ReadLine();
            geburtsJahr = int.Parse(input);  //estamos pareceando un string  a int //se puede hacer con diferente formatos double, float 

            //Alter berechnen
            alter = DateTime.Now.Year - geburtsJahr;

            //Ausgabe Ergebnis
            Console.WriteLine($"Sie sind {alter} Jahre jung!");


        }
    }
}
