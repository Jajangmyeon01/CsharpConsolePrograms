using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLoginSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Account Login Simulation --
            Console.WriteLine("(Account Login Simulation)");

            string[] usernames = { "admin", "Anna", "Sussy" };
            string[] passwords = { "admin123", "hana", "baka" };

            Console.Write("Enter Username: ");
            var inputUsername = Console.ReadLine();
            Console.Write("Enter Password: ");
            var inputPassword = Console.ReadLine();

            bool isSuccessful = false;

            for (var i = 0; i < usernames.Length; i++)
            {
                if (usernames[i].Equals(inputUsername) && passwords[i].Equals(inputPassword))
                {
                    isSuccessful = true;
                    break;
                }
            }

            if (isSuccessful)
            {
                Console.WriteLine($"Welcome, {inputUsername}!");
            }
            else
            {
                Console.WriteLine("Account Not Found!");
            }
            #endregion
            Console.ReadLine();
        }
    }
}
