using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenOperatoren
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arithmetische Operatoren
            // + - / * % 

            double erg = 0;
            double zahl1 = 5;
            double zahl2 = 2;
            
            erg = zahl1 + zahl2;
            string test = "Gandlaf" + "der  Wiese"; // concatenando dos palabras
            Console.WriteLine("Ergebnis + :" + erg);            

            erg = zahl1 / zahl2;
            Console.WriteLine("Ergebnis / :" + erg);

            erg = zahl1 % zahl2;
            Console.WriteLine("Ergebnis % :" + erg);

            // Math.Sin(); hacer ejercicios con esta biblioteca  
            erg = Math.Sin(zahl1);


            // Logische Operatoren 
            // & (&&) = AND //no hay diferencia si & o &&
            // | (||) = OR 
            // ! = NOT

            bool logikErgebnis = true;
            bool wert1 = true;
            bool wert2 = false;

            logikErgebnis = wert1 & wert2;
            Console.WriteLine("logikErgbnis:" + logikErgebnis);

            logikErgebnis = wert1 | wert2;
            Console.WriteLine("logikErgbnis:" + logikErgebnis);

            // vergleichsoperatoren
            // < > == != <= >=


            bool vergleichsErgebnis = 5 > 2; //=true
            vergleichsErgebnis = "Gandalf" == "Rocío"; //=false
            vergleichsErgebnis = "Gandalf" != "Rocío"; //=true

            //zusammengesetzte Operatoren 
            int zahl = 5;
            zahl = zahl + 3; // en nuevo valor (osea la suma de zahl +3) se guarda en la variable zahl1
            zahl1 += 3;

            zahl -= 5;            
            zahl *= 2;
            zahl /= 6;
            Console.WriteLine(zahl);

            // Inkrementieren / Dekrementieren
            zahl = zahl + 1; // incrementación
            zahl += 1;  //incrementación otra forma
            zahl++; //otra forma de incrementar prioridad baja (mas común)
            ++zahl; //prioridad alta
            zahl--; // decremetación
            --zahl;

            zahl = 5;
            Console.WriteLine("zahl:" + zahl); //5
            Console.WriteLine("zahl:" + zahl++); //5 lee y luego incrementa 
            Console.WriteLine("zahl:" + zahl++); //6 
            Console.WriteLine("zahl:" + ++zahl); //8 inclrementa y luego lee 
            Console.WriteLine("zahl:" + zahl++); //8
            



































        }
    }
}
