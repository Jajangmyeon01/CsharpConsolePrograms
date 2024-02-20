using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame__withLives_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Quiz Game w/Lives --
            var lives2 = 5;
            var answer2 = "Elon Musk";

            while (lives2 > 0)
            {
                Console.Write("Who's the richest person in the world? ");
                string userInput2 = (Console.ReadLine());
                Console.WriteLine();

                if (String.Equals(userInput2, answer2, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else
                {
                    lives2--;
                    Console.WriteLine($"Incorrect! You have {lives2} remaining");
                }
            }
            if (lives2 > 0)
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine($"You Lost! You have {lives2} remaining");
            }

            #endregion
            Console.ReadLine();
        }
    }
}
