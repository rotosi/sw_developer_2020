
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VererbungGrundlagen_2;

namespace VererbungGrundlagen_2
{
    public class Sales : Employee
    {
        private double _provision;       

        public Sales(string vorname, string nachname, DateTime geburtsDatum, decimal gehalt, double provision) 
            : base(vorname, nachname, geburtsDatum, gehalt) //instaciamos la clase principal la employee y todo los datos del constructor
        {
            _provision = provision;
            
        }        

        public double Provision
        {
            get { return _provision; }
            set { _provision = value; }
        }              


    }
}
