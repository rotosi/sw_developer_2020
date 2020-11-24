using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            DataRepository repository = new FileRepository("MyData.txt", 200);

            //daten speichern
            persistMyData(repository, "Dies ist ein Testdaten");

            //date lesen
            string myData = ReadMyData(repository);
            //ausgabe
            Console.WriteLine(myData);

            //DataRepository dataRepository = new DataRepository("moggDB", 500000);
            //dataRepository.Write("Dies ist ein Testdatensatz...");
        }

        static string ReadMyData(DataRepository repository)
        {
            if (repository != null)
            {
                Console.WriteLine(repository);
                return repository.Read();
            }
            return string.Empty;
        }

        private static void persistMyData(DataRepository repository, string dataToPersist)
        {
            if (repository != null)
            {
                //repository.Write(dataToPerist)
                repository.Write(dataToPersist);
            }
        }
    }
}
