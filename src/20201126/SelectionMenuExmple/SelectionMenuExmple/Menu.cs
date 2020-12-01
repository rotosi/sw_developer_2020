using SelectionMenuExample.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExample
{
    public class Menu<T> : IMenu<T>
    {
        private List<IMenuItem<T>> _items;

        public Menu()
        {
            _items = new List<IMenuItem<T>>();
        }


        public int Count
        {
            get { return _items.Count; }
        }

        internal void Add(MenuItem<T> menuItem) //IMenuItem <T>
        {
            throw new NotImplementedException();
        }

        public void Add(IMenuItem<T> menuItem)
        {
            _items.Add(menuItem);
        }

        public void Remove(IMenuItem<T> menuItem)
        {
            _items.Remove(menuItem);
        }

        public void Display(int width)
        {
            foreach (var menuItem in _items)
            {
                menuItem.Display(width);
            }

            Console.WriteLine();
        }

        public IMenuItem<T> SelectItem(string inputPrompt)
        {
            while (true) //var cuando se declara una variable tipo var cuando no se sabe bien el tipo que es puede ser un double, etc
            {
                Console.Write(inputPrompt);
                var userInput = Console.ReadKey(true);

                foreach (var menuItem in _items)
                {
                    if (userInput.Key == menuItem.Code && menuItem.Selectable)
                    {
                        return menuItem;
                    }
                }

                Console.WriteLine("Ungültige Eingabe!");
            }
        }
    }
}





