using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class Form1 : Form
    {
        // Bank account with a start of $2000

        private  Account account = new Account(2000);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // display the starting balance

            BalanceLabel.Text = account.Balance.ToString();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            decimal amount;

            // convert the amount to a decimal 

            if(decimal.TryParse(DepositTextBox.Text, out amount))
            {
                // deposit the amount into the account

                account.deposit(amount);

                // display the new balance

                BalanceLabel.Text = account.Balance.ToString();

                // clear the box

                DepositTextBox.Clear();

            }
        }

        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            decimal amount;

            // convert the amount to a decimal

            if (decimal.TryParse(WithdrawalTextBox.Text, out amount))
            {
                //withdrawal from the amount

                account.withdrawal(amount);

                BalanceLabel.Text = account.Balance.ToString();

                // clear the box

                WithdrawalTextBox.Clear();
            }


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
