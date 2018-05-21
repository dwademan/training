using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Person
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return $"The fullname of the person is {FirstName} {LastName}.";
        }
    }
}
