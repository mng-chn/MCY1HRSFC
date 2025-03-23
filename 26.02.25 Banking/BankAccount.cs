using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._25_Banking
{
    public class BankAccount
    {
        //Attributes
        protected string accountHolder;
        protected int accountNumber;
        protected double accountBalance;

        //Constructor
        public BankAccount(string holder, int number, double balance)
        {
            accountHolder = holder;
            accountNumber = number;
            accountBalance = balance;
            Console.WriteLine("Bank Account Created");
        }

        public void Deposit(double amount)
        {
            accountBalance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            accountBalance -= amount;
        }

        public double GetBalance()
        {
            return accountBalance;
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }
        public string GetAccountHolder()
        {
            return accountHolder;
        }
        
        public override string ToString()
        {
            return $"Holder: {accountHolder} \tNumber: {accountNumber} \tBalance: {accountBalance}";
        }
    }
}
