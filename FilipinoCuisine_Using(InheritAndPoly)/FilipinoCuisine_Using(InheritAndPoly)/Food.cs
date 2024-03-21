using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilipinoCuisine_Using_InheritAndPoly_
{
    internal class Food
    {
        public string name { get; set; }
        public string Description { get; set; }
        public int qty { get; set; }
        public float price { get; set; }

        public Food(string name, string Description, int qty, float price)
        {
            this.name = name;
            this.Description = Description;
            this.qty = qty;
            this.price = price;


        }
        virtual public void Oily()
        {
            Console.WriteLine("This food is Oily!");
        }
        virtual public void Delicous()
        {
            Console.WriteLine("This food is Delicous!");
        }
        public void allDescription()
        {
            Console.WriteLine($"Name of the Food : {name}");
            Console.WriteLine($"Description of the Food : {Description}");
            Console.WriteLine($"Quantity of the Food : {qty}");
            Console.WriteLine($"Price of the Food : {price}");
        }
    }
}
