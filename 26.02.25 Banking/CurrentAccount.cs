using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._25_Banking
{
    internal class CurrentAccount:BankAccount
    {
        protected double overdraft_limit;

        public CurrentAccount(string holder, int number, double balance, double overdraft_limit) : base(holder, number, balance)
        {
            this.overdraft_limit = overdraft_limit;
        }
        public override void Withdraw(double amount)
        {
            if (amount < accountBalance)
            {
                accountBalance -= amount;
            }
            else if (accountBalance - amount < overdraft_limit)
            {
                Console.WriteLine("Withdraw not allowed: exceeded overdraft limit");
            }
            else if (amount > accountBalance)
            {
                Console.WriteLine("Using overdraft");
                accountBalance -= amount;
            }
        }
    }
}
