using System;

namespace GrundLagenKlassen
{
    public class Employee
    {

        public string Name;
        public Guid Id;
        public decimal Salary;
        public DateTime Birthday;
        public EmployeeState State;

        //std. Konstruktor
        //public Employee() //es un metodo en una clase donde no se inicializa. tiene que se exactamente al de la clase  //cada uno tiene una tareass
        //{
        //    Name = "No Name";
        //    Id = Guid.NewGuid();
        //    Salary = 1000.0m; //1000.0m la m es para un decimal, entonces se pone así
        //    Birthday = new DateTime(1998, 11, 1);
        //    State = EmployeeState.Employed;            
        //}

        public Employee(string name, DateTime birthday, decimal salary)
        {
            Id = Guid.NewGuid();
            State = EmployeeState.Employed;

            Name = name;
            Birthday = birthday;
            Salary = salary;
        }

        public void DispayInfos()
        {
            Console.WriteLine($"MA Id:     {Id}");
            Console.WriteLine($"Name:      {Name} [Euro {Salary}]");
            Console.WriteLine($"Birthday:  {Birthday.ToLongDateString()}");
            Console.WriteLine($"State:      {State}");
            Console.WriteLine();
        }

        public void UpdateSalary(double amountInProcent)
        {
            if (State != EmployeeState.Discontinued)
            { 
            //Berechnung neues Gehalt
            Salary = Salary + Salary * (decimal)(amountInProcent / 100); // se convierte en un decimal este valor 
            Console.WriteLine($"Gehalt von {Name} wurde aktualisiert.");
            }
        }

    }
}