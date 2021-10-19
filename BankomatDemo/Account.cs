using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AutomatBankDemo
{
    public class Account
    {
        string Name;
        int Age;
        public double CurrentBalance;

        DateTime dateTime =DateTime.Now;
        public void AccountCreate()
        {
            Console.Write("Vänlingen anger ditt namn: ");
            Name = Console.ReadLine();
            Console.Write("Vänligen anger ditt födelseår: ");
            Age = Int32.Parse(Console.ReadLine());
            string path = @"C:\Users\Admin\source\repos\BankomatDemo\BankomatDemo\bin\Debug\netcoreapp3.1\";
            using (StreamWriter streamWriter = File.CreateText(path + "AccountDetails.txt"))
            {
                streamWriter.WriteLine(); 
                streamWriter.WriteLine("Ditt namn: "+Name);
                streamWriter.WriteLine("Födelseår: "+Age);
            }

        }
        public void AccountInfo(string name,int age, double amount)
        {
            Name = name;
            Age = age;
            CurrentBalance = amount;
        }
        public static void AccountHistory()
        {
            // funktion för konto historisk
        }
        // konto detalj funktion
        public static void AccountDetailsOut()
        {
            string saldo;
            // väg kanske ändra till @c:\ 
            string path = @"C:\Users\Admin\source\repos\BankomatDemo\BankomatDemo\bin\Debug\netcoreapp3.1\";

            using (StreamReader saldoReader=File.OpenText(path + "Saldo.txt"))
                {
                saldo = saldoReader.ReadLine();
                }

            string line = "";
            using (StreamReader sr = new StreamReader(path + "AccountDetails.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("Kontot saldo är: " + saldo);
            }
        }
    }
}
