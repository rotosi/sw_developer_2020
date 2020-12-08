using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamvdaGrunlagen
{

    public delegate void DoSomethingHandler<T>(string message);
    class Program
    {
        static void Main(string[] args)
        {
            DoSomethingHandler<string> myAction = DisplayMessage;
            myAction("Hello Welt");


            Action<string> myNewAction = DisplayMessage;
            

            //anomyme Methode (c# 2.0) //esto es un metodo anónimo no tiene nombre solo asignture 
            //se puede usar solo en el main no desde otro lado
            myAction = delegate (string userText)
            {
                Console.WriteLine("Ausgabe anoyme Methode:");
                Console.WriteLine(userText);
            };

            myAction("Invoke anoyme Methode"); //esta es la forma de invocar este metodo desde aqui solamente 

            //anomyme Methode (c# 3.0)
            myAction = (string userText) =>
            {
                Console.WriteLine("Ausgabe vereinfachte anonyme Methode:");
                Console.WriteLine(userText);
            };

            myAction = userText =>
            {
                Console.WriteLine("Ausgabe vereinfachte anonyme Methode:");
                Console.WriteLine(userText);
            };

            myAction = x => Console.WriteLine(x);
            myAction("Test");

            int[] zahlenReihe = new int[] { 5, 21, 8, 9, 22, 50, 1, 96 };
           // zahlenReihe = zahlenReihe.Where(CheckSizeRToFive).ToArray();
            zahlenReihe = zahlenReihe.Where(x => x > 10).ToArray();
            zahlenReihe = zahlenReihe.Select(x =>  x * x).ToArray();


            List<int> sortedElements = new List<int>();
            foreach (var item in zahlenReihe)
            {
                if (item > 10)
                {
                    sortedElements.Add(item);
                }
            }
            zahlenReihe = sortedElements.ToArray();

            //Func<int, bool> myFuntion = CheckSize; //int ist parameter  bool recovert
        }

        static bool CheckSize(int number)
        {
            return number > 10;
        }

        static bool CheckSizeRToFive(int number)
        {
            return number > 5;
        }

        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
