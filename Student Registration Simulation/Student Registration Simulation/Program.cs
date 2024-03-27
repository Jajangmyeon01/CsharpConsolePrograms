using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Student Registration Simulation --
            Console.WriteLine("(Studen Registration Simulation)");

            Console.Write("Student Count : ");
            var count = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[count];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Student : " + (i + 1));
                Console.Write("Enter FirstName: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter LastName: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter Year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course: ");
                string course = Console.ReadLine();

                Console.Write("Enter Section : ");
                char section = Convert.ToChar(Console.ReadLine());

                students[i] = new Student(firstName, lastName, year, course, section);

                
            }
            foreach(Student student in students)
            {
                student.introduceSelf();
            }
             
            
            #endregion

            Console.ReadLine();
        }
    }
}
