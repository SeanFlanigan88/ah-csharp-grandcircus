using System;
using System.Collections;
using System.Collections.Generic;

namespace _20210901
{
    public interface IQuestion
    {
        string myProperty { get; set; }

        string IsCorrect(string input);
    }

    public class TrueAndFalseQuestion: IQuestion
    {
        public string myProperty { get; set; }

        // private string _myField = string.Empty;

        // public string myProperty
        // {
        //     get {
        //         return _myField;
        //     }
        //     set{
        //         _myField = value;
        //     }
        // }

        public string IsCorrect(string input)
        {
            //return "Yes it is correct";
            var list = new List<String>();

            return "Hello";
        }
    }

}