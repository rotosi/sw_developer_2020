using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCount = 10;

            for (int i = 0; i < maxCount; i++)
            {
                Console.WriteLine($"{i}. Durchlauf...");// para que empiece desde 1 y no desde 0 Console.WriteLine($"{i+1}. Durchlauf...");
            }

            Console.WriteLine();

            //for (int i = 21; i >= 0;  x = x -1 )
            //{
            //    Console.WriteLine($"Test: {i}");
            //}
        

                
                       
        }
    }
}
