using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Customer
    {
        private readonly string pin;
        public Person Person { get; }
        public BankAccount Account { get; }

        public Customer(string name, string personalNumber, string pin)
        {
            Person = new Person(name, personalNumber);
            Account = new BankAccount();
            this.pin = pin;
        }

        public bool Authenticate(string inputPin)
        {
            return inputPin == pin;
        }

    }
}
