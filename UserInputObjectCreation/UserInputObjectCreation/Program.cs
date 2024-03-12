using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UserInputObjectCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region -- UserInputObjectCreation --
            Console.Write("Enter CarName : ");
            var carName = Console.ReadLine();

            Console.Write("Enter Color : "); ;
            var color = Console.ReadLine();

            Console.Write("Enter Description : ");
            var description = Console.ReadLine();

            Console.Write("Enter Price : ");
            var price = Convert.ToInt64(Console.ReadLine());

            CarsModel car = new CarsModel(carName, color, description, price);

            Console.WriteLine($"CarName : {car.carName}\n Color : {car.Color}\n Description : {car.Description}\n Price : {car.price}");
            #endregion

            Console.ReadLine();
        }
    }
}
