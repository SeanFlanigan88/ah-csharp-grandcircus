using System;

namespace MockAssessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = new Town();
            var result = town.SurviveTheWinter();
            var output = result ? "Yes" : "No";
            Console.WriteLine($"Will They Survive? {output}");
        }
    }
}
