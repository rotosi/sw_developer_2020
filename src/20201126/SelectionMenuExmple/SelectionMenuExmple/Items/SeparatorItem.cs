using SelectionMenuExample.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExmple.Items
{
    public class SeparatorItem : MenuItem
    {
        private char _separator;
        public SeparatorItem(char separator) : base(string.Empty, ConsoleKey.Spacebar)
        {
            _separator = separator;
            UpdateSelectable(false);
        }

        public char Separator
        {
            get { return _separator; }
            set { _separator = value; }
        }

        public override void Display(int width)
        {
            base.Display(width);
            
            if (Visible)
            {
                Console.WriteLine(new string(_separator, width));
            }
        }
    }
}
