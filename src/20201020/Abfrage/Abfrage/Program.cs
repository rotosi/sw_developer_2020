﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abfrage
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 50;
            int zahl2 = 15;

            if (zahl1 > zahl2)
            {
                Console.WriteLine($"{zahl1} ist grösser als {zahl2}.");
            }
            if (DateTime.Now.Month == 10)
            {
                Console.WriteLine("Wir haben jetzt Oktober ...");
            }
            else
            {
                Console.WriteLine("Keine Ahnung welchen Monat wir haben");
            }

            if (zahl1 > zahl2 && DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {


            }

            //if (raidSystem != null && raisSystem.isfull != false) //& und solo uno resutado es 1, cuando es && oder 
            //{
                
            //} control k + control C to coment the code selected

        }
    }
}
