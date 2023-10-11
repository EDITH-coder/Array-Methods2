using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 2, 5, 3, 7, 4 };
            int[] num1 = { 10, 2, 5, 3, 7, 4 };

            Array.Sort(num);
            Array.Reverse(num1);
            Console.WriteLine("This is the elements in order");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("This is the elements in reverse");

            for (int i = 0; i < num1.Length; i++)
            {
                Console.WriteLine(num1[i]);
            }
            // Console.WriteLine( "The original array: " +num);

            Console.ReadLine();
        }
    }
}
