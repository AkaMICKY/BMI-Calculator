# 🏋️ BMI Calculator

A C# console application that calculates a person’s Body Mass Index (BMI) based on their age, weight (in kilograms), and height (in meters). The program rounds the BMI to two decimal places and provides a simple health interpretation (underweight, normal, overweight, obese). This project helps practice floating-point arithmetic, conditionals, and user input handling.

⚡ Installation  
Clone the repository with:  
git clone https://github.com/AkaMicky/BMICalculator.git  
cd BMICalculator  
Open the project in Visual Studio (or any C# IDE) and run the program.

🎯 Usage  
When prompted, enter your age, weight in kilograms, and height in meters. The program calculates your BMI and outputs the value along with a health category.  
Example:  
Enter your age: 20  
Enter your weight (kg): 70  
Enter your height (m): 1.75  
Your BMI is 22.86 – Normal weight

🔮 Future Improvements  
- Add TryParse to handle invalid input and prevent crashes.  
- Allow height input in centimeters or feet/inches.  
- Provide age-adjusted health recommendations.  
- Optional: graphical or color-coded output of BMI category.  
- Enable multiple input formats so the user doesn’t have to manually convert weight to kg or height to meters.  
- Display the user’s BMI category directly instead of requiring them to trace a graph manually.

🛠️ Technologies Used  
C#, .NET Console Application

📚 What I Learned  
- Using `Math.Pow()` and floating-point arithmetic in C#  
- Accepting multiple user inputs via `Console.ReadLine()`  
- Rounding numbers with `Math.Round()`  
