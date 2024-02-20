using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofIntegersSummation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Array of Integers Summation --
            Console.WriteLine("(Array of Integers Summation)");

            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80 };
            int total = 0;
            foreach (var num in numbers)
            {
                total += num;
            }
            Console.WriteLine($"Total Sum : {total}");
            #endregion


            Console.ReadLine();
        }
    }
}
