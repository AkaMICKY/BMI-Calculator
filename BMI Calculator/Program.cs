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
            Console.Write("--Option: ");
            string choice = Console.ReadLine(  );
            if (int.TryParse(choice, out int CHOICE) )
            {
                switch (CHOICE)
                {
                    case 1:
                        Console.Write("What Is Your Weight(Kg)? : ");
                        string Mass_kgm = Console.ReadLine();
                        if (double.TryParse(Mass_kgm, out double MASS_KGM))
                        {
                            Console.Write("What is Height(Meters)? : ");
                            string Height_kgm = Console.ReadLine();
                            if (double.TryParse(Height_kgm, out double HEIGHT_KGM))
                            {
                                if (MASS_KGM <= 0 || HEIGHT_KGM <= 0)
                                {
                                    Console.WriteLine("Invalid Input(s), Value(s) must be Positive and Non-Zero");
                                } else
                                {
                                    double HEIGHT2_KGM = Math.Pow(HEIGHT_KGM, 2); // SQUARES HEIGHT(HEIGHT*HEIGHT)
                                    double BMI_KGM = MASS_KGM / HEIGHT2_KGM; //Divides MASS By Square of HEIGHT(HEIGHT2) 
                                    double BMI_round = Math.Round(BMI_KGM, 2); //Rounds BMI to 2 Decimal Places
                                    Console.WriteLine("Your BMI Is " + BMI_round);
                                    PrintBMIClass(BMI_KGM);
                                }

                            } else
                            {
                                Console.WriteLine("Invalid Input, Please Input the Correct Values");
                            }

                        } else
                        {
                            Console.WriteLine("Invalid Input, Please Input The Correct Values");
                        }
                        break;
                    case 2:
                        Console.Write("What Is Your Weight(Lbs)? : ");
                        string Mass_lbsinch = Console.ReadLine();
                        if (double.TryParse(Mass_lbsinch, out double MASS_LBSINCH))
                        {
                            Console.Write("What is Height(Inches)? : ");
                            string Height_lbsinch = Console.ReadLine();
                            if (double.TryParse(Height_lbsinch, out double HEIGHT_LBSINCH))
                            {
                                if (MASS_LBSINCH <= 0 || HEIGHT_LBSINCH <= 0)
                                {
                                    Console.WriteLine("Invalid Input(s), Values Must Be Positive and Non-Zero");
                                }
                                else
                                {
                                    double HEIGHT2_LBSINCH = Math.Pow(HEIGHT_LBSINCH, 2); // SQUARES HEIGHT(HEIGHT*HEIGHT)
                                    double BMI_LBSINCH = (MASS_LBSINCH / HEIGHT2_LBSINCH) * 703; //Divides MASS By Square of HEIGHT(HEIGHT2) 
                                    double BMI_round = Math.Round(BMI_LBSINCH, 2); //Rounds BMI to 2 Decimal Places
                                    Console.WriteLine("Your BMI Is " + BMI_round);
                                    PrintBMIClass(BMI_LBSINCH);
                                }


                            }
                            else
                            {
                                Console.WriteLine("Invalid Input, Please Input the Correct Values");
                            }

                        }
                        break;
                    default:
                      Console.WriteLine("Please Pick a Real Option, " + CHOICE + " is not an Option");
                    break;
                } 
               
            }
            else
            {
                 Console.WriteLine("Invalid Input, please enter a real Option (1 or 2).");
            }

            Console.WriteLine("Press any key + Enter to exit...");
            Console.ReadLine();
        }

        static void PrintBMIClass (double bmi)
        {
            if (bmi <= 18.5)
            {
                Console.WriteLine("Therefore, You are Under-Weight");
            }
            else if (bmi <= 25)
            {
                Console.WriteLine("Therefore, You are Healthy :)");
            }
            else if (bmi <= 30)
            {
                Console.WriteLine("Therefore, You are Over-Weight");
            }
            else
            {
                Console.WriteLine("Therefore, You are Obese!!");
            }
        }
    }
}
