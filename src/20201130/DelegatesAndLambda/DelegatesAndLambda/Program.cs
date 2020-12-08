using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambda
{
    //type spezifikation
    public delegate void DoSomehingHandler(string message); // 

    class Program
    {
        static void Main(string[] args)
        {
            DoSomehingHandler myAction; //date typen in c#
            DoSomehingHandler[] myActionList = new DoSomehingHandler[2];


            //Mrethode als WERT zuweisen
            // myAction = DisplayMessage;
            myAction = CreateOutput;
            myAction("Hallo!");

            myActionList[0] = CreateOutput;
            myActionList[1] = DisplayMessage;

            //Methode über delegate aufrufen
            //myAction("Hallo Welt!");
            foreach (var method in myActionList)
            {
                Console.WriteLine($"Invoke: {method.Method.Name}:");
                method("Wie coll ist denn das?");
            }

        }

        static void CreateOutput(string text)
        {
            Console.WriteLine("... creating output now:");
            Console.WriteLine("\t{0}", text.ToUpper());
        }

        static void DisplayMessage(string userMessage)
        {
            Console.WriteLine(userMessage);
        }
    }
}
