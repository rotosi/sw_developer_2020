using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
    public class Radio
    {
        private double _frecuency;
        private int _volume;
        private Power _powerState;


        public Radio()
        { _frecuency = 90.5;
            _volume = 3;
            _powerState = Power.Off;        
        
        }

        public Power PowerState
        {
            get { return _powerState; }
            set { _powerState = value; }
        }


        public int Volume
        {
            get { return _volume; }
            set {
                //Todo:
                _volume = value; }
        }


        public double Frecuency
        {
            get { return _frecuency; }
            set { _frecuency = value; }
        }

        public string GetInfString()
        {
            return $" State: {_powerState} Freq: {_frecuency} MHz | Volume: {_volume}";
        }

        public void SetPowerState(Power newPowerState)
        {
            _powerState =
            switch (newPowerState)
            {
                case Power.On
                    Console.WriteLine("Radio macht nun Musik" + GetInfString());
                    break;
            }

        }

    }
}
