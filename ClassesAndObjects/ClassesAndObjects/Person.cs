using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void GetFullName()
        {
            Console.WriteLine("My name is {0} {1}.", FirstName, LastName);
        }
        public void Walk()
        {
            Console.WriteLine("I am walking.");
        }

        public void Talk()
        {
            Console.WriteLine("I am talking.");
        }

        public void Eat()
        {
            Console.WriteLine("I am eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping.");
        }

        public void Walk2()
        {
            Console.WriteLine("I am walking as a normal person.");
        }
    }
}
