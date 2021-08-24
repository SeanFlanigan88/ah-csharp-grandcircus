using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _20210823
{
    class Program
    {
        static void Main(string[] args)
        {
            var testDictionary = new Dictionary<string, bool>();
            testDictionary.Add("Paul@gmail.com", true);
            testDictionary.Add("a@a.com", false);
            testDictionary.Add("=0-23959-u304oghf@outlook.com", false);
            testDictionary.Add("oghf@outlook.com", true);

            Regex regex = new Regex(@"\b[A-Z0-9a-z._%+-]{2,}@[A-Z0-9a-z.-]+\.[A-Za-z]{2,}\b");

            IsValidEmail(testDictionary, regex);

        }

        public static void IsValidEmail(Dictionary<string, bool> testEmails, Regex regex)
        {
            foreach(KeyValuePair<string, bool> pair in testEmails)
            {
                var result = regex.IsMatch(pair.Key);
                var doesTestPass = result == pair.Value ? "SUCCESS" : "FAIL";

                Console.WriteLine($"Email Test: {pair.Key} | {doesTestPass}");
            }
        }

        #region LINQ

        public static void CreateQueries()
        {
            // 1: Obtain the data source
            int[] numbers = { 1,2,3,4,5,6,7,8,9,10 };

            // 2: Query it (Search)
            var query = from n in numbers where (n % 2) == 1 select n;
            var queryWithLambda = numbers.Where(n => (n % 2) == 1);

            List<int> queryToList = (from n in numbers where (n % 2) == 1 select n).ToList();

            // 3: Execute (run)
            RunQueries(queryWithLambda);

        }

        public static void RunQueries(IEnumerable<int> myList)
        {
            foreach (var num in myList)
            {
                Console.WriteLine(num);
            }
            //return myList.ToList();
        }

        #endregion

        #region Lambda Expressions

        public static void WordExample() {
            string statement = "the quick brown fox jumps over the lazy dog.";
            var con = statement.Count((c) => {
                switch (c)
                {
                    case 'a': return true;
                    case 'e': return true;
                    case 'i': return true;
                    case 'o': return true;
                    case 'u': return true;
                    default: return false;
                }
            });
            Console.WriteLine(con);
        }

        #endregion
    }
}
