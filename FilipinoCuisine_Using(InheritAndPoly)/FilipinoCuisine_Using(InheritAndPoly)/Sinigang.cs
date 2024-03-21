using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilipinoCuisine_Using_InheritAndPoly_
{
    internal class Sinigang : Food
    {
        public string SinigangMix { get; set; }
        public Sinigang(string name, string Description, int qty, float price, string SinigangMix) : base(name, Description, qty, price)
        {
            this.SinigangMix = SinigangMix;
        }

        public void Sour()
        {
            Console.WriteLine("This food is Sour!");
        }
        override public void Oily()
        {
            Console.WriteLine("This food is Oily!");
        }
        override public void Delicous()
        {
            Console.WriteLine("This food is Delicous!");
        }
        public void sinigangmix()
        {
            Console.WriteLine($"Sinigang is using {SinigangMix}");
        }
    }
}
