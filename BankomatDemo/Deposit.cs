using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BankomatDemo
{
    public class Deposit 
    {
        // Deposit function måste vara här.
        public static void KontoSaldo(double CurrentBalance)
        {
            // saldo.txt fil sparar aktuell saldo
            string username = Environment.UserName.ToString();
            string path = @"C:\Users\" + username + @"\Documents\";

            using (StreamWriter streamWriter = File.CreateText(path + "Saldo.txt"))
            {
                streamWriter.Write(CurrentBalance);
            }
        }
    }
}
