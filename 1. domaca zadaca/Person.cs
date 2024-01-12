using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._domaca_zadaca
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public Person(string firstName, string lastName, int iD)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
        }
    }
}
