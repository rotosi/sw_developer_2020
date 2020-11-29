using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExmple
{
  class EmptyItem : IMenuItem
  {
     private readonly string _description;
    private readonly int _code;
    public EmptyItem(string description, int code)
    {
      _description = description;
      _code = code;
    }

    public string Description
    {
      get { return _description; }
    }

    public int Code
    {
      get { return _code; }
    }

        char IMenuItem.Code => throw new NotImplementedException();

        void IMenuItem.Display(int width)
    {
      throw new NotImplementedException();
    }
  }
}
