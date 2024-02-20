using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationAndClassAttendance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Equals Method -- 

            Console.Write("Enter Username: ");
            string user = Console.ReadLine();

            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();


            if (user.Equals("Jajangmyeon", StringComparison.InvariantCultureIgnoreCase) && pass.Equals("admin123", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Welcome User!");
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
            #endregion

            #region -- Using || (OR) Method with NESTED LOOP --

            bool present = true;

            Console.Write("Did you attend the class last week? (Please respond with 'present,' 'absent,' 'late', or 'cutting'): ");
            string response = Console.ReadLine();

            if (response.ToLower() == "absent")
            {
                Console.WriteLine("No grade will be assigned!");
            }
            else if (response.ToLower() == "present" || response.ToLower() == "late" || response.ToLower() == "cutting")
            {
                if (response.ToLower() == "late")
                {
                    Console.Write("At what time did you attend? (1.00 - 4.00(class) if 4.01(its late): ");
                    float time = Convert.ToSingle(Console.ReadLine());

                    if (time >= 4.01f && time < 5.00f)
                    {
                        Console.WriteLine("You arrived late to the class, but you will receive a grade");
                    }
                    else if (time >= 5.01f && time < 6.00f)
                    {
                        Console.WriteLine("Grade will be fashionably late!");
                    }
                    else
                    {
                        Console.WriteLine("Please input correct response, Thanks!");
                    }
                }
                else if (response.ToLower() == "cutting")
                {
                    Console.WriteLine("Your grade will be cut!");
                }
                else
                {
                    Console.Write("At what time did you attend? (1.00 - 4.00(class): ");
                    float time = Convert.ToSingle(Console.ReadLine());

                    if (present || (time >= 1.00f && time < 3.59f))
                    {
                        Console.WriteLine("You will receive a grade!");
                    }
                    else
                    {
                        Console.WriteLine("Please input correct response, Thanks!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please input correct response, Thanks!");
            }
            Console.ReadLine();
            #endregion

        }
    }
}
