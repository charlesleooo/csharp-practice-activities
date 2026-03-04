using System;


namespace MyApplication
{
    class BankAccount
    {
        private int Balance;

        public BankAccount(int value = 1000)
        {
            Balance = value;
        }   
        public void Withdraw(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount");
            }

            else if (Balance < amount)
            {
                Console.WriteLine("Insufficient funds.");
            }

            else
            {
                Balance = Balance - amount;
                Console.WriteLine($"You have withdrawn the amount of {amount} PHP");
                Console.WriteLine($"Your Remaining Balance is: {Balance} PHP");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your balance is: {Balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.CheckBalance();
            Console.Write("Enter the amount you want to withdraw: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            account.Withdraw(amount);

        }
    }
}