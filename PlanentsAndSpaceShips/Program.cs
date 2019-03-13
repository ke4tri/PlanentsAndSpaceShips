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
                
                Console.Write(item + ", \n");
            }

            combinedList.Remove("Pluto");

            Console.Write("\nThis is without Pluto: ");
            foreach (var item in combinedList)
            {
                
                Console.Write(item + ", \n");
            }

            Console.ReadLine();

            List<string> mainShipPlanets = new List<string>() { "Saturn", "Uranus" };
            List<string> secondShipPlanets = new List<string>() { "Earth", "Pluto", "Mars" };


            var shipsAndPlanetsVisit = new Dictionary<string, List<string>> { };
            shipsAndPlanetsVisit.Add("The Main Ship", mainShipPlanets);
            shipsAndPlanetsVisit.Add("The Second Ship", secondShipPlanets);

            foreach (var (ships, planets) in shipsAndPlanetsVisit)
            {
                Console.WriteLine($"This ship {ships} has visited these planets : ");
                foreach (var planet in planets)
                {
                    Console.WriteLine(planet);
                }
                Console.WriteLine("\n");
            }
            
            Console.ReadLine();
        }

    }
}


            

              

