using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DantenGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaration
            int zahl;

            //initialisierung
            zahl = 9;

            //Deklaration & Initialisierung
            int zahl1 = 5;

            Console.WriteLine(zahl);
            zahl = int.MaxValue;

            //Dezimalzahlen: float, double, decimal
            double size_x = 15.321;

            Console.WriteLine("Size X = " + size_x);

            decimal preis = 15.50m; //m dezimal

            string name = "Gandalf";
            name = " ";
            name = string.Empty; //una definición mas elegante para declarar una variable vacía tipo string
                                 //name.Length; //que tal grande es  este string 

            char symbol = 'a'; //se usa para inicializar un solo caracter

            bool isPowerOn = true;

        }
    }
}
