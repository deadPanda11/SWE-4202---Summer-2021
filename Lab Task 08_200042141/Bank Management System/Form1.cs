using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System
{
    public partial class Form1 : Form
    {
        List<Account> accountsList = new List<Account>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string name = NameTextbox.Text;
            double depositAmount = Convert.ToDouble(AmountTextbox1.Text);

            if ((CurrentAccountRadioButton.Checked == true) && (depositAmount >= 0))
            {
                CurrentAccount dummyCurrentAccount = new CurrentAccount();

                string accountNo = dummyCurrentAccount.getNextAccountNo();

                dummyCurrentAccount.setAccountName(name);
                dummyCurrentAccount.setBalance(depositAmount);
                dummyCurrentAccount.setAccountNo(accountNo);

                accountsList.Add(dummyCurrentAccount);

                AccountNumberLabel.Text = dummyCurrentAccount.getNextAccountNo();

                MessageBox.Show("Account has been created successfully!\n\n" + "Account Name: " + dummyCurrentAccount.getAccountName() + "\n" + "Account No.:     " + dummyCurrentAccount.getNextAccountNo());
            }

            else if ((SavingsAccountRadioButton.Checked == true) && (depositAmount >= 50000))
            {
                SavingsAccount dummySavingsAccount = new SavingsAccount();

                string accountNo = dummySavingsAccount.getNextAccountNo();

                dummySavingsAccount.setAccountName(name);
                dummySavingsAccount.setBalance(depositAmount);
                dummySavingsAccount.setAccountNo(accountNo);

                accountsList.Add(dummySavingsAccount);

                AccountNumberLabel.Text = dummySavingsAccount.getNextAccountNo();

                MessageBox.Show("Account has been created successfully!\n\n" + "Account Name: " + dummySavingsAccount.getAccountName() + "\n" + "Account No.:     " + dummySavingsAccount.getNextAccountNo());
            }

            else if ((LoanAccountRadioButton.Checked == true) && (depositAmount >= 0))
            {
                LoanAccount dummyLoanAccount = new LoanAccount();

                string accountNo = dummyLoanAccount.getNextAccountNo();

                dummyLoanAccount.setAccountName(name);
                dummyLoanAccount.setBalance(depositAmount);
                dummyLoanAccount.setAccountNo(accountNo);

                accountsList.Add(dummyLoanAccount);

                AccountNumberLabel.Text = dummyLoanAccount.getNextAccountNo();

                MessageBox.Show("Account has been created successfully!\n\n" + "Account Name: " + dummyLoanAccount.getAccountName() + "\n" + "Account No.:     " + dummyLoanAccount.getNextAccountNo());
            }

            else
            {
                MessageBox.Show("Invalid input!!!");
            }
        }

        private void CheckBalnaceButton_Click(object sender, EventArgs e)
        {
            string accNo = CheckBalanceAccNoTextbox.Text;

            bool errorExists = true;

            foreach(Account account in accountsList)
            {
                if(accNo == account.getAccountNo())
                {
                    CheckBalanceLabel.Text = Convert.ToString(account.getBalance());
                    errorExists = false;
                }
            }

            if (errorExists == true)
            {
                MessageBox.Show("Account no. doesn't exist.");
            }
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            string accNo = DepositAccNoTextbox.Text;
            double depositAmount = Convert.ToDouble(DepositAmountTextbox.Text);

            if((CurrentAccountRadioButton2.Checked == true) && (depositAmount >= 500) && (depositAmount <=100000))
            {
                foreach(Account account in accountsList)
                {
                    if (accNo == account.getAccountNo())
                    {
                        account.Deposit(depositAmount);
                    }
                }

                MessageBox.Show("Deposit successful!");
            }

            else if ((SavingsAccountRadioButton2.Checked == true) && (depositAmount >= 0))
            {
                foreach (Account account in accountsList)
                {
                    if (accNo == account.getAccountNo())
                    {
                        SavingsAccount.countTransaction();

                        if (SavingsAccount.count <= 5)
                        {
                            account.Deposit(depositAmount);
                            MessageBox.Show("Deposit successful!");
                        }

                        else
                        {
                            MessageBox.Show("Transaction Limit Reached.");
                        }
                    }
                }
            }

            else if ((LoanAccountRadioButton2.Checked == true) && (depositAmount >= 0))
            {
                foreach (Account account in accountsList)
                {
                    if ((accNo == account.getAccountNo()) && (depositAmount <= account.getBalance()))
                    {
                        account.Deposit(depositAmount);
                        MessageBox.Show("Deposit successful!");
                    }
                }
            }

            else
            {
                MessageBox.Show("Invalid input!!!");
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            string accNo = WithdrawAccountNumberTextbox.Text;
            double withdrawalAmount = Convert.ToDouble(WithdrawAmountTextbox.Text);

            bool errorExists = true;

            if ((CurrentAccountRadioButton3.Checked == true) && (withdrawalAmount <= 100000) && (withdrawalAmount >= 0))
            {
                foreach (Account account in accountsList)
                {
                    if ((accNo == account.getAccountNo()) && (account.getBalance() >= withdrawalAmount))
                    {
                        account.Withdraw(withdrawalAmount);
                        errorExists = false;
                    }
                    else
                    {
                        MessageBox.Show("Withdrawal amount cannot be larger than account balance.");
                    }

                    if (account.getBalance() < 500)
                    {
                        account.Deposit(withdrawalAmount);
                        MessageBox.Show("Error! Minimum balance BDT 500.");
                        errorExists = true;
                    }

                    if(errorExists == false)
                    {
                        MessageBox.Show("Withdrawal successful!");
                    }
                }
            }

            else if ((SavingsAccountRadioButton3.Checked == true) && (withdrawalAmount >= 0))
            {
                foreach (Account account in accountsList)
                {
                    if (accNo == account.getAccountNo() && (account.getBalance() >= withdrawalAmount))
                    {
                        SavingsAccount.countTransaction();

                        if (SavingsAccount.count <= 5)
                        {
                            account.Withdraw(withdrawalAmount + SavingsAccount.withdrawalCharge);
                            MessageBox.Show("Withdrawal successful!");
                        }

                        else
                        {
                            MessageBox.Show("Transaction Limit Reached.");
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Invalid input!!!");
            }
        }
    }
}
