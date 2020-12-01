using EventsGrundlagen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsGrundLagen
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car("SuperCar VM", 220);//intasierung my car

            myCar.CarExploded += MyCar_CarExploded; //delegacion
            myCar.CarExploded += MyCar_CarExploded1; //delegacion


            do
            {
                Console.WriteLine(myCar);
                myCar.SpeedUp(20);
            }
            while (myCar.State != State.Exploded);

            //vom Ereignis abmelden
            //myCar.CarExploded -= MyCar_CarExploded; //delegacion
        }

        private static void MyCar_CarExploded1(int currentSpeed, int maxSpeed)
        {
            Console.WriteLine($"sind da");
        }

        private static void MyCar_CarExploded(int currentSpeed, int maxSpeed)
        {
            Console.WriteLine($"Leider ist das Auto nun explodiert.");
        }
    }
}
