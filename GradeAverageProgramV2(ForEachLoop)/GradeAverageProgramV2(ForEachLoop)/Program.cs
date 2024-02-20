using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeAverageProgramV2_ForEachLoop_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region -- Grade Average ProgramV2(ForEachLoop)
            Console.WriteLine("Grade Average ProgramV2(ForEachLoop)");

            Console.Write("WebProg Grade : ");
            var WebProg = Convert.ToSingle(Console.ReadLine());
            Console.Write("Dmath Grade : ");
            var DMath = Convert.ToSingle(Console.ReadLine());
            Console.Write("MultiMedia Grade : ");
            var MultiMedia = Convert.ToSingle(Console.ReadLine());
            Console.Write("CompEngineering Grade : ");
            var CompEngineering = Convert.ToSingle(Console.ReadLine());

            float[] grades = { WebProg, DMath, MultiMedia, CompEngineering };
            float average = 0;
            foreach (var grade in grades)
            {
                average += grade / 4;
            }

            Console.WriteLine();

            Console.WriteLine($"Total Grade Average : {average.ToString("F2")} ");

            if (average >= 95.0f && average <= 100.0f)
            {
                Console.WriteLine("Highest Average!");
            }
            else if (average >= 90.0f && average < 95.0f)
            {
                Console.WriteLine("High Average!");
            }
            else if (average >= 80.0f && average < 90.0f)
            {
                Console.WriteLine("General Average!");
            }
            else if (average >= 75.0f && average < 80.0f)
            {
                Console.WriteLine("Passing Average!");
            }
            else if (average < 75.0f)
            {
                Console.WriteLine("Failed Average!");
            }
            else
            {
                Console.WriteLine("Invalid Grade!");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
