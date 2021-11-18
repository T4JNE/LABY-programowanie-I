using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace LABY_programowanie_I
{
    class Program
    {
        static void Main(string[] args)
        {
            OfficeChair krzeslo = new OfficeChair("Bob", 300, true);

            krzeslo.OnVelocityChanged += (sender, e) => { Console.WriteLine("Predkosc krzesla zostala zmieniona!"); };


            krzeslo.Print();

            for (int i = 0; i < 6; i++)
            {
                krzeslo.Velocity -= i * 10;
            }

            krzeslo.Print();

            Console.ReadKey();
        }
    }
}
