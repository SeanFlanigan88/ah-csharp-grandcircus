using System;

namespace _20210901
{
    public abstract class Message
    {
        public abstract string Send();

        public bool Yes()
        {
            return true;
        }

        public virtual void PrintOut(string input)
        {
            Console.WriteLine($"You Said: {input}");
        }
    }

    public class Letter: Message
    {
        public override string Send()
        {
            return "Hello World";
        }

        public override void PrintOut(string input)
        {
            base.PrintOut(input);
        }
    }
}