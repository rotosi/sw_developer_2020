using System;

namespace TeilnehmerVerwaltung_v2
{
    public struct Teilnehmer
    {
        public Guid teilnehemerId;
        public string VorName;
        public string Nachname;
        public DateTime Geburtsdatum;
        public string Strasse;
        public string HausNummer;
        public int Plz;
        public string Ort;

    }
}
