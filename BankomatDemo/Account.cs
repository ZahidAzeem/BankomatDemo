using System;
using System.Collections.Generic;
using System.Text;

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
            Console.Write("Belopp SEK:");
            CurrentBalance = double.Parse(Console.ReadLine());

        }
        public void AccountInfo(string name,int age, double amount)
        {
            Name = name;
            Age = age;
            CurrentBalance = amount;
        }
    }
}
