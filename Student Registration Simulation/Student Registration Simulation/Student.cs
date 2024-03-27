using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Simulation
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int year { get; set; }
        public string course { get; set; }
        public char section { get; set; }

        public Student(string firstName, string lastName, int year, string course, char section)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;

        }
        public void introduceSelf()
        {
            Console.WriteLine();
            Console.WriteLine($"Full Name : {lastName} {firstName}");
            Console.WriteLine($"Course/Year/Section : {course} {year} {section}");
        }

    }
}
