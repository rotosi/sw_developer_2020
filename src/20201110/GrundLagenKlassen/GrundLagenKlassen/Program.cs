using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundLagenKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanziierung
            Employee ma = new Employee("Max", new DateTime(1986, 23, 12), 15000.0m); //se puede inicialiciar desde aqui 
                                                                                     // Employee ma2 = new Employee();

            ma.DispayInfos();

            ma.Id = Guid.NewGuid();
            ma.Salary = 1500.0m;
            ma.State = EmployeeState.Discontinued;



            
            //ma2.DispayInfos();

            ma.UpdateSalary(15.0);

            ma.DispayInfos();
        }
       
    }
}
