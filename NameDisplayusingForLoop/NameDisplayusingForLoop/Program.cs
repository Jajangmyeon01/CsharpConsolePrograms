using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameDisplayusingForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Name Display using For Loop
            Console.WriteLine("(Name Display using For Loop)");

            string[] arrayNames = new string[3];

            for (int b = 0; b < 3; b++)
            {
                Console.Write($"Enter Name {b + 1} : ");
                arrayNames[b] = Console.ReadLine();
            }


            for (int index = 0; index < arrayNames.Length; index++)
            {
                Console.WriteLine(arrayNames[index]);
            }

            #endregion

            Console.ReadLine();

        }
    }
}
