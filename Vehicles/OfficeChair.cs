using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class OfficeChair : Vehicle
    {
        public OfficeChair()
        {
            this.Name = "";
            this.Velocity = 0;
            this.IsOccupied = false;
        }

        public OfficeChair(string Name, int Velocity = 0, bool isOccupied = false)
        {
            this.Name = Name;
            this.Velocity = Velocity;
            this.IsOccupied = isOccupied;
        }

        public OfficeChair(Airboat airboat)
        {
            airboat.Accident += ResetSpeed;
        }
        public void ResetSpeed()
        {
            Velocity = 0;
        }
    }
}
