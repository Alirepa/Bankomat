using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Person
    {
        public string Name { get; }
        public string PersonlNumber { get; }

        public Person(string name, string personlNumber)
        {
            Name = name;
            PersonlNumber = personlNumber;
        }
    }
}
