using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilipinoCuisine_Using_InheritAndPoly_
{
    internal class KareKare : Food
    {
        public string peanutButter { get; set; }
        public KareKare(string name, string Description, int qty, float price, string peanutButter) : base(name, Description, qty, price)
        {
            this.peanutButter = peanutButter;
        }
        public void Savory()
        {
            Console.WriteLine("This food is Savory!");
        }
        override public void Oily()
        {
            Console.WriteLine("This food is Oily!");
        }
        override public void Delicous()
        {
            Console.WriteLine("This food is Delicous!");
        }
        public void peanut()
        {
            Console.WriteLine($"Kare Kare is using a {peanutButter}");
        }

    }
}
