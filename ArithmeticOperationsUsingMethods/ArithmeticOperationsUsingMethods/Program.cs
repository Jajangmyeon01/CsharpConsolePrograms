using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperationsUsingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Summation of Numbers in Main --
            // Summation of Numbers //
            Console.WriteLine("(Summation of Numbers)");

            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine(Sum(numbers));

            // Difference of Numbers//
            Console.WriteLine("(Difference of Numbers)");
            int[] numbers2 = { 10, 20, 30, 40, 50 };
            Console.WriteLine(Dif(numbers2));

            // Product of Numbers //
            Console.WriteLine("(Product of Numbers)");
            int[] numbers3 = { 7, 7};
            Console.WriteLine(Prod(numbers3));

            // Quotient of Numbers //
            Console.WriteLine("(Quotient of Numbers)");
            int[] numbers4 = { 5,2};
            Console.WriteLine(Quo(numbers4));


            #endregion

            Console.ReadLine();

        }
        #region -- Summation of Numbers --
        static int Sum(int[] num)
        {
            int sumofall = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sumofall += num[i];
            }
            return sumofall;

        }
        static int Dif(int[] num2)
        {
            int difofall = 0;
            for (int i = 0; i < num2.Length; i++)
            {
                difofall -= num2[i];
            }
            return difofall;
        }
        static int Prod(int[] num3)
        {
            int prodofall = 1;
            for (int i = 0; i < num3.Length; i++)
            {
                prodofall *= num3[i];
            }
            return prodofall;

        }
        static int Quo(int[] num4)
        {
            if (num4.Length == 0) return 0; 
            if (num4.Length == 1) return num4[0]; 

            int quoofall = num4[0];
            for (int i = 1; i < num4.Length; i++)
            {
                if (num4[i] == 0) 
                {
                    Console.WriteLine("Division by zero.");
                    continue;
                }
                quoofall /= num4[i];
            }
            return quoofall;
        }
  


        #endregion
    }
}
