using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in switch: ");
            string choice = Console.ReadLine();
            choice = choice.ToUpper();

            // branching
            switch (choice)
            {
                case "DAVID":
                    // David will execute this
                    Console.WriteLine("Hi David!");
                    break;
                case "VS":
                    // VS will execute this
                    Console.WriteLine("Welcome to Visual Studio C#!");
                    break;
                case "HI":
                    // Only Hi will execute this
                    Console.WriteLine("Hi there stranger!");
                    break;
                default:
                    // When there is no match (CASE 1 in Envision Language)
                    Console.WriteLine("There was no match.");
                    break;
            }

            // conditional and boolean operator (|| - or && - and)
            if (((choice.Equals("DAVID"))) || ((choice.Equals("HI"))))
            {
                // David will execute this
                Console.WriteLine("Welcome back again!");
            }
            else if (choice.Equals("VS"))
            {
                Console.WriteLine("Welcome back to Visual Studio C#!");
            }
            else
            {
                // When there is no match (CASE 1 in Envision Language)
                Console.WriteLine("There was still no match.");
            }

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
