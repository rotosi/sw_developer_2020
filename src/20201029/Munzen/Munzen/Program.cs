using System;

namespace Munzen
{
  class Program
  {
    static void Main(string[] args)
    {
      int inputCoint = 0;      
      int[] coint;

      coint = new int[5];
      coint[0] = 5;
      coint[1] = 10;
      coint[2] = 20;
      coint[3] = 50;
      coint[4] = 100;
      coint[4] = 200;

      Console.Write("Bitte eine gültige Münzbetrag eingeben bwz 5, 10,20, 50, 100, 200: ");
      inputCoint = int.Parse(Console.ReadLine());

      for (int i = 0; i < coint.Length; i++)
      {
        if (coint[i] == inputCoint)
        {
          Console.Write($"\tDein Münzbetrag {inputCoint} ist gültige");
        }
        else
        {
          Console.Write($"\tDein Münzbetrag {inputCoint} ist nicht gültige ");
        }
      }
    }
  }
}

