using System;

namespace BankAccount1
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Firstname Lastname", 1200);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithDrawal(600, DateTime.Now, "Withdrawal One");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Deposit One");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -64);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            //try
            //{
            //    account.MakeWithDrawal(1200, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}
