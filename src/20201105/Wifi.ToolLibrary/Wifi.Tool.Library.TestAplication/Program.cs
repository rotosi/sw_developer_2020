using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wifi.Tool.Library.ConsoleIo;

namespace Wifi.Tool.Library.TestAplication                                                                                                                                                                                        
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleTools.DisplayColoredMessage("Dies ist ein Test ..", ConsoleColor.Yellow);

            double val1 = ConsoleTools.GetDouble("Bitte wert Eingeben: ");

            Console.WriteLine($"Der Wert war: {val1}");
            ConsoleTools.DisplayColoredMessage("Test", ConsoleColor.Yellow);

            ConsoleTools.DisplayColoredMessage("hallo");

            Console.ReadLine();

          
        }
    }
}
