using System;

namespace _20210825
{
    public class Bank
    {
        // Field
        public decimal _cash;

        // Property
        public decimal Cash
        {
            get { 
                return _cash;
            }
            set {
                _cash = value * 10;
            }
        }
        public string Name { get; set; }

        public Bank(string Name)
        {
            this.Name = Name;
        }

        public Bank(string Name, decimal initialDeposit)
        {
            this.Name = Name;
            this.Cash = initialDeposit;
        }


    }

}