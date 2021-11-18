using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Airboat : Vehicle
    {
        public Airboat()
        {
            this.Name = "";
            this.Velocity = 0;
            this.IsOccupied = false;
        }

        public Airboat(string Name, int Velocity = 0, bool isOccupied = false)
        {
            this.Name = Name;
            this.Velocity = Velocity;
            this.IsOccupied = isOccupied;
        }
    }
}
