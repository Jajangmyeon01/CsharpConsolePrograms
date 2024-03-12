using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputObjectCreation
{
    internal class CarsModel
    {
        public string carName;
        public string Color;
        public string Description;
        public float price;

        public CarsModel(string carName, string Color, string Description, float price)
        {
            this.carName = carName;
            this.Color = Color;
            this.Description = Description;
            this.price = price;

        }
    }
}
