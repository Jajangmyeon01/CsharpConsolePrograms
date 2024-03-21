using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilipinoCuisine_Using_InheritAndPoly_
{
    internal class Adobo : Food
    {
        public string SoySauceAndVinegar { get; set; }
        public Adobo(string name, string Description, int qty, float price, string SoySauceAndVinegar) : base(name, Description, qty, price)
        {
            this.SoySauceAndVinegar = SoySauceAndVinegar;
        }
        public void Salty()
        {
            Console.WriteLine("This food is Salty!");
        }
        override public void Oily()
        {
            Console.WriteLine("This food is Oily!");
        }
        override public void Delicous()
        {
            Console.WriteLine("This food is Delicous!");
        }
        public void soysauceandvinegar()
        {
            Console.WriteLine($"Adobo is using {SoySauceAndVinegar}");
        }
    }
}
