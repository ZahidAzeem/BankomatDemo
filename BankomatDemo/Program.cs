using System;

namespace AutomatBankDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Vänligen gör en insättning ***");

            // create user 
            Account account = new Account();
            account.AccountCreate();
            Balace balace = new Balace();
            /*
            if balance is zero then user requires to deposit first.
             */
        }
    }
}
