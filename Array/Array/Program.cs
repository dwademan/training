using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            Console.WriteLine("--------------------");
            Console.WriteLine("Array int[5]");
            Console.WriteLine("--------------------");
            Console.WriteLine("Rank = {0}", array.Rank);
            Console.WriteLine("Length = {0}", array.Length);
            Console.WriteLine();

            array[0] = 1;
            array[1] = 10;
            array[2] = 100;
            array[3] = 1000;
            array[4] = 10000;

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
            Console.WriteLine();

            int[,] array2 = new int[5, 2];

            Console.WriteLine("--------------------");
            Console.WriteLine("Array int[5,2]");
            Console.WriteLine("--------------------");
            Console.WriteLine("Rank = {0}", array2.Rank);
            Console.WriteLine("Length = {0}", array2.Length);
            Console.WriteLine();

            // write array values
            array2[0, 0] = 1;
            array2[0, 1] = 2;
            array2[1, 0] = 3;
            array2[1, 1] = 4;
            array2[2, 0] = 5;
            array2[2, 1] = 6;
            array2[3, 0] = 7;
            array2[3, 1] = 8;
            array2[4, 0] = 9;
            array2[4, 1] = 10;

            // for loop
            for (int row = 0; row < ((array2.Length) / (array2.Rank)); row++)
            {
                Console.WriteLine("Row {0}:  {1} - {2}", row, array2[row, 0], array2[row, 1]);
            }


            int[] array3 = new int[7];

            Console.WriteLine("--------------------");
            Console.WriteLine("Array int[7]");
            Console.WriteLine("--------------------");
            Console.WriteLine("Rank = {0}", array3.Rank);
            Console.WriteLine("Length = {0}", array3.Length);
            Console.WriteLine();

            array3[0] = 1;
            array3[1] = 10;
            array3[2] = 100;
            array3[3] = 1000;
            array3[4] = 10000;
            array3[5] = 100000;
            array3[6] = 1000000;

            // foreach loop
            foreach (var element in array3)
            {
                Console.WriteLine("Element: {0}", element);
            }

            int[] array4 = new int[5] { 1, 2, 3, 4, 5 };

            List<int> list1 = new List<int>() { 10, 20, 30, 40, 50 };
            list1.Add(60);
            list1.RemoveAt(5);


            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
