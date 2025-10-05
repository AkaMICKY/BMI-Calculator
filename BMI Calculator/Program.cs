using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gender_gen = true;
            bool main_code = true;
            string Gender_Human = "";
            Console.WriteLine("Welcome to BMI-Calculator");
            Console.WriteLine("To Continue I need A bit of Information So lets Begin");
            Console.Write("Whats Your Name?: ");
            String Name;
            Name = Console.ReadLine();
            while (Name == "")
            {
                Console.Write("Please Input A Name: ");
                Name = Console.ReadLine(); 
            }
            while (gender_gen)
            {
                Console.WriteLine("Hello " + Name + ", Nice to meet You");
                Console.Write("What is Your Gender " + Name + "(Male/Female): ");
                string Gender = Console.ReadLine();
                if (Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("So In Context your Name is " + Name + " and You are a Male");
                    gender_gen = false;
                    Gender_Human = "Male";
                    
                }
                else if (Gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("So In Context your Name is " + Name + " and You are a Female");
                    gender_gen = false;
                    Gender_Human = "Female";
                }
                else
                {
                    Console.WriteLine(Gender + " is Not an an Available Gender Option");
                    bool x_gender = Error_Loop();
                    if (x_gender)
                    {
                        gender_gen = true;
                    }
                    else
                    {
                        gender_gen = false;
                        main_code = false;
                    }
                }
            }
            while (main_code)
            {
                Console.WriteLine("Choose an Option to Calculate Your BMI");
                Console.WriteLine("1. Weight in Kilograms(KG) and Height in Meters(M)");
                Console.WriteLine("2. Weight in Pounds(Lbs) and Height in Inches(In)");
                Console.WriteLine("3. Weight in Stones(ST) and Height in Centimeters(CM)");
                Console.Write("--Option: ");
                string choice = Console.ReadLine();
                if (int.TryParse(choice, out int CHOICE))
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
                                        bool ERROR_4 = Error_Loop();
                                        if (ERROR_4)
                                        {
                                            main_code = true;
                                        }
                                        else
                                        {
                                            main_code = false;
                                        }
                                    }
                                    else
                                    {
                                        double HEIGHT2_KGM = Math.Pow(HEIGHT_KGM, 2); // SQUARES HEIGHT(HEIGHT*HEIGHT)
                                        double BMI_KGM = MASS_KGM / HEIGHT2_KGM; //Divides MASS By Square of HEIGHT(HEIGHT2) 
                                        double BMI_round = Math.Round(BMI_KGM, 2); //Rounds BMI to 2 Decimal Places
                                        Console.WriteLine("Your BMI Is " + BMI_round);
                                        PrintBMIClass(BMI_KGM, Gender_Human);
                                        BodyFat_percent(BMI_KGM, Gender_Human);
                                        main_code = false;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input, Please Input the Correct Values");
                                    bool ERROR_4 = Error_Loop();
                                    if (ERROR_4)
                                    {
                                        main_code = true;
                                    }
                                    else
                                    {
                                        main_code = false;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                bool ERROR_4 = Error_Loop();
                                if (ERROR_4)
                                {
                                    main_code = true;
                                }
                                else
                                {
                                    main_code = false;
                                }
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
                                        bool ERROR_3 = Error_Loop();
                                        if (ERROR_3)
                                        {
                                            main_code = true;
                                        }
                                        else
                                        {
                                            main_code = false;
                                        }
                                    }
                                    else
                                    {
                                        double HEIGHT2_LBSINCH = Math.Pow(HEIGHT_LBSINCH, 2); // SQUARES HEIGHT(HEIGHT*HEIGHT)
                                        double BMI_LBSINCH = (MASS_LBSINCH / HEIGHT2_LBSINCH) * 703; //Divides MASS By Square of HEIGHT(HEIGHT2) 
                                        double BMI_round = Math.Round(BMI_LBSINCH, 2); //Rounds BMI to 2 Decimal Places
                                        Console.WriteLine("Your BMI Is " + BMI_round);
                                        PrintBMIClass(BMI_LBSINCH, Gender_Human);
                                        BodyFat_percent(BMI_LBSINCH, Gender_Human);
                                        main_code = false;
                                    }


                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input");
                                    bool ERROR_3 = Error_Loop();
                                    if (ERROR_3)
                                    {
                                        main_code = true;
                                    }
                                    else
                                    {
                                        main_code = false;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("Invalid Input ");
                                bool ERROR_3 = Error_Loop();
                                if (ERROR_3)
                                {
                                    main_code = true;
                                }
                                else
                                {
                                    main_code = false;
                                }
                            }
                            break;
                        case 3:
                            Console.Write("What Is Your Weight(Stones)? : ");
                            string Mass_stcm = Console.ReadLine();
                            if (double.TryParse(Mass_stcm, out double MASS_STCM))
                            {
                                Console.Write("What is Height(Centimeters)? : ");
                                string Height_stcm = Console.ReadLine();
                                if (double.TryParse(Height_stcm, out double HEIGHT_STCM))
                                {
                                    if (MASS_STCM <= 0 || HEIGHT_STCM <= 0)
                                    {
                                        Console.WriteLine("Invalid Input(s), Values Must Be Positive and Non-Zero");
                                        bool ERROR_2 = Error_Loop();
                                        if (ERROR_2)
                                        {
                                            main_code = true;
                                        }
                                        else
                                        {
                                            main_code = false;
                                        }
                                    }
                                    else
                                    {
                                        double MASS_STCM_1 = MASS_STCM * 6.35029;
                                        double HEIGHT_STCM_1 = HEIGHT_STCM * 0.01;
                                        double HEIGHT2_STCM = Math.Pow(HEIGHT_STCM_1, 2); // SQUARES HEIGHT(HEIGHT*HEIGHT)
                                        double BMI_STCM = (MASS_STCM_1 / HEIGHT2_STCM) ; //Divides MASS By Square of HEIGHT(HEIGHT2) 
                                        double BMI_round = Math.Round(BMI_STCM, 2); //Rounds BMI to 2 Decimal Places
                                        Console.WriteLine("Your BMI Is " + BMI_round);
                                        PrintBMIClass(BMI_STCM, Gender_Human);
                                        BodyFat_percent(BMI_STCM, Gender_Human);
                                        main_code = false;
                                    }


                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input");
                                    bool ERROR_2 = Error_Loop();
                                    if (ERROR_2)
                                    {
                                        main_code = true;
                                    }
                                    else
                                    {
                                        main_code = false;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                bool ERROR_2 = Error_Loop();
                                if (ERROR_2)
                                {
                                    main_code = true;
                                }
                                else
                                {
                                    main_code = false;
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Please Pick a Real Option, " + CHOICE + " is not an Option");
                            bool ERROR_1 = Error_Loop();
                            if (ERROR_1)
                            {
                                main_code = true;
                            }
                            else
                            {
                                main_code = false;
                            }
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Input, please enter a real Option (1,2 or 3).");
                    bool ERROR_1 = Error_Loop();
                    if (ERROR_1)
                    {
                        main_code = true;
                    }
                    else
                    {
                        main_code = false;
                    }
                }
                Console.WriteLine("Hope You Enjoyed The Experience");
                bool Retry = Error_Loop();
                if (Retry)
                {
                    main_code = true;
                }
                else
                {
                    main_code = false;


                }


            }
                
            

            
        }

        static void PrintBMIClass (double bmi, string Gender)
        {
            if (bmi <= 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Therefore, You are Under-Weight\nMajor Risks!!\n1.Weakened Immune System\n2.Dereased Bone and Muscle Mass(Osteoporosis)\nRecommendation: Consult a HealthCare Professional");
                Console.ResetColor();
                Console.WriteLine("The Healthy range for " + Gender + " is 18.5-24.9 ");
            }
            else if (bmi <= 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Therefore, You are Healthy\nBenefits: \n 1.Lowered Risk Of Diseses\n2.Increased Energy and Physical Capacity\nKeep it up with Balanced Diet and Exercise,You are doing Great!!!");
                Console.ResetColor();
            }
            else if (bmi <= 30)
            {
                Console.ForegroundColor= ConsoleColor.  Yellow;
                Console.WriteLine("Therefore, You are Over-Weight\nMajor Risks!!\n1.Type 2 Diabetes\n2.Certain Cancers such as breast,Colon and Kidney\nRecommendtaion: Life-Style Changes\n1.Exercise\n2.Focus On Healthy Foods");
                Console.ResetColor();
                Console.WriteLine("The Healthy range for " + Gender + " is 18.5-24.9 ");
            }
            else if (bmi >= 31)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Therefore, You are Obese!!\nMajor Risks!!\n1.Heart Disease and Stroke\n2.Type 2 Diabetes\n3.Certain Cancers such as Colon,Kidney,Breast and Pancreatic\n4.Depression and Social Isolation\nRecommendations: Consult a HealthCare Provider and Dietician");
                Console.ResetColor();
                Console.WriteLine("The Healthy range for " + Gender + " is 18.5-24.9 ");
            }
        }

        static bool Error_Loop ()
        {
            while (true)
            {
                Console.Write("Would You Like To Try Again(Yes/No): ");
                string Retry = Console.ReadLine();
                if (Retry.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (Retry.Equals("No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Thank You for Using BMI Calculator, Good bye ");
                    return false;
                }
                else
                {
                    Console.WriteLine("Thats Not an Option");
                }
            }
        }

        static void BodyFat_percent (double BMI, string Gender)
        {
            bool BFP_Loop = true;
            double BMI_R = Math.Round(BMI, 2);
            string BFP = "";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("But Wait Would You Like to Calculate Your Body Fat%");
            Console.WriteLine("What is Your Body Fat %? You may ask, Well it measures what Fraction of Your Body Mass is Fat vs Muscle,Bone,Water,Organs,etc");
            Console.WriteLine("Why Calculate Your Body Fat%?\n1.Unlike BMI Which is just a quick ratio of your weight to your height and can classify you into obese,overweight,....,etc which is Good in Population studies");
            Console.WriteLine("Body Fat% shows true risk,Tracks Fitness Progress Better,Helps set Athletic and Aesthetic Goals, Helps with Nutrition Planning and so on ");
            while (BFP_Loop)
            {
               
                Console.Write("So would You Like to calculate your Body Fat%(Yes/No): ");
                BFP = Console.ReadLine();
                Console.ResetColor();
                if (BFP.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {

                    BFP_Loop = false;
                    bool Age_Loop = true;
                    string Age = "";
                    while (Age_Loop)
                    {
                        Console.Write("To Calculate your Body Fat% I need\n1.Your Gender, and I believe You are " + Gender + "\n2.Your BMI, which was calculated as " + BMI_R + "\n3.Your Age\nAll is checked except Your Age\nSo How Old are You?: ");
                        Age = Console.ReadLine();
                        if (int.TryParse(Age, out int AGE))
                        {
                            Age_Loop = false;
                            if (AGE < 116)
                            {
                                if (Gender == "Male")
                                {
                                    double BFP_Value = (1.20 * BMI_R) + (0.23 * AGE) - 16.2;
                                    double BFP_1 = Math.Round(BFP_Value, 2);
                                    Console.WriteLine("Therefore Your Body Fat % is " + BFP_1 + "% and Your BMI is " + BMI_R);
                                    if (BFP_1 >= 2 && BFP_1 <= 5.99)
                                    {
                                        Console.WriteLine("Danger Zone This is Your minimum necessary Fat for Body Function below this is Health Problems");
                                    }
                                    else if (BFP_1 >= 6 && BFP_1 <= 13.99)
                                    {
                                        Console.WriteLine("You are Lean and Muscular");
                                    }
                                    else if (BFP_1 >= 14 && BFP_1 <= 17.99)
                                    {
                                        Console.WriteLine("You are Healthy and Athletic");
                                    }
                                    else if (BFP_1 >= 18 && BFP_1 <= 24.99)
                                    {
                                        Console.WriteLine("You are in the Common Healthy Range for general Population");
                                    }
                                    else if (BFP_1 >= 25)
                                    {
                                        Console.WriteLine("High Risk of Health Issues");
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Risks of High BFP(Body Fat Percentage)\nIncreased risk of \n1.Type 2 Diabetes\n2.Heart Disease\n3.Hypertension\n4.Certain Cancers, and More");
                                    Console.WriteLine("Risks of Low BFP/Essential Fat Deficiency\nFor Men: Reduced Hormone Production and low Energy And Overall Weak Immune System and Low Bone Mass");
                                    Console.ResetColor();
                                    Console.WriteLine("For more info Visit Medical News Today, Heathline or Verywell Health.com ");
                                }
                                else if (Gender == "Female")
                                {
                                    double BFP_Value = (1.20 * BMI_R) + (0.23 * AGE) - 5.4;
                                    double BFP_1 = Math.Round(BFP_Value, 2);
                                    Console.WriteLine("Therefore Your Body Fat % is " + BFP_1 + "% and Your BMI is " + BMI_R);
                                    if (BFP_1 >= 9 && BFP_1 <= 11.99)
                                    {
                                        Console.WriteLine("Danger Zone This is Your minimum necessary Fat for Body Function below this is Health Problems");
                                    }
                                    else if (BFP_1 >= 12 && BFP_1 <= 19.99)
                                    {
                                        Console.WriteLine("You are Lean and Muscular");
                                    }
                                    else if (BFP_1 >= 20 && BFP_1 <= 24.99)
                                    {
                                        Console.WriteLine("You are Healthy and Athletic");
                                    }
                                    else if (BFP_1 >= 25 && BFP_1 <= 29.99)
                                    {
                                        Console.WriteLine("You are in the Common Healthy Range for general Population");
                                    }
                                    else if (BFP_1 >= 30)
                                    {
                                        Console.WriteLine("High Risk of Health Issues");
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Risks of High BFP(Body Fat Percentage)\nIncreased risk of \n1.Type 2 Diabetes\n2.Heart Disease\n3.Hypertension\n4.Certain Cancers, and More");
                                    Console.WriteLine("Risks of Low BFP/Essential Fat Deficiency\nFor Women: Menstrual Irregularities and Fertility Issues\nAnd Overall Weak Immune System and Low Bone Mass");
                                    Console.ResetColor();
                                    Console.WriteLine("For more info Visit Medical News Today, Heathline or Verywell Health.com ");
                                }
                            }
                            else if (AGE >= 116)
                            {
                                Console.WriteLine("I dont think thats Possible Unless You are Older than the oldest Man in the World-Ethel Caterham Who is 116 as of August 2025");
                                bool Retry_300 = Error_Loop();
                                if (Retry_300 == true)
                                {
                                    Age_Loop = true;
                                }
                                else if (Retry_300 == false)
                                {
                                    Console.WriteLine("Well Thank Your for Using BMI Calculator, Goodbye and Have a Good Day");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("That is Not A real number");
                            bool Retry_200 = Error_Loop();
                            if (Retry_200 == true)
                            {
                                Age_Loop = true;
                            }
                            else if (Retry_200 == false)
                            {
                                Console.WriteLine("Well Thank Your for Using BMI Calculator, Goodbye and Have a Good Day");
                            }

                        }
                    }

                   
                }
                else if (BFP.Equals("No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Well Thank Your for Using BMI Calculator, Goodbye and Have a Good Day");
                    BFP_Loop = false;
                }
                else
                {
                    bool Retry_100 = Error_Loop();
                    if (Retry_100 == true)
                    {
                        BFP_Loop = true;
                    }
                    else if (Retry_100 == false)
                    {
                        Console.WriteLine("Well Thank Your for Using BMI Calculator, Goodbye and Have a Good Day");
                        BFP_Loop = false;
                    }
                }
            }
            
        }  
        
    }
}
