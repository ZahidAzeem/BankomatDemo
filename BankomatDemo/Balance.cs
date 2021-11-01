using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BankomatDemo
{
    public class Balance : Account
    {
        double deposit, deduct;
        public double CheckBalance()
        {
            Console.WriteLine("Vill du göra Insättning, tryck 'I'");
            Console.WriteLine("Eller");
            Console.WriteLine("vill du göra Uttag, tryck 'U'");
            string FLAG = Console.ReadLine();

            if (FLAG=="i"|| FLAG=="I") // konto insättning
            {

                    Console.Write("Vänligen ange belopp: ");
                    string input = Console.ReadLine();
                    deposit = double.Parse(input);

                    if (deposit <= 1000)
                    {
                        TransactionDetail.DepositTransactionDetails(deposit);
                        CurrentBalance += deposit;
                    }
                    else
                    {
                        Console.WriteLine("\n-- INFO -- Max Insättning per gång 1000 kr!");
                    }

            } 
            else if (FLAG == "U" || FLAG == "u") // konto uttdrag Detaljer
            {
                
                    Console.Write("Vänligen ange belopp: ");
                    string input = Console.ReadLine();
                    deduct = double.Parse(input);
                    
                if (deduct <= CurrentBalance && deduct <= 1000)
                    {
                        TransactionDetail.WithDrawTransactionDetails(deduct);
                        CurrentBalance -= deduct;
                    }
                    else
                    {
                        Console.WriteLine("--INFO-- Saldo är mindre än uttag!");
                    }
            }
            else
            {
                Console.WriteLine("Vänligen ange sifror 1 - 9 ");
            }

            Deposit.KontoSaldo(CurrentBalance);

            return CurrentBalance;
        }


    }
}


