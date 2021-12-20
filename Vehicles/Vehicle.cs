using System;

namespace Vehicles
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        private int _velocity;
        public int Velocity
        { 
            get => _velocity;

            set
            {
                if(_velocity != value)
                {
                    _velocity = value;
                    OnVelocityChanged?.Invoke(this, _velocity);
                }
            } 
        }
        public bool IsOccupied { get; set; }

        public event EventHandler<int> OnVelocityChanged;

        abstract public void ResetSpeed();
        
        public void Print()
        {
            Console.WriteLine(this.GetType());
            Console.WriteLine("My name is: " + Name);
            Console.WriteLine("I am moving with " + Velocity + " speed");

            if(IsOccupied)
            {
                Console.WriteLine("I am already occupied");
            }
            else
            {
                Console.WriteLine("I am NOT occupied");
            }
        }
    }
}
