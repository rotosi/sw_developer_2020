using System;

namespace SelectionMenuExample
{
    public interface IMenuItem
    {
        string Description { get; }
        ConsoleKey Code { get; } // kein implementierung, es immer public in clase abstract

        bool Selectable { get; set; }
        bool Visible { get; set; }


        void Display(int width);
    }
}






