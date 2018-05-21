using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionsAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal simpleExpression1 = 5 - 10;
            decimal simpleExpression2 = 4 * 10;
            decimal complexExpression1 = (((6 * 7) - 4) + simpleExpression1) / simpleExpression2;
            Console.WriteLine(simpleExpression1);
            Console.WriteLine(simpleExpression2);
            Console.WriteLine(complexExpression1);

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
