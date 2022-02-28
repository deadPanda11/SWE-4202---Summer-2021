using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    internal class SavingsAccount: Account
    {
        private const string accountPrefix = "314";
        private static int nextAccount = 30000000;
        public static double minimumBalance = 0;
        public const int transactionLimit = 5;
        public const double withdrawalCharge = 15;
        public static int count = 0;

        public SavingsAccount()
        {
            nextAccount++;
        }

        public string getNextAccountNo()
        {
            return (accountPrefix + Convert.ToString(nextAccount));
        }

        public static void countTransaction()
        {
            count++;
        }
    }
}
