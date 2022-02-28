using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    internal class LoanAccount: Account
    {
        private const string accountPrefix = "400";
        private static int nextAccount = 30000000;

        public LoanAccount()
        {
            nextAccount++;
        }

        public string getNextAccountNo()
        {
            return (accountPrefix + Convert.ToString(nextAccount));
        }
    }
}
