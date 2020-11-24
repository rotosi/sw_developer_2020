using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlasse
{
    public class FileRepository : DataRepository
    {
        private readonly string _fileName;

        public TextFileRepository(string fileName, int maxSize) : base ("TextFile Repository", maxSize)
        {
            _fileName = fileName;
        }

        public string FileName
        {
            get { return _fileName; }
        }

        public override string Read()
        {
            if (string.IsNullOrWhiteSpace(_fileName) || !File.Exists(_fileName))
            {
                Debug.WriteLine($"Date '{_fileName}' darf nicht leer sein.");
            }
            using (StreamWriter sr = new StreamWriter(_fileName, true))
            {
                return sr.ReadToEnd();
            }
        }
    }

    public override void Write(string data)
    {
        if (string.IsNullOrWhiteSpace(_fileName))

        {
            Debug.WriteLine($"Date '{_fileName}' darf nicht leer sein.");
        }

        using (StreamWriter sw = new StreamWriter(_fileName, true))
        {
            sw.WriteLine(data);

        }
    }
}

