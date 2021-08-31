using System;
using System.Collections.Generic;

namespace _20210830
{
    public class Card
    {
        protected int Value { get; set; }

        public Card(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            switch (Value)
            {
                case 1:
                    return "Ace";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                default:
                    throw new NotSupportedException("Value was not assigned toa value between 1 and 13");
            }
        }

    } 

    public class Heart: Card
    {
        public Heart(int value): base(value) { }
    }  

    public class Diamond: Card
    {
        public Diamond(int value): base(value) { }
    }

    public class Spade: Card
    {
        public Spade(int value): base(value) { }
    }

    public class Club: Card
    {
        public Club(int value): base(value) { }
    }

}