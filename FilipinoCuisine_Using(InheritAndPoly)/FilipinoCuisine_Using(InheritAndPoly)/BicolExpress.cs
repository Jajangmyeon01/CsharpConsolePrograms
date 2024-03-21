using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilipinoCuisine_Using_InheritAndPoly_
{
    internal class BicolExpress : Food
    {
        public string ChiliPeppers { get; set; }
        public BicolExpress(string name, string Description, int qty, float price, string ChiliPeppers) : base(name, Description, qty, price)
        {
            this.ChiliPeppers = ChiliPeppers;
        }
        public void Spicy()
        {
            Console.WriteLine("This food is Spicy!");
        }
        override public void Oily()
        {
            Console.WriteLine("This food is Oily!");
        }
        override public void Delicous()
        {
            Console.WriteLine("This food is Delicous!");
        }
        public void chilipeppers()
        {
            Console.WriteLine($"This food is using {ChiliPeppers}");
        }

    }
}
