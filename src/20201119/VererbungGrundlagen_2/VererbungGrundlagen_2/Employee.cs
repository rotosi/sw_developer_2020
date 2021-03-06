﻿using System;

namespace VererbungGrundlagen_2
{
    public class Employee
    {
        private readonly string _vorname;
        private string _name;
        private string _nachname;
        private decimal _salary;
        private Guid _id;
        private DateTime _geburtsDatum;              

        public Employee(string vorname, string nachname, DateTime geburtsDatum, decimal salary)

        {
            _vorname = vorname;
            _nachname = nachname;
            _geburtsDatum = geburtsDatum;
            _salary = salary;
            _id = Guid.NewGuid();
        }       

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get
            { return $"{_vorname} {_nachname}"; }
            set { _name = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public DateTime GeburtsDatum
        {
            get { return _geburtsDatum; }
            set { _geburtsDatum = value; }
        }      


        public decimal GetCalculatedSalary()
        {
            return _salary;
        }

        public string GetInfoString()
        {
            return $"[{_id}]: {_vorname} {_nachname} - {_geburtsDatum.ToShortDateString()}";
        }
    }
}


