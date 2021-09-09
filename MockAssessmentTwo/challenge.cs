using System;
using System.Linq;
using System.Collections.Generic;

namespace MockAssessmentTwo
{
    public class Challenge
    {
        public static int AddStarWarsCharacters(string[] characters)
        {
            return Array.IndexOf(characters, "Yoda");

            // for (var i = 0; i < characters.Length; i++)
            // {
            //     if (characters[i] == "Yoda")
            //     {
            //         return i;
            //     }
            // }
            // return -1;
        }

        public static string DeathStarCombat(Dictionary<string, int> jedisByDamage)
        {
            var strongestJedi = jedisByDamage.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            return strongestJedi;

            // var characterName = "";
            // var maxDamage = 0;
            
            // foreach(KeyValuePair<string, int> pair in jedisByDamage)
            // {
            //     if (pair.Value > maxDamage)
            //     {
            //         maxDamage = pair.Value;
            //         characterName = pair.Key;
            //     }
            // }

            // return characterName;
        }

        public static List<string> ConvertPlanets(string[] planets)
        {
            Array.Reverse(planets);
            return planets.ToList();
        }

        public static double AverageDroids(List<int> droids)
        {
            // List<int> evenOnly = droids.Where(i => i % 2 == 0).ToList();
            // //var average = evenOnly.Sum() / evenOnly.Count;

            // return evenOnly.Average();

            return droids.Where(i => i % 2 == 0).Average();

            //List<int> even = droids.Select((i) => i % 2 == 0 ? i : 0 ).ToList();
            // var average = even.Sum() / evenOnly.Count;

            // return droids.Sum((i) => i % 2 == 0 ? i : 0 ) / droids.Count;
        }

        public static string TryToCatchDarthVader(string value)
        {
            try
            {
                int.Parse(value);
                return "Vader Was Captured!";
            }
            catch(FormatException)
            {
                return "Vader Got Away!";
            }
        }

    }
}