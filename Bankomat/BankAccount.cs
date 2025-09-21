using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance 
        {
        get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive");
                return;
            }
            balance += amount;
            Console.WriteLine($"Deposited: {amount} sek, New Balance: {Balance} sek");
        }

        public void Withdraw(decimal amount) 
        {
            if (amount <= 0) 
            {
                Console.WriteLine("Amount must be positive");
                return;
            }
            if (amount > balance) 
            {
                Console.WriteLine("Insufficient funds");
                return;
            }

            balance -= amount;
            Console.WriteLine($"You withdrawled {amount} sek, New balance : {Balance} sek");
        }
    }
}
