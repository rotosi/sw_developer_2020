using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeilnehmerVerwaltung_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Anzahl der Teilnehmer einlesen!             
             * - Für jeden Teilnehmer Name und (Geburtsjahr) einlesen             
             * - Ausgabe tabelarisch alle Teilnehmerinformationen
             *              
             * */

            int participantCount = 0;
            string[] participantNames;
            int[] geburtsJahr;
            int inputGeburtsJahr;

            //Anzahl der Teilnehmer einlesen
            Console.Write("Bitte die Anzahl der Teilnehmer eingeben: ");
            participantCount = int.Parse(Console.ReadLine());

            //Teilnehmerlist erzeugen & initialisieren
            participantNames = new string[participantCount];
            geburtsJahr = new int[participantCount];
            for (int i = 0; i < participantNames.Length; i++)
            {
                participantNames[i] = string.Empty;
            }

            //Teilnehmernamen einlesen
            for (int i = 0; i < participantNames.Length; i++)
            {
                Console.Write($"Bitte Name Teilnehmer {i + 1} eingeben: ");
                participantNames[i] = Console.ReadLine();

               Console.Write($"Bitte das Geburtsjahr des Teilnehmer {i + 1} eingeben: ");
               inputGeburtsJahr = int.Parse(Console.ReadLine());   
               geburtsJahr[i] = inputGeburtsJahr;
            }

            //Ausgabe der Teilnehmernamen
            Console.WriteLine("\nLister der Teilnehmer:");
            for (int i = 0; i < participantNames.Length; i++)
            {
                Console.WriteLine($"\t{participantNames[i]}");
                Console.WriteLine($"\t{geburtsJahr[i]}");
            }
        }
    }
}

//using System;

//namespace Munzen
//{
//  class Program
//  {
//    static void Main(string[] args)
//    {
//      int inputCoint = 0;      
//      int[] coint;

//      coint = new int[5];
//      coint[0] = 5;
//      coint[1] = 10;
//      coint[2] = 20;
//      coint[3] = 50;
//      coint[4] = 100;
//      coint[4] = 200;

//      Console.Write("Bitte eine gültige Münzbetrag eingeben bwz 5, 10,20, 50, 100, 200: ");
//      inputCoint = int.Parse(Console.ReadLine());

//      for (int i = 0; i < coint.Length; i++)
//      {
//        if (coint[i] == inputCoint)
//        {
//          Console.Write($"\tDein Münzbetrag {inputCoint} ist gültige");
//        }
//        else
//        {
//          Console.Write($"\tDein Münzbetrag {inputCoint} ist nicht gültige ");
//        }
//      }
//    }
//  }
//}
