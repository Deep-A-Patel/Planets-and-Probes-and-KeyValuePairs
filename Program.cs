
using System;
using System.Collections.Generic;

namespace Planets_and_Probes_and_KeyValuePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };

            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>();
            probeDestinations.Add(new KeyValuePair<string, string>("Viking 1", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 1", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Sputnik 19", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 12", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 13", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 11", "Saturn"));

            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> destination in probeDestinations)
                {
                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */

                    if (planet == destination.Value)
                    {
                        matchingProbes.Add(destination.Key);
                    }
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                Console.WriteLine($"{planet}: {String.Join(" ,", matchingProbes)}");
            }


        }
    }
}