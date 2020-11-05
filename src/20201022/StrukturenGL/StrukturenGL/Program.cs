using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturenGL.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration
            Teilnehmer einTeilnehmer = new Teilnehmer();

            int[] zahlen;
            string[] name;
            Teilnehmer[] meinTeilnehmer;

            //meinTeilnehmer[3].Vorname;
            //Initialisierung
            einTeilnehmer.Vorname = "Max";
            einTeilnehmer.NachName = "Musterman";
            einTeilnehmer.geburtsdatum = new DateTime(1980, 4, 16);

            Console.WriteLine($"{einTeilnehmer.Vorname} {einTeilnehmer.NachName}"); //imprimimos en una misma linea dos valores 

        }
    }
}
