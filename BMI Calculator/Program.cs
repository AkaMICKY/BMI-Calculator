using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What Is Your Weight(Kg)? : ");
            string Mass = Console.ReadLine();
            double MASS = Convert.ToDouble(Mass);
            Console.Write("What is Height(Meters)? : ");
            string Height = Console.ReadLine();
            double HEIGHT = Convert.ToDouble(Height);
            double HEIGHT2 = Math.Pow(HEIGHT, 2);
            double BMI = MASS /HEIGHT2;
            double BMI_round = Math.Round(BMI, 2);
            Console.WriteLine("Your BMI Is " + BMI_round);
            Console.WriteLine("If Your BMI Is <18.5 = UNDER-WEIGT");
            Console.WriteLine("If Your BMI Is 18.5-24.9 = HEALTHY WEIGHT ");
            Console.WriteLine("If Your BMI Is 25-29.9 = OVER-WEIGHT");
            Console.WriteLine("If Your BMI Is >30 , You Are OBESE!!!");
        }
    }
}
