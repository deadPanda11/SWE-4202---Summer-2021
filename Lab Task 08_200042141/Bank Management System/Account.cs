using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    internal class Account
    {
        private string accountNo;
        private string accountName;
        private double balance;

        public void setAccountNo(string accountNo)
        {
            this.accountNo = accountNo;
        }

        public void setAccountName(string accountName)
        {
            this.accountName = accountName;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public string getAccountNo()
        {
            return accountNo;
        }

        public string getAccountName()
        {
            return accountName;
        }

        public double getBalance()
        {
            return balance;
        }

        public virtual double Deposit(double depositAmount)
        {
            return (this.balance += depositAmount);
        }

        public virtual double Withdraw(double depositAmount)
        {
            return (this.balance -= depositAmount);
        }
    }
}
