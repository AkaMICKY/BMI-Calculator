using Microsoft.SqlServer.Server;
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
            Console.WriteLine("Welcome to BMI-Calculator");
            Console.WriteLine("Choose an Option to Calculate Your BMI");
            Console.WriteLine("1. Weight-Kilograms(KG) and Height-Meters(M)");
            Console.WriteLine("2. Weight-Pounds(Lbs) and Height-Inches(Inch)");
            string choice = Console.ReadLine(  );
            if (int.TryParse(choice, out int CHOICE) )
            {
                if (CHOICE == 1)
                {
                    Console.Write("What Is Your Weight(Kg)? : ");
                    string Mass = Console.ReadLine();
                    if (double.TryParse(Mass, out double MASS))
                    {
                        Console.Write("What is Height(Meters)? : ");
                        string Height = Console.ReadLine();
                        if (double.TryParse(Height, out double HEIGHT))
                        {
                            double HEIGHT2 = Math.Pow(HEIGHT, 2); // SQUARES HEIGHT(HEIGHT*HEIGHT)
                            double BMI = MASS / HEIGHT2; //Divides MASS By Square of HEIGHT(HEIGHT2) 
                            double BMI_round = Math.Round(BMI, 2); //Rounds BMI to 2 Decimal Places
                            Console.WriteLine("Your BMI Is " + BMI_round);
                            if (BMI_round < 18.5)
                            {
                                Console.WriteLine("You are Under-Weight");
                            }
                            else if (BMI_round > 18.5 && BMI_round < 24.9)
                            {
                                Console.WriteLine("You are Healthy :)");
                            }
                            else if (BMI_round > 25 && BMI_round < 29.9)
                            {
                                Console.WriteLine("You are Over-Weight");
                            }
                            else
                            {
                                Console.WriteLine("You are Obese!!");
                            }
                        } else
                        {
                            Console.WriteLine("Invalid Input, Please Input the Correct Values");
                        }
                        
                    } else
                    {
                        Console.WriteLine("Invalid Input, Please Input The Correct Values");
                    }
                }
                    
                else if (CHOICE == 2)
                {
                    Console.Write("What Is Your Weight(Lbs)? : ");
                    string Mass = Console.ReadLine();
                    if (double.TryParse(Mass, out double MASS))
                    {
                        Console.Write("What is Height(Inches)? : ");
                        string Height = Console.ReadLine();
                        if (double.TryParse(Height, out double HEIGHT))
                        {
                            double HEIGHT2 = Math.Pow(HEIGHT, 2); // SQUARES HEIGHT(HEIGHT*HEIGHT)
                            double BMI = (MASS / HEIGHT2) * 703; //Divides MASS By Square of HEIGHT(HEIGHT2) 
                            double BMI_round = Math.Round(BMI, 2); //Rounds BMI to 2 Decimal Places
                            Console.WriteLine("Your BMI Is " + BMI_round);
                            if (BMI_round < 18.5)
                            {
                                Console.WriteLine("You are Under-Weight");
                            }
                            else if (BMI_round > 18.5 && BMI_round < 24.9)
                            {
                                Console.WriteLine("You are Healthy :)");
                            }
                            else if (BMI_round > 25 && BMI_round < 29.9)
                            {
                                Console.WriteLine("You are Over-Weight");
                            }
                            else
                            {
                                Console.WriteLine("You are Obese!!");
                            }
                        }
                        
                    } else
                    {
                        Console.WriteLine("Invalid Input, Please Input the Correct Values");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Please Pick a Real Option " + CHOICE + " is not an Option");
                }
            }
            else
            {
                 Console.WriteLine("Invalid Input, Please Enter the Correct Values");
            }



        }
    }
}
