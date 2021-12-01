using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Airboat : Vehicle
    {
        public delegate void AccidentEventHandler();
        public event AccidentEventHandler Accident;
        public Airboat()
        {
            Accident += ResetSpeed;
            this.Name = "";
            this.Velocity = 0;
            this.IsOccupied = false;
        }

        public Airboat(string Name, int Velocity = 0, bool isOccupied = false)
        {
            Accident += ResetSpeed;
            this.Name = Name;
            this.Velocity = Velocity;
            this.IsOccupied = isOccupied;
        }

        public void MakeAccident()
        {
            Accident.Invoke();
        }
        public void ResetSpeed()
        {
            Velocity = 0;
        }
    }
}
