using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatBankDemo
{
    public class Account
    {
        string Name;
        int Age;
        double Amount;
        DateTime dateTime=DateTime.Now;
        public void AccountCreate()
        {
            Console.WriteLine("Vänlingen anger ditt namn: ");
            Name = Console.ReadLine();
            Console.WriteLine("Vänligen anger ditt födelseår: ");
            Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Belopp SEK:");
            Amount = double.Parse(Console.ReadLine());

        }
        public void AccountInfo(string name,int age, double amount)
        {
            Name = name;
            Age = age;
            Amount = amount;
        }
    }
}
