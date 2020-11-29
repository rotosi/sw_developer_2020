using System;

namespace SelectionMenuExample.Items
{
    public class EmptyItem : IMenuItem
    {
        public EmptyItem()
        {
            //nothing to do
        }

        public string Description
        {
            get { return string.Empty; }
        }

        public ConsoleKey Code
        {
            get { return ConsoleKey.Spacebar; }
        }

        public bool Selectable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Visible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Display(int width)
        {
            Console.WriteLine();
        }
    }
}