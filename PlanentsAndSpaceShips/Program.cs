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
            
            
            List<string> lastPlanetList = new List<string>() { "Saturn", "Uranus" };
            List<string> combinedList = new List<string>();

            combinedList.AddRange(planetList);
            combinedList.AddRange(lastPlanetList);
            
            combinedList.Insert(1, "Earth");
            combinedList.Insert(1, "Venus");
            combinedList.Add("Pluto");


            Console.WriteLine("This is from the combined list :");

            foreach (var item in combinedList)
            {
                
                Console.Write(item + ", ");
            }

            combinedList.Remove("Pluto");

            Console.Write("This is without Pluto: ");
            foreach (var item in combinedList)
            {
                
                Console.Write(item + ", ");
            }

            Console.ReadLine();
        }
    }
}


            

              

