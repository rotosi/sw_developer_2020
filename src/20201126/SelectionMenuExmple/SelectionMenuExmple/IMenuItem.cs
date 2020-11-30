using System;

namespace SelectionMenuExample
{
    public interface IMenuItem
    {
        string Description { get; }
        ConsoleKey Code { get; } // kein implementierung, es immer public in clase abstract

        bool Selectable { get; }
        bool Visible { get; set; }


        void Display(int width);
    }

    public interface IMenuItemWithUpdatebleSelectable : IMenuItem
    {
        void UpdateSelectable(bool newValue);
    }
}






