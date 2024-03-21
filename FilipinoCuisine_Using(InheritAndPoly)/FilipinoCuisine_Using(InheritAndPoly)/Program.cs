using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilipinoCuisine_Using_InheritAndPoly_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Inheritance with Polymorphism --
            Console.WriteLine("(Inheritance with Polymorphism)");

            Food food1 = new Food("Food", "Food is so Good!", 10, 20.22f);

            Sinigang sinigang1 = new Sinigang("Sinigang", "IloveSinigang", 19, 50.43f, "Sinigang Mix");
            sinigang1.allDescription();
            sinigang1.Sour();
            sinigang1.Oily();
            sinigang1.Delicous();
            sinigang1.sinigangmix();

            Console.WriteLine();

            Adobo adobo1 = new Adobo("Adobo", "IloveAdobo", 14, 60.73f, "SoySauce and Vinegar");
            adobo1.allDescription();
            adobo1.Salty();
            adobo1.Oily();
            adobo1.Delicous();
            adobo1.soysauceandvinegar();

            Console.WriteLine();

            KareKare karekare1 = new KareKare("KareKare", "IloveKareKare", 22, 70.12f, "Peanut Butter");
            karekare1.allDescription();
            karekare1.Savory();
            karekare1.Oily();
            karekare1.Delicous();
            karekare1.peanut();

            Console.WriteLine();

            BicolExpress bicolexpress1 = new BicolExpress("BicolExpress", "IloveBicolExpress", 11, 40.88f, "ChiliPeppers");
            bicolexpress1.allDescription();
            bicolexpress1.Spicy();
            bicolexpress1.Oily();
            bicolexpress1.Delicous();
            bicolexpress1.chilipeppers();

            #endregion

            Console.ReadLine();
        }
    }
}
