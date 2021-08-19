using System;
using System.Collections;
using System.Collections.Generic;

namespace _20210818
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListExample(5);

            //HashtablesExample();

            //WorkingWithLists();

            //WorkingWithDictionaries();

            var testString = "the quick brown fox jumps over the lazy dog";
            ReturnMostUsedCharacterInStringSolution(testString);
        }

        #region Collections | ArrayList

        public static void ArrayListExample(int numberOfItemsToAdd)
        {
            ArrayList list = new ArrayList();
            for(var i = 0; i < numberOfItemsToAdd; i++)
            {
                var strValue = $"Item {i}";
                decimal someValue = 100.50M;
                list.Add(someValue);
                list.Add(strValue);
                list.Add(null);
            }

            list.Insert(1, "42");
            Console.WriteLine(list.Count);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

        }

        #endregion
        
        #region Collections | Hashtables

        public static void HashtablesExample()
        {
            Hashtable table = new Hashtable();
            table.Add("ONE", 1);
            table.Add("Hello", "World");
            table.Add("What is your name?", "Unknown");

            var keys = table.Keys;
            foreach(var key in keys)
            {
                Console.WriteLine($"{key} | {table[key]}");
            }
        }

        #endregion

        #region Generics | Lists

        public static void WorkingWithLists()
        {
            List<DayOfWeek> DaysOfTheWeek = new List<DayOfWeek>();
            DaysOfTheWeek.Add(DayOfWeek.Monday);
            DaysOfTheWeek.Add(DayOfWeek.Tuesday);
            DaysOfTheWeek.Add(DayOfWeek.Wednesday);
            DaysOfTheWeek.Add(DayOfWeek.Thursday);
            DaysOfTheWeek.Add(DayOfWeek.Friday);
            DaysOfTheWeek.Add(DayOfWeek.Saturday);
            DaysOfTheWeek.Add(DayOfWeek.Sunday);

            if (!DaysOfTheWeek.Contains(DayOfWeek.Thursday))
            {
                Console.WriteLine("It should contain thursday!");
            }

            for(var i = 0; i < DaysOfTheWeek.Count; i++)
            {
                Console.WriteLine(DaysOfTheWeek[i]);
            }
        }

        #endregion
    
        #region Generics | Dictionary

        public static void WorkingWithDictionaries()
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("Hello", 0);
            myDictionary["World"] = 1;

            foreach (KeyValuePair<string, int> pair in myDictionary)
            {
                Console.WriteLine($"Key: {pair.Key} | Value: {pair.Value}");
            }

        }

        #endregion
    

        #region Random Interview Question

        public static void ReturnMostUsedCharacterInStringSolution(string Input)
        {
            var maxKey = new char();
            var maxCount = 0;

            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            foreach(var character in Input)
            {
                if (characterCount.ContainsKey(character))
                {
                    characterCount[character]++;
                }
                else
                {
                    characterCount[character] = 1;
                }

                var value = characterCount[character];
                if (value > maxCount)
                {
                    maxCount = value;
                    maxKey = character;
                }
            }

            // var maxKey = new char();
            // var maxCount = 0;
            // foreach(KeyValuePair<char, int> pair in characterCount)
            // {
            //     if (pair.Value > maxCount)
            //     {
            //         maxCount = pair.Value;
            //         maxKey = pair.Key;
            //     }
            // }

            Console.WriteLine($"Character '{maxKey}' showed up {maxCount} times.");
        }


        #endregion

    
    }
}
