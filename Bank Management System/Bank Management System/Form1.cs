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
        List<CurrentAccount> currentAccountsList = new List<CurrentAccount>();
        List<SavingsAccount> savingsAccountsList = new List<SavingsAccount>();
        List<LoanAccount> loanAccountsList = new List<LoanAccount>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string name = NameTextbox.Text;
            double depositAmount = Convert.ToDouble(AmountTextbox1.Text);

            if ((CurrentAccountRadioButton.Checked == true) && (depositAmount > 0))
            {
                CurrentAccount dummyCurrentAccount = new CurrentAccount();

                dummyCurrentAccount.setAccountName(name);
                dummyCurrentAccount.setBalance(depositAmount);

                currentAccountsList.Add(dummyCurrentAccount);

                AccountNumberLabel.Text = dummyCurrentAccount.getNextAccountNo();

                MessageBox.Show("Account has been created successfully!\n\n" + "Account Name: " + dummyCurrentAccount.getAccountName() + "\n" + "Account No.:     " + dummyCurrentAccount.getNextAccountNo());
            }

            else if ((SavingsAccountRadioButton.Checked == true) && (depositAmount >= 50000))
            {
                SavingsAccount dummySavingsAccount = new SavingsAccount();

                dummySavingsAccount.setAccountName(name);
                dummySavingsAccount.setBalance(depositAmount);

                savingsAccountsList.Add(dummySavingsAccount);

                AccountNumberLabel.Text = dummySavingsAccount.getNextAccountNo();

                MessageBox.Show("Account has been created successfully!\n\n" + "Account Name: " + dummySavingsAccount.getAccountName() + "\n" + "Account No.:     " + dummySavingsAccount.getNextAccountNo());
            }

            else if ((LoanAccountRadioButton.Checked == true) && (depositAmount > 0))
            {
                LoanAccount dummyLoanAccount = new LoanAccount();

                dummyLoanAccount.setAccountName(name);
                dummyLoanAccount.setBalance(depositAmount);

                loanAccountsList.Add(dummyLoanAccount);

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

            foreach(CurrentAccount account in currentAccountsList)
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
    }
}
