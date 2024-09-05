// See https://aka.ms/new-console-template for more information

/*
 *4.14 Exercise
 *(Target-Heart-Rate Calculator)
 *While exercising, you can use a heart-rate monitor to see that your heart rate stays within a safe range suggested by your trainers and doctors. 
 *According to the American Heart Association (AHA) (http://bit.lyAHATargetHeartRates), the formula for calculating your maximum heart rate in beats per minute is 220 minus your age in years.
 *Your target heart rate is a range that is 50-85% of your maximum heart rate.
 *[Note: These formulas are estimates provided by the AHA. Maximum and target heart rates may vary based in the health, fitness and gender of the individual. Always consult a physician or qualified health care professional before beginning or modifying an exercise program.] 
 *Create a class called HeartRates. 
 *The class attributes should include the person's first name, last name, year of birth and the current year.
 *Your class should have a constructor that receives this data as parameters. 
 *For each attribute provide a property with set and get accessors.
 *The class also should include a property that calculates and returns the person's age (in years),
 *a property that calculate and return the person's maximum heart rate
 *and properties that calculate and returns person's minimum and maximum target heartrates.
 *
 *Write an application that prompts for the person's information, instantiates an object of class HeartRates and displays the information from that object-including the person's first name, last name and year of birth-then calculates and displays the person's age in years, maximum heart rate and target-heart-rate range.
 *
*/ 

using System;

class HeartRatesTest
{
   static void DisplayHeartInformation(HeartRates personToDisplay)
   {
      //Asking the user to enter the First name of Human#
      Console.WriteLine($"Please enter a person's First Name:");
      personToDisplay.first_Name = Console.ReadLine();

      //Asking the user to enter the Last name of Human#
      Console.WriteLine($"\nNow enter a {personToDisplay.perFirst_Name}'s Last Name: ");
      personToDisplay.last_Name = Console.ReadLine();

      //Asking the user to enter the Year of Birth for Human#
      Console.WriteLine($"\nEnter {personToDisplay.perFirst_Name}'s Year of Birth: ");
      personToDisplay.yearOfBirth = int.Parse(Console.ReadLine());

      //Asking the user to enter the Current Year
      Console.WriteLine($"\nEnter the Current Year: ");
      personToDisplay.currentYear = int.Parse(Console.ReadLine());

      //Calculates the persons age
      personToDisplay.CalcAge();
      //Calculates the persons Heart Rates
      personToDisplay.CalcHeartRates();
      
      //Example of the text output from the Console Write
      //Caught these values
      //The First and Last name of Human#.
      //The Current year.
      //Human#'s Birth year.
      //Human#'s age is #.

      //Human# First_Name Maximum Heart Rate:
      //Their Minimum at the most Heart Rate:
      //Finally the Minimum at least Heart Rate:
      Console.Write($"{personToDisplay.perFirst_Name} {personToDisplay.perLast_Name}.\nThe Current year: {personToDisplay.perCurrentYear}.\n{personToDisplay.perFirst_Name}'s birth year: {personToDisplay.perYearOfBirth}.\n{personToDisplay.perFirst_Name}'s Age is {personToDisplay.perAge}\n\n{personToDisplay.perFirst_Name}'s Maximum Heart Rate: {personToDisplay.perMaxHeartRate}.\nTheir Minimum at the most Heart Rate: {personToDisplay.perMinHighHeartRate}.\nFinally the Minimum at least Heart Rate: {personToDisplay.perMinLowHeartRate}.");
   }
   // Main Method begins execution of C# application.
   static void Main()
   {
      HeartRates human1 = new HeartRates("","",0,0,0,0,0,0);
      HeartRates human2 = new HeartRates("","",0,0,0,0,0,0);
      //Displaying the promps to capture human1's: First_Name, Last_Name, Birth Year, Current Year
      DisplayHeartInformation(human1);
      Console.Write("\n\n");
      //Displaying the promps to capture human1's: First_Name, Last_Name, Birth Year, Current Year
      DisplayHeartInformation(human2);
   }// End of the Main Method
}//End of HeartRateTest