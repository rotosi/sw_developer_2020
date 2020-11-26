using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
  public interface IDataRepository //interface empieza con una I mayuscula. Esto no es una clase y se difine debajo de la principar
                                   //aqui cada miembro es abstracto 
  {
    string Name { get; }

    int MaxSize { get; }

    void Write(string data);

    string Read();
  }

  //public interface ISortable //interface empieza con una I mayuscula. Esto no es una clase y se difine debajo de la principar
  //                                 //aqui cada miembro es abstracto 
  //{
  //    string Name { get; }
  //    int MaxSize { get; }
  //    void Write(string data);
  //    string Read();
  //}
}