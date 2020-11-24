using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlasse
{
    public class DataRepository
    {
        private string _name;
        private int _maxiSize;


        public DataRepository(string name, int maxSize)
        {
            _name = name;
            _maxiSize = maxSize;
        }
        public int MaxiSize
        {
            get { return _maxiSize; }
            set { _maxiSize = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract void Write(string data);// este miembro de la clase es abstracto y no tiene implementacion//keine implementierung 
        public abstract string Read();

        // cuando una clase es abstacta no se puede instanciar 

    }
}
