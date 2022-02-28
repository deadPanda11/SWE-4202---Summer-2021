using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    internal class CurrentAccount: Account
    {
        private const string accountPrefix = "300";
        private static int nextAccount = 30000000;
        public static double minimumBalance = 500;
        public static double maximumTransactionAmount = 100000;

        public CurrentAccount()
        {
            nextAccount++;
        }

        public string getNextAccountNo()
        {
             return (accountPrefix + Convert.ToString(nextAccount));
        }
    }
}
