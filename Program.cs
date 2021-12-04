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
            Airboat lodz = new Airboat("Eduardo", 250, true);
            OfficeChair krzeslo = new OfficeChair(lodz);
            krzeslo.Velocity = 125;

            krzeslo.OnVelocityChanged += Krzeslo_OnVelocityChanged;


            krzeslo.Print();
            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {
                krzeslo.Velocity -= i * 5;
            }
            krzeslo.Print();
            Console.WriteLine("\n-----WYPADEK--------\n");

            lodz.MakeAccident();

            krzeslo.Print();
            Console.WriteLine();
            lodz.Print();
            Console.WriteLine();


            try
            {
                TestException.TestThrow();
                Console.WriteLine("Nie ma bledu");
            }
            catch (TestException)
            {
                Console.WriteLine("Catch: Error");
            }



            Console.ReadKey();
        }

        private static void Krzeslo_OnVelocityChanged(object sender, int e)
        {
            Console.WriteLine("Predkosc zostala zmieniona!");
        }
    }
}
