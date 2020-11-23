using Grundlage_Polymorphie.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlage_Polymorphie
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle[] myVehicleList = new Vehicle[]
             {
               new Vehicle(),
               new Vehicle("Badmobil", "Black Edition Superv2", 250),
               new Plane("F16", "Euro-Fighter Legal Edition", 2500, 20000.0),
               new Car("VM", "Rabbit Golf", 120)
             };

            foreach (var vehicle in myVehicleList)
            {
                Display(vehicle);

            }

            Console.WriteLine

        }

        private static void Display(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.GetInfoString());
            Console.WriteLine();
        }

    }
}
            
          