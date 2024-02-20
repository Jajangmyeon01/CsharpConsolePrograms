using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNameDisplayusingForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Reverse User Input Name Display  using For Loop -- 
            Console.WriteLine("(Reverse User Input Name Display  using For Loop)");

            string[] arrayNames2 = new string[3];

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter name {j + 1} : ");
                arrayNames2[j] = Console.ReadLine();
            }

            for (int e = 0; e < arrayNames2.Length; e++)
            {
                Console.Write($"Reversed name {e + 1} : ");
                for (int indexReversed = arrayNames2[e].Length - 1; indexReversed >= 0; indexReversed--)
                {
                    Console.Write(arrayNames2[e][indexReversed]);

                }
                #endregion
                Console.ReadLine();
            }
  
        }
    }
}


