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

        public BankAccount() 
        {
            balance = 1000;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0");
                return;
            }
            balance += amount;
            //Console.WriteLine($"Deposited: {amount} sek, New Balance: {Balance} sek");
            //behöver inte använda då det skriver ut hur mycket man har i balance så om man vill hålla det privat, man kan kolla genom att trycka på 3(check balance)
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
            //Console.WriteLine($"You withdrawed {amount} sek, New balance: {Balance} sek");
            //behöver inte använda då det skriver ut hur mycket man har i balance så om man vill hålla det privat, man kan kolla genom att trycka på 3(check balance)
        }
    }
}
