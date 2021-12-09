using System;
using System.Collections.Generic;

namespace _20211007
{
    public class SpaceShuttle
    {
        public int Fuel { get; set; }
        public List<Crew> Team { get; set; }

        public SpaceShuttle()
        {
            Fuel = 0;
            Team = new List<Crew>();
            // {
            //     new Crew(name: "John", role: "Captain")
            // };

            Team.Add(new Crew(name: "John", role: "Captain"));
            Team.Add(new Crew(name: "Diddy", role: "Chimp"));
            Team.Add(new Crew(name: "Hannah", role: "Navigator"));
        }

        public bool Launch()
        {
            if (Fuel > 5 && Team.Count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}