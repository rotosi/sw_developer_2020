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
            RandomAdv rnd = new RandomAdv();

            Console.WriteLine($"Zuällige Zahl (1-10): {rnd.Next(1,11)}");

            Console.WriteLine($"Zuälliger string: {rnd.NextString(15)}");


        }
     
     }
}

