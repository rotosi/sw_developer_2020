using System;

namespace ExceptionAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var testClass = new TestClass(); //instansierung
            try
            {
                testClass.Calculate(5, 0); //estos son los valores que se le dan para que los procesen el programa 
            }
            catch (CalculationImpossibleExeption cex)
            {
                Console.WriteLine("Eine CalculationImpossibleExeption wurde abgefangen:");
                Console.WriteLine($"ERROR. {cex.Message}");
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine($"ERROR. {aex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR. {ex.Message}");
            }
        }
    }
}
