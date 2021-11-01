using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace BankomatDemo
{
   public class TransactionDetail
    {
        // konto transaktion function

        static string username = Environment.UserName.ToString();
        static string path = @"C:\Users\" + username + @"\Documents\";

        public TransactionDetail()
        {
            File.Delete(path + "TransactionsHistory.txt");
        }

        public static void WithDrawTransactionDetails(double saldo)
        {

            using (StreamWriter streamWriter = File.AppendText(path + "TransactionsHistory.txt"))
            {
                streamWriter.WriteLine(DateTime.Now + " Uttag " + " - " + saldo);
            }
        }

        public static void DepositTransactionDetails(double saldo)
        {
                using (StreamWriter streamWriter = File.AppendText(path + "TransactionsHistory.txt"))
                {
                    streamWriter.WriteLine(DateTime.Now + " Insättning " + " + " + saldo);
                }
        }

        // Transaktioner detaljer
        public static void AccountTransactionDetail()
        {
            if (File.Exists(path + "TransactionsHistory.txt"))
            {
                Console.WriteLine();
                string line = "";
                using (StreamReader streamReader = new StreamReader(path + "TransactionsHistory.txt"))
                {
                    Console.WriteLine(" ---- ----- ---- ");
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine(" ---- ----- ---- ");
                }
            }
            else
            {
                Console.WriteLine(" ---- ----- ---- ");
            }
        }

    }
}
