using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class SuperPerson : Person
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }

        public new void Walk2()
        {
            Console.WriteLine("I am walking as a super person.");
        }
    }
}
