using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlasse
{
    public class MemoryRepository :DataRepository
    {

        private string _myMemory;

        public MemoryRepository(int maxSize) : base("RAM Repository", maxSize)
        {
            _myMemory = string.Empty;
        }

        public override string Read()
        {
            return _myMemory;
        }

        public override void Write(string data)
        {
            int coundOfCharsToWrite = data.Length;

            if (data.Length > MaxiSize)
            {
                Debug.WriteLine("Actung! Daten gösser als MaxSize: {data.Length} Zeichen");
                coundOfCharsToWrite = MaxiSize;
            }
            _myMemory = data.Substring(0, MaxiSize);
        }
    }
}
