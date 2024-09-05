// See https://aka.ms/new-console-template for more information

//Figure 3.32
//(Car-Pool Savings Calculator)
//Research several car-pooling websites. Create an app that calculates your daily driving cost, so that you can estimate how much money could be saved by car pooling, which also has other advantages such as reducing carbon emissions and reducing traffic congestion. The app. should input the following information and display the user's cost per day of driving to work:
//A) Total miles driven per day.
//B) Cost per gallon of gasoline (in cents).
//C) Average miles per gallon.
//D) Parking fees per day (in cents).
//e) Tolls per day (in cents).

using System;
using System.Numerics;

class Prompt32
{
   // Main Method begins execution of C# application.
   static void Main()
   {
      // Testing data: 70 miles per day
      Console.WriteLine("The esimated miles per day driven: ");
      int milesPerDay = int.Parse(Console.ReadLine());

      // Testing data: $3.01 for a gallon of unleaded gasoline from caseys general store
      Console.WriteLine("The estimated Cost of Gas: ");
      double gallonOfGasoline = double.Parse(Console.ReadLine());

      // Testing data: 40 miles per gallon for my Toaus Volks Wagon
      Console.WriteLine("Average miles per gallon your primary mod of transportation is: ");
      int milesPerGallon = int.Parse(Console.ReadLine());

      // Testing data: $0 dollars for Tolls "Lives in Kansas"
      Console.WriteLine("Enter any Tolls costs expected for a day: ");
      double tollsPerDay = double.Parse(Console.ReadLine());

      // Testing data: $0 dollars for Parking fees "Lives in Kansas"
      Console.WriteLine("Enter any Parking fees expected on you commute: ");
      double parkingFeesPerDay = double.Parse(Console.ReadLine());


      double costPerDayDriveToWork = ((milesPerDay / milesPerGallon) * gallonOfGasoline) + tollsPerDay + parkingFeesPerDay;
      Console.WriteLine($"The result is ${costPerDayDriveToWork} for a cost per day to drive to work.");

   }//end Main
}//end class Prompt30
