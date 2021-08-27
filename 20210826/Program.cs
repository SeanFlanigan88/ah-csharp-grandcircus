using System;
using System.Collections.Generic;

namespace _20210826
{
    class Program
    {
        static void Main(string[] args)
        {


            // var str = string.Format("I am a {4} and {2} Pen", "blue", "red", "green", "yellow", "black", "orange");
            // Console.WriteLine(str);



            var myPen = new Pen();

            // Console.WriteLine($"My new pen is {myPen.Color}");
            // Console.WriteLine($"My new pen is a {myPen.GetBrand()} pen");

            // Console.WriteLine(myPen.WhatTypeOfPen());
            // Console.WriteLine(myPen.WhatTypeOfPen("green"));

            var bowlOne = new Pasta("ONE");
            var bowlTwo = new Pasta("TWO");

            Console.WriteLine(bowlOne.GetID());
            Console.WriteLine(bowlTwo.GetID());

            //nsole.WriteLine(Pasta.HasGluten);

            List<Pasta> dishes = new List<Pasta>();
            dishes.Add(bowlOne);
            dishes.Add(bowlTwo);



            //Console.WriteLine(bowlOne.GetType());

        }
    }
}
