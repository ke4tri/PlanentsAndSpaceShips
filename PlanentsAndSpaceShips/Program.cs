using System;
using System.Collections.Generic;

namespace PlanentsAndSpaceShips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            
            List<string> lastPlanetList = new List<string>() { "Saturn", "Uranus" };
            List<string> combinedList = new List<string>();

            combinedList.AddRange(lastPlanetList);
            combinedList.AddRange(planetList);


            Console.WriteLine("This is from the combined list :");
            foreach (var item in planetList)
            {
                //var listJoined = String.Join("", item);
                //Console.Write(listJoined);
                Console.Write(item + ", ");
            }
            Console.ReadLine();

        }
    }
}
