using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_Grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Anzahl der Teilnehmer einlesen!             
             * - Für jeden Teilnehmer Name und (Geburtsjahr) einlesen             
             * - Ausgabe tabelarisch alle Teilnehmerinformationen
             * */

            int participantCount = 0;
            string[] participantNames; //lista

            //Anzahl der Teilnehmer einlesen
            Console.Write("Bitte die Anzahl der Teilnehmer eingeben: ");
            participantCount = int.Parse(Console.ReadLine()); //parsear todo en una misma liena

            //Teilnehmerlist erzeugen & initialisieren
            participantNames = new string[participantCount]; //este es el tamano del arreglo que en este caso entra el usuario participantCount
            for (int i = 0; i < participantNames.Length; i++)
            {
                participantNames[i] = string.Empty;
            }

            //Teilnehmernamen einlesen
            for (int i = 0; i < participantNames.Length; i++)
            {
                Console.Write($"Bitte Name Teilnehmer {i + 1} eingeben: ");
                participantNames[i] = Console.ReadLine();
            }

            //Ausgabe der Teilnehmernamen
            Console.WriteLine("\nLister der Teilnehmer:");
            foreach (string participant in participantNames) //para cada participante en (in) esta lista "participantNames" haz lo que sale en console (imprima cada uno)
            {
                Console.WriteLine($"\t{participant}"); //la valirable participant no se puede utilizar afuera, es unica para el foreach. Esa es una diferencia entre for y foreach. Se utiliza para una lista
            }
        }
    }
}
