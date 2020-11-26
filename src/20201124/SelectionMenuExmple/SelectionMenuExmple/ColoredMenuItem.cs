using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExmple
{
  class ColoredMenuItem : IMenuItem
  {
    string IMenuItem.Description => throw new NotImplementedException();

    char IMenuItem.Code => throw new NotImplementedException();

    void IMenuItem.Display(int width)
    {
      throw new NotImplementedException();
    }
  }
}
