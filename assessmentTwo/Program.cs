using System;
using System.Collections.Generic;
using System.Linq;

namespace assessmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // var arr = AddValues("one", "two", "three");
            // Console.WriteLine(arr[0]);
            // Console.WriteLine(arr[1]);
            // Console.WriteLine(arr[2]);

            // var num = SumArray(new int[]{1,2,3,4,5});
            // Console.WriteLine(num);

            // var listOfNumbers = RemoveNum(new List<int>(){1,2,4,5}, 3);
            // listOfNumbers.ForEach(n => Console.WriteLine(n));

            // var listOfStrings = AddToList("cherries");
            // listOfStrings.ForEach(s => Console.WriteLine(s));

            var result = TryMe(6, 2);
            Console.WriteLine(result);

        }

        public static string[] AddValues(string str1, string str2, string str3)
        {
            return new string[]{ str1, str2, str3 };
        }

        public static int SumArray(int[] numbers)
        {
            return numbers.Sum();
        }

        public static List<int> RemoveNum(List<int> numbers, int number)
        {
            numbers.RemoveAll(n => n == number);
            numbers.Remove(number);

            // if (numbers.Contains(number))
            // {
            //     numbers.RemoveAll(n => n == number);
            //     numbers.Remove(number);
            // }

            return numbers;
        }

        public static List<string> AddToList(string str)
        {
            // var listOfStrings = new List<string>();
            // listOfStrings.Add("grapes");
            // listOfStrings.Add("oranges");
            // listOfStrings.Add(str);
            // return listOfStrings;

            return new List<string>() { "grapes", "oranges", str };
        }

        public static int TryMe(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch(ArithmeticException ex)
            {
                //throw new Exception("What happened", ex);
                return 9;
            }
        }

    }
}
