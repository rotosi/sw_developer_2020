using System;
namespace ArtikelExample
{
    public class Artikel
    {
        private string _bezeichnung;
        private string _preis;
        public Guid Id;
        private ArtikelStatus _status;

        public Artikel()
        {
        }


        public string Bezeichnung
        {
            get
            {
                return _bezeichnung;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) || value.Length > 7)
                {
                    _bezeichnung = value;
                }
            }
        }

        public string Preise
        {
            get
            {
                return _preis;
            }
            set
            {
                
            }
        }

        public string Status
        {
            get
            {
                return _preis;
            }
            set
            {

            }
        }

    }
}

