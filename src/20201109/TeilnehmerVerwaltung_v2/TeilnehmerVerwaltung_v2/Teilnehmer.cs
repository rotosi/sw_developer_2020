using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeilnehmerVerwaltung_v2
{
    public struct Teilnehmer
    {
        public Guid teilnehemerId;
        public string VorName;
        public string Nachname;
        public DateTime Geburtsdatum;
        public string Starsse;
        public string HausNummer;
        public int Plz;
        public string Ort;

    }
}
