using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationSimulationV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Authentication SimulationV2 --
            Console.WriteLine("(Authentication SimulationV2)");

            string[] userName = { "BankLogin", "Sterling", "ebay44" };
            string[] passWord = { "BankLogin13", "SterlingGmal2024", "ebay.44" };

            Console.Write("Enter Username : ");
            var inputUserIndex = Console.ReadLine();
            Console.Write("Enter Password : ");
            var inputPasswordIndex = Console.ReadLine();
            bool isLogin = false;

            for (int user = 0; user < userName.Length; user++)
            {
                if (inputUserIndex.Equals(userName[user]) && inputPasswordIndex.Equals(passWord[user]))
                //, StringComparison.InvariantCultureIgnoreCase 
                {
                    isLogin = true;
                    Console.WriteLine($"Welcome, {userName[user]}!");
                    break;
                }

            }
            if (!isLogin)
            {
                Console.WriteLine("Account Not Found!");
            }


            #endregion

            Console.ReadLine();
        }
    }
}
