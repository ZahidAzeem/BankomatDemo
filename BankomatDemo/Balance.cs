using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AutomatBankDemo
{
    public class Balance : Account
    {
        double deduct, newAmount;
        public double CheckBalance()
        {
            Console.WriteLine("Vill du göra insättning, tryck 'Y'");
            Console.WriteLine("Eller");
            Console.WriteLine("vill du göra uttag, tryck 'U'");
            string FLAG = Console.ReadLine();

            if (FLAG=="Y"|| FLAG=="y")
            {
                Console.Write("Vänligen ange belopp: ");
                string input = Console.ReadLine();
                newAmount = double.Parse(input);
                CurrentBalance += newAmount;
                //Console.WriteLine("Current balace is: "+CurrentBalance);
            } 
            else if (FLAG == "U" || FLAG == "u")
            {
                Console.Write("Vänligen ange belopp: ");
                string input = Console.ReadLine();
                deduct = double.Parse(input);
                CurrentBalance -= deduct;
                //Console.WriteLine("Current balace is: " + CurrentBalance);
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


