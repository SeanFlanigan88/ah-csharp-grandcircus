using System;

namespace _20211007
{
    public class Crew
    {
        // private string _name = "";
        // public string Name {
        //     get {
        //         return _name;
        //     }
        //     set {
        //         _name = value;
        //     }
        // }

        public string Name { get; set; }
        public string Role { get; set; }

        public Crew(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}