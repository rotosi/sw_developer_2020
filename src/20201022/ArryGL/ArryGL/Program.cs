using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArryGL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration
            int zahl;
            int[] zahlen; //datentype inarea. se define una lista   //declaracion es siempre al principio y luego se hace la dimensión 

            //Dimensionierung 
            zahlen = new int[5]; //la cantidad 

            //Inizialisierung
            zahl = -2;


            zahlen[0] = 50; //[0]este es el index, aqui se define que en esa posicion tiene un valor de 50
            zahlen[1] = 0;
            zahlen[2] = 10;
            zahlen[3] = 20;
            zahlen[4] = 30;
            //zahlen[5] = 300; //index autorage esto significa que el valor zahlen 5 es una posicion que no exite por que es de solo 5

            zahlen[0] = zahlen[1] + zahlen[2];

            //Ausgabe der Inhalte aus dem Array
            //Console.WriteLine($"Element 1: {zahlen[0]}");
            //Console.WriteLine($"Element 2: {zahlen[1]}");
            //Console.WriteLine($"Element 3: {zahlen[2]}");
            //Console.WriteLine($"Element 4: {zahlen[3]}");
            //Console.WriteLine($"Element 5: {zahlen[4]}");
           

            for (int i=0; i <zahlen.Length; i++) //length especificamos la dimension de este arreglo
            {
                Console.WriteLine($"Element  {i + 1}: {zahlen[1]} ");
            }

        }
    }
}
