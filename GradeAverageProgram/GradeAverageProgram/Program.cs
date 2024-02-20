using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeAverageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Grade Average Program)");
            // 100 (Invalid Grade), 98-100 (With Highest Honors), 95-97.99 (With High Honors), 90-94.99 (With Honors), 75-89.99 (Passed)

            Console.Write("Enter English Grade : ");
            float English = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Math Grade : ");
            float Math = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Science Grade : ");
            float Science = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Computer Grade : ");
            float Computer = Convert.ToSingle(Console.ReadLine());

            float average = (English + Math + Science + Computer) / 4;
            Console.WriteLine($"Average : {average.ToString("F2")}");

            if (average >= 100)
            {
                Console.WriteLine("Invalid Grade");
            }
            else if (average >= 98 && average <= 100)
            {
                Console.WriteLine("With Highest Honors");
            }
            else if (average >= 95 && average <= 97.99)
            {
                Console.WriteLine("With High Honors");
            }
            else if (average >= 90 && average <= 94.99)
            {
                Console.WriteLine("With Honors");
            }
            else if (average >= 75 && average <= 89.99)
            {
                Console.WriteLine("Passed");
            }else if (average >= 0.00  && average <= 74.99)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("Invalid Input Grade");
            }
            Console.ReadLine();
        }
    }
}
