using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodenGL
{
    class Program
    {
        static void Main(string[] args)


        {
            DisplayHello(); //se llama el metodo creado anteriormente solo con el nombre 
            DisplayHello();
            DisplayHello();
            DisplayHello();

            DisplayColorRedMessage("Hallo liebe Leute!", ConsoleColor.Yellow);
            DisplayColorRedMessage("Hallo liebe Leute!", ConsoleColor.Red);
            DisplayColorRedMessage("Hallo liebe Leute!", ConsoleColor.Green);

            double erg = CalculateWeight(20.0); //se declara una variable para del mismo tipo del metodo, se guarda el valor que se ingresa 20.20
            Console.WriteLine($"ergebnis: {erg}");


            Console.WriteLine($"Bitte Alter eingeben");
            string input = Console.ReadLine();
            int alter = GetInt(input);

            Console.WriteLine($"Alter: {alter}");

        }

        //signatur
        //Rückgabetyp Bezeichnung ( [Paramter] ) //in dieser Methode deie erste Bustabe des Name ist immer groß
        static void DisplayHello()
        {
            Console.WriteLine("Hello!");
        }

        static void DisplayColorRedMessage(string message, ConsoleColor messageColor)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = messageColor;  //se compara si es el mismo color que tiene messageColor // ich mache ein set here (el color que tengo en messegeColor lo asigno a colosone.foregundColor)

            Console.WriteLine(message);

            Console.ForegroundColor = oldColor;

        }

        static double CalculateWeight(double nettoWeight)
        {
            double result = 0.0;

            result = nettoWeight * 1.25;

            return result; //lo que se va a retornar tiene que siempre ser una variable del tipo del metodo, en este caso es a double
        }


        static int GetInt(String inputPromt)
        {
            int alter = 0;


            try
            {
                alter = int.Parse(inputPromt);

            }
            catch (Exception)
            {

                Console.WriteLine("Fehler falsche eingaben");
                Environment.Exit(1);
            }

            return alter;
        }



    }
}
