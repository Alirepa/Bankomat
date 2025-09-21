using System;

namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Ali Reza", "061017-1234", "1234");

            Console.WriteLine("-------Welcome to the ATM-------");

            bool isAuthenticated = false;
            while (!isAuthenticated) 
            {
            Console.Write("Enter your 4 digit PIN-Code: ");
                string inputPin = Console.ReadLine();

                isAuthenticated = customer.Authenticate(inputPin);

                if (!isAuthenticated)
                {
                    Console.WriteLine("Incorrect PIN, try again!");
                }
            }

            bool exit = false;
            while (!exit)
            {
                
                Console.WriteLine("1. Depoiste money");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Check balance");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose an option (1-4)");

                string choice = Console.ReadLine();

                switch (choice) 
                {
                    case "1":
                        DepositMoney(customer);
                        break;
                    case "2":
                        WithdrawMoney(customer);
                        break;
                    case "3":
                        ShowBalance(customer);
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again!");
                        break;
                }
            }
        }


        static void DepositMoney(Customer customer) 
        {
            Console.WriteLine("Amount to deposit: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                customer.Account.Deposit(amount);
            }
            else 
            {
                Console.WriteLine("Invalid amount, choose a number");
            }
        }
        static void WithdrawMoney(Customer customer) 
        {
            Console.WriteLine("Amount to withdraw");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                customer.Account.Withdraw(amount);
            }
            else 
            {
                Console.WriteLine("Invalid amount, choose a number");
            }

        }
        static void ShowBalance(Customer customer) 
        {
            Console.WriteLine($"Your amount is: {customer.Account.Balance} sek");
        }
    }
}
