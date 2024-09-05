// See https://aka.ms/new-console-template for more information

//Figure 3.31
//(Body Mass Index Calculator)
//We introduced the body mass index (BMI) calculator in Exercise 1.27. The formulas for calculating the BMI are

//BMI = (weightInPounds * 703) / (heightInInches * heightInInches)
//or
//BMI = (weightInKilograms) / (heightInMeters * heightInMeters)

//Create a BMI calculator app that reads the user's weight in pounds and height in inches (or, if you prefer, user's weight in kilograms and height in meters), then calculates and displays the user's body mass index. The app should also display the following information from the Department of Health and Human Services/National Institutes of Health so the user can evaluate his/her BMI:

//BMI VALUES
//Underweight: less than 18.5
//Normal:      between 18.5 and 24.9
//Overweight:  between 25 and 29.9
//Obese:       30 or greater

using System;
using System.Numerics;

class Prompt31
{
   // Main Method begins execution of C# application.
   static void Main()
   {
      //Prompt user and read first number
      Console.Write("Enter the Height in Inches:");
      int heightInInches = int.Parse(Console.ReadLine());

      Console.Write("Enter the weight in Pounds:");
      int weightInPounds = int.Parse(Console.ReadLine());

      Console.WriteLine("BMI VALUES");
      Console.WriteLine("Underweight:  less than 18.5");
      Console.WriteLine("Normal:       between 18.5 and 24.9");
      Console.WriteLine("Overweight:   between 25 and 29.9");
      Console.WriteLine("Obese:        30 or greater");

      double BMI = (weightInPounds * 703) / (heightInInches * heightInInches);
      Console.WriteLine($"Your BMI is {BMI}");

   }//end Main
}//end class Prompt31