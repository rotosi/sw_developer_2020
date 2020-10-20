using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = string.Empty;
            string input = "q";

            //kopfgesteuert
            while (input != "q")
            {
                Console.WriteLine("Bitte geben Sie etwas ein: "); //se usa cuando no se inicia input = string.Empty como q entonces hay probabilidad que entre una q
                input = Console.ReadLine();
            }

            //fussgesteuert
            do
            {
                Console.WriteLine("[do-while]:Bitte geben Sie etwas ein: "); //cuando almenos una vez va a entrar q usamos el do //input = "q"; no se pasa directo como el while
                input = Console.ReadLine();
            }
            while (input != "q");
        }
    }
}
