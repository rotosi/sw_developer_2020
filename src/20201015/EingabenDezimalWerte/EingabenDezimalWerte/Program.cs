using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EingabeDezimalWerte
{
    class Program
    {
        static void Main(string[] args)
        {
            /*############################################
             *              Flächen Berechnung
             *############################################ 
             * 
             * Bitte Seitenlängen angeben:
             * 
             *  a: ?????
             *  b: ?????
             *                 
             * Fläche des Rechtecks (a x b): 3165421
             *                
             */

            double lengthA = 0.0;
            double lengthB = 0.0;
            double calculatedRectangleArea = 0.0;
            int headerXPosition = 0;
            string headerText = " Flächen Berechnung";

                   

            // create header
            //###" => new string (new string (#, 3)
            Console.WriteLine(new string('#', Console.WindowWidth - 1));
            headerXPosition = (Console.WindowWidth - headerText.Length) / 2;
            Console.CursorLeft = headerXPosition;
            Console.WriteLine("             Flächen Berechnung");
            Console.WriteLine(new string('#', Console.WindowWidth - 1));

            //display input prompt & get length values
            Console.WriteLine("\nBitte Seitenlängen angeben:\n");
            Console.Write("\ta: ");

            try //se ubica el try donde exactamente el codigo es mas sencible, no desde el principio del código
            {
                lengthA = double.Parse(Console.ReadLine());

            Console.Write("\tb: ");            
            lengthB = double.Parse(Console.ReadLine());

            }

            catch (Exception e)
            {
                Console.WriteLine("\nUpps! Leider ist was schief gelaufen:" + e.Message); //e.message se puede poner asi para reducir lineas 
                Console.WriteLine(e.Message); //aqui imprime el error que se ha generado 
                Console.WriteLine("Source: \n" + e.StackTrace);// optimizar el codigo, con esta linea dice exactamente donde está el error y cual es el error 

                Environment.Exit(1); //se produce un error y se sale del codigo de una vez cuando se usa 1
            }


            //finally // esto se ejecuta da igual que ha pasado antes en el código. Es opcional 
            //{

           // }

            //calculate area of rectangle
            calculatedRectangleArea = lengthA * lengthB;

            //display result
            Console.WriteLine($"\nFläche des Rechtecks ({lengthA} x {lengthB}): {calculatedRectangleArea}");                       

            

           
            Console.WriteLine("Program Ende!");

        }
    }
}
