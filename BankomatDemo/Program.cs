using System;

namespace BankomatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Välkommen till Automat Bank ***");
            // skapa konto

            Account account = new Account();
            account.AccountCreate();
            Balance balance = new Balance();
            TransactionDetail transaction = new TransactionDetail();

            // användaren ska tryck 'X' att stänga program
            bool closeFlag = true;
            while (closeFlag)
            {

                if (true)
                {
                    Console.WriteLine("Kontot saldo är:  " + balance.CurrentBalance.ToString());
                    Console.WriteLine("Konto Saldo, Tryck 'S'");
                    Console.WriteLine("Insättning eller Uttrag, Tryck 'Y'");
                    Console.WriteLine("Transaktioner detaljer, Tryck 'T'");

                    Console.WriteLine("Logga-ut/stäng kontot Tryck 'X'");

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
                        account.AccountDetails();
                    }
                    else if (FLAG == "t" || FLAG == "T")
                    {
                        TransactionDetail.AccountTransactionDetail();
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
