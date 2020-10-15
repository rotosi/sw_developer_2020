using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EingabenDezimalWerte
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthA = 0.0;
            double lengthB = 0.0;
            double result = 0.0;
            string input = string.Empty;

            // create header
            Console.WriteLine("############################################");
            Console.WriteLine("             Flächen Berechnung");
            Console.WriteLine("############################################");

            //display unput promt & get length values
            Console.WriteLine("Bitte Seitenlänge eingeben:\n");
            Console.WriteLine("\ta: ");
            input = Console.ReadLine();
            lengthA = double.Parse(input);

            Console.WriteLine("\tb: ");
            input = Console.ReadLine();
            lengthB = int.Parse(input);

            //calculate area of rectangle                                   
            result = lengthA * lengthB;

            //Display result            
            Console.WriteLine($"\nFläche des Rechtecks {lengthA} x {lengthB}):  {result}");


        }
    }
}
