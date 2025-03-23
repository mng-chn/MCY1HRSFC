using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._25_Banking
{
    internal class SavingsAccount: BankAccount
    {

        protected double interest;
        public SavingsAccount(string holder, int number, double balance, double interest): base(holder,number,balance)
        {
            this.interest = interest;
        }

        public override void Withdraw(double amount)
        {
            if (amount > accountBalance)
            {
                Console.WriteLine("Withdraw not allowed");
            }
            else
            {
                accountBalance -= amount;
            }
        }

        public void AddInterest()
        { 
            accountBalance += interest*accountBalance;
        }
    }
}
