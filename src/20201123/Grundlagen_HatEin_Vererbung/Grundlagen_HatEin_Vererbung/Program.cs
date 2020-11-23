using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle Farrad = new Vehicle();

            Console.WriteLine(Farrad.GetInfoString());
            Vehicle myCar = new Vehicle("Badmobil black Edition V2", "", 250);
            Console.WriteLine(myCar.GetInfoString());
            //myCar.VehicleRadio.SetPowerState(Power.On);
            //myCar.VehicleRadio.SetPowerState(Power.Off);
            //myCar.VehicleRadio.Volume = 5;

           // myCar.State = VehicleState.Unlocked;
           myCar.State = VehicleState.Unlocked;

            Console.WriteLine();
            Console.WriteLine(myCar.GetInfoString());

            myCar.ChangeRadioPowerState(Power.On);

            Console.WriteLine();
            Console.WriteLine();

            myCar.MediaVolume = 8;

            Console.WriteLine(myCar.GetInfoString());






        }
    }
}
