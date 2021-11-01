using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BankomatDemo
{
    public class Account
    {

        static string  username = Environment.UserName.ToString();
        string path = @"C:\Users\" + username + @"\Documents\";

        string name, bankName, doBirth;
        public double CurrentBalance;

        DateTime dateTime =DateTime.Now;
        public void AccountCreate()
        {
            Console.Write("Vänligen skriv in ditt Bank namn: ");
            bankName = Console.ReadLine();
            Console.Write("Vänlingen skriv in ditt namn: ");
            name = Console.ReadLine();
            Console.Write("Vänligen skriv in ditt Födelsedatum: ");
            doBirth = Console.ReadLine();

            using (StreamWriter streamWriter = File.CreateText(path + "AccountDetails.txt"))
            {
                streamWriter.WriteLine();
                streamWriter.WriteLine("Bank namn: " + bankName);
                streamWriter.WriteLine("Ditt namn: " + name);
                streamWriter.WriteLine("Födelsedatum: " + doBirth);

            }

        }

        // konto saldo hantering funktion
        public void AccountDetails()
        {
           
            string line = "";
            using (StreamReader sr = new StreamReader(path + "AccountDetails.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
