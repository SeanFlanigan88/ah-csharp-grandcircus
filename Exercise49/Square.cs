using System;
using System.Collections.Generic;

namespace Exercise49
{
    // partial class Program
    // {
    //     public static List<Square> length = new List<Square>();
    // }

    public class Square
    {
        private int _side = 5;

        public int side { get; set; }

        // public Square()
        // {
        //     side = 5;
        // }

        public Square(string userInput)
        {
            side = int.Parse(userInput);
        }
    }
}


