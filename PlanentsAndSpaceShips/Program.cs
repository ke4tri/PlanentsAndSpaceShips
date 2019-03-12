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
            combinedList.Insert(3, "Earth");
            combinedList.Insert(2, "Venus");
            planetList.Add("Pluto");


            Console.WriteLine("This is from the combined list :");

            foreach (var item in combinedList)
            {
              
                Console.Write(item + ", ");

            }

            //foreach (var item in planetList)
            //{
            //    
            //    
            //    Console.Write(item + ", ");
                
            //}
            Console.ReadLine();

        }
    }
}
