using System;

namespace _20210825
{
    public class BankAccount: Bank
    {
        public string ID { get; }

        public BankAccount(): this("Ally")
        {

        }

        public BankAccount(string name): base(name, 100)
        {
            ID = Guid.NewGuid().ToString();
        }

        public void Deposit(decimal amount)
        {
            this.Cash = this.Cash + amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Cash = this.Cash - amount;
        }
    }
}