using System;

namespace _20210825
{
    public class Animal
    {
        protected virtual int NumberOfLegs(int legs)
        {
            return legs;
        }
    }

    public class Dog: Animal
    {
        public int Legs()
        {
            return NumberOfLegs(4);
        }

        public string Name()
        {
            return "Moxie";
        }

        // public override int NumberOfLegs(int legs)
        // {
        //     return legs;
        // }
    }
}