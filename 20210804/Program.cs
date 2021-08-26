// Examples from 2021.08.04

using System;

namespace _20210804
{
    class Program
    {

        public static string StringFormat(string str1, string str2)
        {
            return $"{str1} {str2}";
        }

        public static void InputWithWhile()
        {
            string answer = string.Empty;
            while(answer == string.Empty)
            {
                answer = Console.ReadLine();
                if (answer == "n")
                {
                    Console.WriteLine("Goodbye");
                }
                else if (answer == "y")
                {
                    Console.WriteLine($"Echo: {answer}");
                    answer = string.Empty;
                }
                else
                {
                    Console.WriteLine("please enter 'y' or 'n'");
                }
            }
        }

        public static void InputWithDoWhile()
        {
            string answer = string.Empty;
            do
            {
                answer = Console.ReadLine();
                if (answer == "n")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                else
                {
                    Console.WriteLine($"Echo: {answer}");
                }
            }
            while(answer == "y");
        }


        static void Main(string[] args)
        {

            var firstName = "Paul";
            var lastName = "Riviera";

            var joinTwoStrings = StringFormat(firstName, lastName);
            Console.WriteLine(joinTwoStrings);




            //InputWithWhile();


           #region Console Input

            // var readKeyValue = Console.ReadKey();
            // Console.Write('\n');
            // Console.WriteLine(readKeyValue.KeyChar);

            // string value = Console.ReadLine();
            // Console.WriteLine("Echo: " + value);

            #endregion

            #region Loops

            //string greeting = "Hello World";

            //for (var i = 0; i < greeting.Length; i++)
            //{
            //    Console.WriteLine(greeting[i]);
            //}

            //foreach (char character in greeting)
            //{
            //    if (character != 'l')
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(character);
            //}

            //int i = 0;
            //while (i < greeting.Length)
            //{
            //    Console.WriteLine(greeting[i]);
            //    i++;
            //}

            //var counter = 0;
            // do
            // {
            //    counter++;

            //    Console.WriteLine(greeting[i]);
            //    Console.WriteLine("Counter: " + counter);

            //    if (counter == 10)
            //    {
            //        break;
            //    }

            //    //i++;

            // }
            // while (i < greeting.Length);

            #endregion

            #region Try Catch Blocks

            //dynamic input = "Hello World";

            //try
            //{
            //    if (input == 0)
            //    {
            //        Console.WriteLine("Value is Zero");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nope");
            //    }
            //}
            //catch (Exception e)
            //{

            //}

            #endregion

            #region IF/Switch Statements

            //string dayOfTheWeek = "W";

            //var testValue = Values.valueTwo;

            //if (testValue == Values.valueZero)
            //{
            //    Console.WriteLine("ZERO");
            //}
            //else if (testValue == Values.valueTwo)
            //{
            //    Console.WriteLine("TWO");
            //}
            //else if (testValue == Values.valueOne)
            //{
            //    Console.WriteLine("ONE");
            //}
            //else
            //{
            //    Console.WriteLine("Your input is not valid");
            //}

            //switch (testValue)
            //{
            //    case Values.valueZero:
            //        Console.WriteLine("ZERO");
            //        break;
            //    case Values.valueTwo:
            //        Console.WriteLine("TWO");
            //        break;
            //    case Values.valueOne:
            //        Console.WriteLine("ONE");
            //        break;
            //    default:
            //        Console.WriteLine("Your input is not valid");
            //        break;
            //}

            #endregion
        }
    }
}
