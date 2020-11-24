using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExmple
{
    public interface IMenu
    {

        int Count { get; }

        void Add(IMenuItem meunItem);
        void Remove(IMenu meunItem);

        void Display(int width);
    }
}
