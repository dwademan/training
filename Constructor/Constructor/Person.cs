using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Person
    {
        private string _firstname;
        private string _lastname;
        private int _age;

        // Constructor
        public Person()
        {
            _firstname = "Jane";
            _lastname = "Doe";
            _age = 99;
        }

        public Person(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = 25;
        }

        // Constructor Overloading Methods
        public Person(string firstname, string lastname, int age)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
        }

        // Constructor Overloading Methods 2
        public Person(string firstname, int age)
        {
            _firstname = firstname;
            _lastname = "Smith";
            _age = age;
        }

        public string GetFullname()
        {
            return $"{_firstname} {_lastname} {_age}";
        }
    }
}
