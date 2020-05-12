using System;
using System.Dynamic;
using System.Linq;
using System.Collections.Generic;

namespace ROVER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number of rover");
            int rovernumber = int.Parse(Console.ReadLine());


            Console.WriteLine("the upper-right coordinates of the plateau:");
            var edgepoint = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            List<Location> locations = new List<Location>();
            for (int i = 0; i < rovernumber; i++)
            {
                Location location = new Location();
                locations.Add(location);
            }


            for (int i = 0; i < rovernumber; i++)
            {


                Console.WriteLine($" \n {i + 1}. rover start location:");

                var startlocation = Console.ReadLine().Trim().Split(' ');

                locations[i].X = Convert.ToInt32(startlocation[0]); //convert string to integer 
                locations[i].Y = Convert.ToInt32(startlocation[1]);
                locations[i].Direction = (Direction)Enum.Parse(typeof(Direction), startlocation[2].ToUpper());  //get enum value by string


                Console.WriteLine($"{i + 1}. rover orders for rover's movement:");
                var orders = Console.ReadLine().ToUpper();




                try
                {
                    locations[i].Start(edgepoint, orders);
                    Console.WriteLine($"{i + 1}. rover new location {locations[i].X} {locations[i].Y} {locations[i].Direction}");

                }                                                                                       //that is control If a location outside 
                catch (Exception exception) { Console.WriteLine(exception.Message); }                   //the border is entered, it will give an alert.

            }
        }
    }
}