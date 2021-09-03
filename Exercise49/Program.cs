using System;
using System.Collections.Generic;

namespace Exercise49
{
    public class Program
    {
        public static List<Square> length = new List<Square>();

        public static void Main(string[] args)
        {

            // Console.Write("Enter 3 sides:");
            // var userInput = Console.ReadLine();
            // var sides = userInput.Split(',');

            // Console.WriteLine(userInput);
            // Console.WriteLine($" Side 1: {sides[0].Trim()}");
            // Console.WriteLine($" Side 2: {sides[1].Trim()}");
            // Console.WriteLine($" Side 3: {sides[2].Trim()}");

            do
            {
                Console.Write("Enter a side length (q to quit):");
                var userInput = Console.ReadLine();
                if (userInput.ToLower() == "q")
                {
                    NumberOfSquaredCreated();
                    CalculateLargestSquare();
                    CalculateSmallestSquare();
                    CalculateAverageAreaOfSquare();
                    CalculateAveragePerimeterOfSquare();

                    if (AskToEnd())
                    {
                        break;
                    }
                }

                length.Add(new Square(userInput));
            }
            while(true);
        }

        public static bool AskToEnd()
        {
            Console.Write("Would you like to continue (y/n)?");
            var userInput = Convert.ToString(Console.ReadLine());
            return userInput == "n";
        }

        public static void NumberOfSquaredCreated()
        {
            Console.WriteLine("NumberOfSquaredCreated");
        }

        // TODO: Add Method for Largest Square
        public static void CalculateLargestSquare()
        {
            Console.WriteLine("CalculateLargestSquare");
        }

        // TODO: Add Method to calculate smallest square
        public static void CalculateSmallestSquare()
        {
            Console.WriteLine("CalculateSmallestSquare");
        }

        // TODO: Add method to calulate the average area of a square
        public static void CalculateAverageAreaOfSquare()
        {
            Console.WriteLine("CalculateAverageAreaOfSquare");
        }

        // TODO: Add Method to calculate the average perimeter
        public static void CalculateAveragePerimeterOfSquare()
        {
            Console.WriteLine("CalculateAveragePerimeterOfSquare");
        }

    }
}
