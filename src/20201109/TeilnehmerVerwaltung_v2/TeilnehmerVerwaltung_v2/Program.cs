using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Wifi.Tool.library.ConsoleIo;

namespace TeilnehmerVerwaltung_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Schreiben Sie eine einfache Applikation mit der Teilnehmer verwaltet werden können.
             * Teilnehmerdaten sollen:
             * 
             * Eingabe
             * tabellarische Ausgabe 
             * Ausgabe in eine Text-Datein (wahlweise)
             * 
             * Welche Teilnehmerdaten:
             * 
             * - Name & Nachname
             * - Strasse, HausNr, Plz, Ort
             * - Geburstdatum             *               
             */

            bool saveDataToFile = false;
            string userInput = string.Empty;
            
            Teilnehmer teilnehmer;                       
            teilnehmer = GetTeilnehmer($"Bitte Teilnehmer eingeben:");
            Console.WriteLine($"Teilnehmer:" + teilnehmer.VorName);
            Console.WriteLine($"Teilnehmer:" + teilnehmer.Nachname);
            Console.WriteLine($"Teilnehmer:" + teilnehmer.Geburtsdatum);

        }

        static Teilnehmer GetTeilnehmer(string infoTeilnehmer)
        {
            Console.WriteLine(infoTeilnehmer);
            Teilnehmer teilnehmer = new Teilnehmer();
           


            Console.Write("\tVorname: ");
            teilnehmer.VorName = Console.ReadLine();

            Console.Write("\tNachmame: ");
            teilnehmer.Nachname = Console.ReadLine();

            Console.Write("\tGeburtsdatum: ");
            teilnehmer.Geburtsdatum = DateTime.Parse(Console.ReadLine());

            Console.Write("\tStraße: ");
            teilnehmer.Starsse = Console.ReadLine();

            Console.Write("\tPlz: ");
            teilnehmer.Plz = int.Parse(Console.ReadLine());

            Console.Write("\tOrt: ");
            teilnehmer.Ort = Console.ReadLine();

            return teilnehmer;
            // en la solucion del profesor usa array por que se van a introducir mas de un Teilnehmer 10 e.g.
        }
    }
}
