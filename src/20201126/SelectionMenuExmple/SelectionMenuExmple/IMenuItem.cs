using System;

namespace SelectionMenuExample
{
    public interface IMenuItem<T>
    {
        string Description { get; }
        ConsoleKey Code { get; } // kein implementierung, es immer public in clase abstract

        bool Selectable { get; }
        bool Visible { get; set; }


        void Display(int width);

        void Execute(T executionParamenter);
    }
    
}






