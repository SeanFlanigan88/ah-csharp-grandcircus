using System;

namespace _20210825
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bank = new Bank("Chase", 1000);

            bank.Cash = 2000.0M;
            bank.Name = "FlagStar";

            // Console.WriteLine($"{bank.Name} has an ${bank.Cash} in it.");

            var account = new BankAccount();
            PrintAccountStatus(account);
        }

        public static void PrintAccountStatus(Bank account)
        {            
            var bankAccount = (BankAccount)account;

            Console.WriteLine($"Account {bankAccount.ID} at {account.Name} has ${account.Cash} in it.");
        }

        #region 4 Pillars of OOP

        private static void NobodyCanSeeMe()
        {
            Console.WriteLine("Hello");

            object one = new object();
        }

        protected static void ChildrenCanSeeMe()
        {
            Animal animal = new Animal();

            Dog dog = new Dog();

            // Console.WriteLine($"Our animal has {animal.NumberOfLegs(0)} legs");

            Animal myDog = new Dog();
            
            Dog myActualDog = (Dog)myDog;
            myActualDog.Name();

            object unknown = (object)myDog;

            Console.WriteLine(unknown.GetType());

            Console.WriteLine($"Our dog name {myActualDog.Name()} has {myActualDog.Legs()} legs");
        }

        internal static void ClassesInMyNamspaceCanSeeMe()
        {
            Console.WriteLine("Hello");
        }

        #endregion
    }
}
