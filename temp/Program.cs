using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsPassing(double grade)
        {
            return grade > 65;
        }

        public static double AverageGrades(double grade1, double grade2, double grade3) 
        {
            return (grade1 + grade2 + grade3) / 3;
        }

        public static string OddOrEvenAndPassing(double grade)
        {
            var isPassingAndOdd = "passing and odd";
            var isFailingAndOdd = "failing and odd";
            var isPassingAndEven = "passing and even";
            var isFailingAndEven = "failing and even";

            int gradeAsInt = Convert.ToInt32(grade);
            bool isEven = (gradeAsInt % 2) == 0;

            if (IsPassing(grade) && isEven)
            {
                return isPassingAndEven;
            }
            else if (IsPassing(grade) && !isEven)
            {
                return isPassingAndOdd;
            }
            else if (!IsPassing(grade) && isEven)
            {
                return isFailingAndEven;
            }
            else if (!IsPassing(grade) && !isEven)
            {
                return isFailingAndOdd;
            }

            throw new ApplicationException("There is an issue with the above logic");
        }
    }
}
