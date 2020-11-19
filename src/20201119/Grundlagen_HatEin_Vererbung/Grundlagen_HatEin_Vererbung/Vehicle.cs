using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
    public class Vehicle
    {
        private Guid _id;
        private string _model;
        private string _description;
        private VehicleState _state;
        private int _maxSpeed;


        public Vehicle()
        {
            _model = "2Bike Forte";
            _description = "Farrad FrauenStad";
            _maxSpeed = 30;
            _state = VehicleState.Locked;

        }
        public Vehicle(string model, string desription, int maxSpeed)
        {            
            _model = model;
            _description = desription;
            _state = VehicleState.Locked;
            _maxSpeed = maxSpeed;

        }

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Model
        {          
                get { return _model; }
                set { _model = value; }            
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }

        public VehicleState Staus
        {
            get { return _state; }
            set { _state = value; }
        }

        public string GetInfoString()
        {
            return $"[{_id}]: {_model} {_description} \nMax. Speed: {_maxSpeed}km  State:{_state}";
        }

        public void Drive()
        {
            if (_state == VehicleState.Unlocked)
            {
                Console.WriteLine($"Das Farzeug '{_model}'kann sich leider nciht bewegen!"); 
            }
        }




    }
}
