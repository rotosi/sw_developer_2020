using System;

namespace SelectionMenuExample.Items
{
    public class ColoredMenuItem : MenuItem
    {
        private ConsoleColor _itemColor;

        public ColoredMenuItem(string description, ConsoleKey code, ConsoleColor itemColor)
            : base(description, code) //se trae todo de la clase base que es Menu
        {
            _itemColor = itemColor;
        }

        public ConsoleColor ItemColor
        {
            get { return _itemColor; }
        }

        public override void Display(int width)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = _itemColor;

            base.Display(width);

            Console.ForegroundColor = oldColor;
        }
    }
} 
