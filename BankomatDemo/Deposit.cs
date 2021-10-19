using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AutomatBankDemo
{
    public class Deposit 
    {
        // Deposit function måste vara här.
        public static void KontoSaldo(double CurrentBalance)
        {
            // saldo.txt fil sparar aktuell saldo
            string path = @"C:\Users\Admin\source\repos\BankomatDemo\BankomatDemo\bin\Debug\netcoreapp3.1\";
            using (StreamWriter streamWriter = File.CreateText(path + "Saldo.txt"))
            {
                streamWriter.Write(CurrentBalance);
            }
        }
    }
}
