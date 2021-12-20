using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehicles;

namespace LABY_programowanie_I
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> intList = new List<int> { 0, 1, 2, 3, 4, 5 };
            List<OfficeChair> OtherList = new List<OfficeChair>
            {
                new OfficeChair("Czesiek", 0),
                new OfficeChair("Rysiek", 15, true),
                new OfficeChair("Stasiek", 20, true)
            };*/

            //Podpunkt 1
            Console.WriteLine("Podpunkt 1");
            int[] intList = { 4, 3, 2, 3, 4, 5 };
            PrintArr(intList);

            //Podpunkt 2
            Console.WriteLine("\n\nPodpunkt 2");
            OfficeChair[] OtherList =
            {
                new OfficeChair("Czesiek", 0),
                new OfficeChair("Rysiek", 15, true),
                new OfficeChair("Stasiek", 20, true)
            };

            foreach (var chair in OtherList)
            {
                chair.ResetSpeed();
                chair.IsOccupied = false;
            }
            //PrintArr(OtherList);

            //Podpunkt 3
            Console.WriteLine("\n\nPodpunkt 3");
            Console.WriteLine("Srednia: {0}", Avg(intList));

            int[] arr2 = CreateArr(4);
            PrintArr(arr2);

            //Podpunkt 4
            Console.WriteLine("\n\nPodpunkt 4");
            string str1 = "lolo";
            string str2 = "bolo";

            string str3 = str1 + str2;
            str3 = str3.Remove(2, 2);

            Console.WriteLine(str3);

            //Podpunkt 5
            Console.WriteLine("\n\nPodpunkt 5");
            StringBuilder strsb = new StringBuilder();

            strsb.Append("czary mary");
            Console.WriteLine(strsb);

            strsb.Insert(0, "hokus pokus ");
            Console.WriteLine(strsb);

            strsb.Remove(4, 3);
            Console.WriteLine(strsb);

            strsb.Replace("czary", "CZARY");
            Console.WriteLine(strsb);



            Console.ReadKey();
        }
        //======================================//
        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
        static void PrintArr(OfficeChair[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Print();
            }
            Console.WriteLine();
        }
        //======================================//

        static float Avg(int[] arr)
        {
            float ret = 0f;

            for (int i = 0; i < arr.Length; i++)
            {
                ret += arr[i];
            }

            ret /= arr.Length;

            return ret;
        }

        static int[] CreateArr(int size)
        {
            int[] ret = new int[size];

            for (int i = 0; i < size; i++)
            {
                ret[i] = i;
            }

            return ret;
        }
    }
}
