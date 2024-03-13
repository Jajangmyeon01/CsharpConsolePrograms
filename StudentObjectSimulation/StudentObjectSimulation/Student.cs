using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentObjectSimulation
{
    internal class Student
    {
        public string firstName, lastName, course;
        public int year, section;
        public float midtermGrade, finalGrade;
        
        public Student(string firstName, string lastName, string course, int year, int section, float midtermGrade, float finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;   
            this.course = course;
            this.year = year;
            this.section = section;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }
        public void introduceSelf()
        {
            Console.WriteLine($" Full Name : {firstName} {lastName}\n Course    : {course}\n Year      : {year}\n Section   : {section}");
        }
        public void evaluateGrade()
        {
            float average = (midtermGrade + finalGrade) / 2;
            Console.WriteLine($"Your average is : {average.ToString("F2")}");

            if (average > 100 )
            {
                Console.WriteLine("Invalid Grade!");
            }
            else if (average >= 98 && average <= 100 )
            {
                Console.WriteLine("With Highest Honors!");
            }
            else if (average >= 95 && average <= 97.99)
            {
                Console.WriteLine("With High Honors!");
            }
            else if (average >= 90 && average <= 94.99)
            {
                Console.WriteLine("With Honors!");
            }
            else if (average >= 75 && average <= 89.99)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
         
        }
        
        
    }
}
