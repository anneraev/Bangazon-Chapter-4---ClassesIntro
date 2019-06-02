using System;
using System.Collections.Generic;
using Planner;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            City NewCity = new City();

            Building Hospital = new Building("222 Something Street");
            Hospital.Design("Some Person");
            Hospital.Construct();
            Hospital.Purchase("Doctor Thanatos");
            Hospital.depth = 300.00;
            Hospital.width = 200.00;
            Hospital.stories = 10;
            NewCity.addBuilding(Hospital);

            Building Mortuary = new Building("223 Something Street");
            Mortuary.Design("Don the Designer");
            Mortuary.Construct();
            Mortuary.Purchase("Doctor Thanatos");
            Mortuary.depth = 150.00;
            Mortuary.width = 320.55;
            Mortuary.stories = 3;
            NewCity.addBuilding(Mortuary);

            foreach (Building building in NewCity.Buildings) {
                string designer = building.GetDesigner();
                string owner = building.GetOwner();
                string address = building.GetAddress();
                DateTime date = building.GetDate();
                Console.WriteLine(address);
                Console.WriteLine("-------------------");
                Console.WriteLine($"Designed by {designer}");
                Console.WriteLine($"Constructed on {date}");
                Console.WriteLine($"Owned by {owner}");
                Console.WriteLine($"{building.volume} cubic meters of space.");
                Console.WriteLine(" ");
            }
        }
    }
}
