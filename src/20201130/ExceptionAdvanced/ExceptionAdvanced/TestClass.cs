using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAdvanced
{
   public class TestClass
    {
        public void Calculate(double z1, double z2)
        {
            if (z1 == 0)
            {
                //throw new ArgumentException("z1 oder z2 ist 0. Dies ist nicht erlaubt."); //ayuda a identificar un error 
                throw new CalculationImpossibleExeption("z1"); //ayuda a identificar un error 
            }
            if (z2 == 0)
            {                
                throw new CalculationImpossibleExeption("z2"); 
            }

            Console.WriteLine("Berechnung gestartet ...");
        }
    }
}
