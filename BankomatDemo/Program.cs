using System;

namespace AutomatBankDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Välkommen till Automat Bank ***");
            // create user 
            Account account = new Account();
            account.AccountCreate();
            Balance balance = new Balance();

            // user press 'X'
            bool closeFlag = true;
            while (closeFlag)
            {

                if (true)
                {
                    Console.WriteLine("Account balance is " + balance.CurrentBalance.ToString());
                    Console.WriteLine("Vill du kolla konto saldo, Tryck 'S'");
                    Console.WriteLine("Vill du forsätta använda kontot, Tryck 'Y'?");
                    Console.WriteLine("Tryck 'X' för att stäng kontot!");

                    // 
                    string FLAG = Console.ReadLine();

                    if (FLAG == "X"|| FLAG == "x")
                    {
                        closeFlag = false;
                    }
                    else if (FLAG == "Y" || FLAG == "y")
                    {
                        balance.CheckBalance();
                    }
                    else if (FLAG == "s" || FLAG == "S")
                    {
                        Account.AccountDetailsOut();
                    }
                    else
                    {
                        Console.WriteLine("\nVänligen välja rätt val");
                    }
                   
                }
            }
            /*
            if balance is zero then user requires to deposit first.
             */
        }
    }
}
