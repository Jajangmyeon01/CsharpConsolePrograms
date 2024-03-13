using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentObjectSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Student Object Simulation --
            Console.WriteLine("(Student Object Simulation)");

            Student stud1 = new Student("Gen","Vergara","BSIT", 2024, 3, 95.6f, 94.4f);
            stud1.introduceSelf();
            stud1.evaluateGrade();
            #endregion 

            Console.ReadLine();
        }
    }
}
