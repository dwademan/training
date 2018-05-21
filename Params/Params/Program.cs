using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(1, 2, 3));
            Console.WriteLine(GetSumImproved(1,2,3,4,5,6,7,8,9));
            Console.WriteLine(GetSumImproved(1, 2));
            Console.WriteLine(GetSumImproved(1, 2, 3));

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

        static int GetSum(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        static int GetSumImproved(params int[] numbersToSum)
        {
            int sum = 0;
            foreach (var number in numbersToSum) sum = sum + number; 
            return sum;
        }

    }
}
