using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new ClassesAndObjects.Person();
            Person person2 = new Person();

            Person me = new Person();
            me.FirstName = "David";
            me.LastName = "Wademan";
            me.GetFullName();

            me.Walk();
            me.Eat();
            me.Talk();
            me.Sleep();
            me.Walk2();
            Console.WriteLine();

            SuperPerson superMe = new SuperPerson();
            superMe.FirstName = "Super";
            superMe.LastName = "Wademan";
            superMe.GetFullName();

            superMe.Walk();
            superMe.Eat();
            superMe.Talk();
            superMe.Sleep();
            superMe.Fly();
            superMe.Walk2();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }
    }
}
