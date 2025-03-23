namespace _26._02._25_Banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank_account = new BankAccount("Samuel", 123, 5.50);
            Console.WriteLine(bank_account.ToString());
            bank_account.Deposit(900);
            Console.WriteLine(bank_account.ToString());
            bank_account.Deposit(900);
            Console.WriteLine(bank_account.ToString());
            Console.WriteLine();

            SavingsAccount savings_account = new SavingsAccount("Ethan", 333, 0, 5.50);
            Console.WriteLine(savings_account.ToString());
            savings_account.AddInterest();
            Console.WriteLine(savings_account.ToString());
            savings_account.AddInterest();
            Console.WriteLine(savings_account.ToString());
            Console.WriteLine();

            CurrentAccount current_account = new CurrentAccount("Mari", 212, 600, -800);
            Console.WriteLine(current_account.ToString());
            current_account.Withdraw(900);
            Console.WriteLine(current_account.ToString());
            current_account.Withdraw(900);
            Console.WriteLine(current_account.ToString());
        }
    }
}
