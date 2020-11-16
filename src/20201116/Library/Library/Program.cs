using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
  class Program
  {
    static void Main(string[] args)
    {
      //Instanziierung
      Student st = new Student("Rocio Torres", new DateTime(1986, 6, 1));

      st.DisplayInfos();

      st.State = StudentState.blackList;

    }
  }
}
