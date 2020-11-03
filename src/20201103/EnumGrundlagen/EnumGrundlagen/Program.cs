using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool participantSate = false; //true

            ParticipantState state = ParticipantState.Unbekannt;

            Console.ForegroundColor = ConsoleColor.DarkCyan; //este es un enum tambien donde tiene una gama de colores
            //Console.BackgroundColor = ConsoleColor.White; //el fondo de pantalla es blanco
            //Console.Clear(); 
            Console.WriteLine("test..."); //un ejemplo de el color que hemos elegido


            if (state == ParticipantState.Krank)
            {

            }

            switch (state) // switch -- tabulador se escribe la variable y luego enter (aparece los breaks)
            {
                case ParticipantState.Anwesend:
                    break;
                case ParticipantState.Abwensend:
                    break;
                case ParticipantState.Krank:
                    break;
                case ParticipantState.Unbekannt:
                    break;
                case ParticipantState.Abgemeldet:
                    break;
                default:
                    break;
            }

            Console.WriteLine($"State:{state}");
            Console.ResetColor();// solo imprime lo de la linea writeLine


            Console.WriteLine(); //cw and tabulador
            ///for (int i = 0; i < length; i++) // for and tabulador and it appears the full for it is also de the same with foreach
            //{

            //}       



        }
    }
}
