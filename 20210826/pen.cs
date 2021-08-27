using System;

namespace _20210826
{
    public class Pen
    {
        // Field
        private string _color;
        private string _brand;
        private string _inkType;
        private Decimal _price;
        private float _length;

        private string CreatedOn;

        private string _template = "I am a {0} Pen";

        public string Color {
            get
            {
                return _color;
            }
        }

        public Pen(): this("blue", "bic", 0.01M, 4, "ballpoint") { }

        public Pen(string color): this(color, "bic", 0.01M, 4, "ballpoint") { }

        public Pen(string color, string brand, decimal price, float length, string inkType)
        {
            Setup(color, brand, price, length, inkType);
        }

        private void Setup(string color, string brand, decimal price, float length, string inkType)
        {
            _color = color;
            _brand = brand;
            _price = price;
            _length = length;
            _inkType = inkType;
        }

        public string GetBrand()
        {
            return _brand;
        }

        public string WhatTypeOfPen(string color = null)
        {
            var str = $"I am a {_color} Pen";

           // var str = string.Format("I am a {0} Pen", _color, "red");

            return string.Format(_template, color ?? _color);
        }

    }
    
}