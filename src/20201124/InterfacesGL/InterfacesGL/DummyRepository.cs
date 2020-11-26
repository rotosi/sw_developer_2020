using AbstrakteKlassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGL
{
    class DummyRepository : IDataRepository
    {
        //todos estos son los miembros implementados en DataREPOSITORY // leer reference
        public string Name => throw new NotImplementedException();

        public int MaxSize => throw new NotImplementedException();

        public string Read()
        {
            Console.WriteLine("Lesen");
            return "Hallo!";
        }

        public void Write(string data)
        {
            Console.WriteLine("Daten werden nun geschrieben...");
        }
    }
}
