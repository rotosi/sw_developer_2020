using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodenGL
{
  class Program
  {
    static void Main(string[] args)


    {
      DisplayHello(); //se llama el metodo creado anteriormente solo con el nombre 
      DisplayHello();
      DisplayHello();
      DisplayHello();

      DisplayColorRedMessage("Hallo liebe Leute!", ConsoleColor.Yellow);
      DisplayColorRedMessage("Hallo liebe Leute!", ConsoleColor.Red);
      DisplayColorRedMessage("Hallo liebe Leute!", ConsoleColor.Green);

      double erg = CalculateWeight(20.0); //se declara una variable para del mismo tipo del metodo, se guarda el valor que se ingresa 20.20
      Console.WriteLine($"ergebnis: {erg}");



      Console.WriteLine($"Bitte Alter eingeben");
      string input = Console.ReadLine();
      int alter = GetInt(input);
      Console.WriteLine($"Alter: {alter}");

      int eineVariable = GetInt("Bitte länge eingeben");
      Console.WriteLine("Länger = "+ eineVariable);

      

      
      double gewicht = GetDouble("Gewicht eingeben");
      Console.WriteLine($"Das Gewicht ist {gewicht}.");

      DateTime getDate = GetDateTime("Gewicht eingeben");
      Console.WriteLine($"Das Gewicht ist {DateTime);
    }

    //signatur
    //Rückgabetyp Bezeichnung ( [Paramter] ) //in dieser Methode deie erste Bustabe des Name ist immer groß
    static void DisplayHello()
    {
      Console.WriteLine("Hello!");
    }

    static void DisplayColorRedMessage(string message, ConsoleColor messageColor)
    {
      ConsoleColor oldColor = Console.ForegroundColor;
      Console.ForegroundColor = messageColor;  //se compara si es el mismo color que tiene messageColor // ich mache ein set here (el color que tengo en messegeColor lo asigno a colosone.foregundColor)

      Console.WriteLine(message);

      Console.ForegroundColor = oldColor;

    }

    static double CalculateWeight(double nettoWeight)
    {
      double result = 0.0;

      result = nettoWeight * 1.25;

      return result; //lo que se va a retornar tiene que siempre ser una variable del tipo del metodo, en este caso es a double
    }


    ///<sumary>
    ///</sumary>
    static int GetInt(string inputPrompt)
    {
      int userInputValue = 0;
      bool userInputIsValid = false;

      do
      {
        Console.Write(inputPrompt);
        try
        {
          userInputValue = int.Parse(Console.ReadLine());
          userInputIsValid = true;
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error: {ex.Message}");
          userInputIsValid = false;
        }
      }
      while (!userInputIsValid);

      return userInputValue;
    }

    //==doble; string: DateTime

    static double GetDouble(string inputPrompt)
    {
      double userInputValue = 0;
      bool userInputIsValid = false;

      do
      {
        Console.Write(inputPrompt);
        try
        {
          userInputValue = double.Parse(Console.ReadLine());
          userInputIsValid = true;
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error: {ex.Message}");
          userInputIsValid = false;
        }
      }
      while (!userInputIsValid);

      return userInputValue;
    }

    static DateTime GetDateTime(string inputPrompt)
    { 
    DateTime userInputValue = DateTime.MinValue;
    bool userInputIsValid = false;

      string inputFormat = "dd.MM.yyyy hh:MM:ss";

      do
      {
        Console.Write(inputPrompt);
        try
        {
          userInputValue = DateTime.ParseExact(Console.ReadLine(), inputFormat, cultureInfo.InvariantCulture);
    userInputIsValid = true;
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error: {ex.Message}");
          userInputIsValid = false;
        }
      }
      while (!userInputIsValid);

      return userInputValue;
    }
    /// <summary>
    /// 
    /// read an 
    /// </summary>
    /// <param name="inputPrompt"></param>
    /// <returns></returns>
    static string getString(string inputPrompt)
    { 
    string userInputValue = string.Empty;
    bool userInputIsValid = false;
     
     Console.Write(inputPrompt);  
           

      return Console.ReadLine;
    }

  }
}
