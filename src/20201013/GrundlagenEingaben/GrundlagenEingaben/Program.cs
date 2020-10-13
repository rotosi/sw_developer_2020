using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenEingaben
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;

            Console.Write("Bitte Name eingeben: "); // recibe la varible entrada por pantalla
            name = Console.ReadLine(); //lee la linea que se ha entrado antes  con el Write

            Console.WriteLine("Hallo " +  name + "!");


            #region MyRegion
            Console.WriteLine($"Hallo {name}!"); // para los siguientes ejercicios debemos eimprimir asi en este formato

            string ausgabe = $"Liber {name}, {name} ist ein shöner Name!";
            Console.WriteLine(ausgabe);

            //segunda variación
            Console.WriteLine("Hallo {0}!", name); //antes de la coma (primer parametro) se define el fotmato y despues de la coma (segundo parámetro) el argumento {0} la variable
            int zahl1 = 5; //{1}
            int zahl2 = 2; //{2}
            int erg = zahl1 + zahl2;

            Console.WriteLine("Die Sume von {1} + {2} ergibt {0}.", erg, zahl1, zahl2);

            string newOoutputString = String.Format("Die Sume von {1} + {2} ergibt {0}.", erg, zahl1, zahl2); 
            #endregion



        }
    }
}
