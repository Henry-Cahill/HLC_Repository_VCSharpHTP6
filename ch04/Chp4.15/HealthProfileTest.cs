// See https://aka.ms/new-console-template for more information

//4.15 (Computerization of Health Records)
/*A health-care issue that has been in the news lately is the computerization of health records.
 * This possibility is being approached  cautiously because of sensitive privacy and security concerns, among others. [We adress such concerns in later exercises.]  Computerizing health records could make it easier for patients to share their health profiles and histories among their various health-care professionals.
 * This could improve the quality of health care, help avoid drug conflicts and erroneous drug prescriptions, reduce costs and, in emergencies, could save lives. In this exercise, you'll design a "starter" HealthProfile class for a person. 
 * The class attributes should incllude the person's first name, last name, gender, date of birth, (consisting of separate attributes for the month, day and year of birth), height (in inches) and weight (in pounds). 
 * Your class should have a constructor that receives this data. For each attribute provide a property with set and get accessors. The class also should include methods that 
 * calculate and return the user's age in years, maximum heart rate and target-heart-rate range (see Exercise 4.14), and body mass index (BMI; see Exercise 3.31). Write an app that prompts for the person's information, instantiates an object of class HealthProfile for that person and displays the information from that object-including the person's first name, last name, gender, date of birth, height and weight-then calculates and displays the //person's age in years, BMI, maximum heart rate and target-heart-rate range. It should also display the "BMI values" chart from Exercise 3.31.
*/

using System;

class HealthProfileTest
{
   static void DisplayHealthInformation(HealthProfile personToDisplay)
   {
      //Asking the user to enter the First name of Human#
      Console.Write($"Please enter a person's First name: ");
      personToDisplay.first_Name       = Console.ReadLine();

      //Asking the user to enter the Last name of Human#
      Console.Write($"Now enter a {personToDisplay.perFirst_Name}'s Last name: ");
      personToDisplay.last_Name        = Console.ReadLine();

      //Prompt for the input of Month of Birth.
      Console.Write($"Enter the month {personToDisplay.perFirst_Name}'s born: ");
      personToDisplay.month            = int.Parse(Console.ReadLine());

      //Prompt for the input of Day Born.
      Console.Write($"Please enter the day {personToDisplay.perFirst_Name}'s born: ");
      personToDisplay.day              = int.Parse(Console.ReadLine());

      //Prompt for the input of Year of Birth.
      Console.Write($"What is the year {personToDisplay.perFirst_Name}'s born: ");
      personToDisplay.year             = int.Parse(Console.ReadLine());

      //Asking the user to enter the Current Year
      Console.Write($"Enter the current year: ");
      personToDisplay.currentYear      = int.Parse(Console.ReadLine());

      //Asking the user to their gender
      Console.Write($"{personToDisplay.perFirst_Name} can you please enter the gender you identify as: ");
      personToDisplay.gender           = Console.ReadLine();

      //Asking the user to enter their height in inches
      Console.Write($"{personToDisplay.perFirst_Name} enter your height in inches: ");
      personToDisplay.heightInInches   = int.Parse(Console.ReadLine());

      //Asking the user to enter their weight in pounds
      Console.Write($"{personToDisplay.perFirst_Name} enter you weight please in pounds: ");
      personToDisplay.weightInPounds   = int.Parse(Console.ReadLine());

      //Calculates the persons age
      personToDisplay.CalcAge();
      //Calculates the persons Heart Rates
      personToDisplay.CalcHeartRates();
      //Calculating the persons BMI
      personToDisplay.CalcBMI();

      /*Example of the text output from the Console Write::
      *Dislpay the BMI Chart
      *
      *The First and Last name of Human#.
      *The Current year.
      *Human#'s age is #.
      *
      *Human# First_Name Maximum Heart Rate:
      *last name BMI is #
      *Their Minimum range for Heart Rate:
      *Human#'s birth Month/Day/Year.
      */

      Console.Write("\nBMI VALUES" +
                    "\nUnderweight:  less than 18.5" +
                    "\nNormal:       between   18.5 and 24.9" +
                    "\nOverweight:   between   25 and 29.9" + 
                    "\nObese:        30 or greater\n" +
                   $"\n{personToDisplay.perFirst_Name} {personToDisplay.perLast_Name}." +
                   $"\nThe Current year: {personToDisplay.perCurrentYear}." +
                   $"\n{personToDisplay.perFirst_Name}'s Age is {personToDisplay.perAge} and a {personToDisplay.perGender}." +
                   $"\n\n{personToDisplay.perFirst_Name}'s Maximum Heart Rate: {personToDisplay.perMaxHeartRate}." +
                   $"\n{personToDisplay.perLast_Name}'s Body Mass Index is {personToDisplay.perBMI}." +
                   $"\nTheir Minimum approximate Heart Rate: {personToDisplay.perMinHighHeartRate} ~ {personToDisplay.perMinLowHeartRate}.\n");
      Console.Write(value: $"{personToDisplay.perFirst_Name}'s birth year: ");
      personToDisplay.DisplayDate();
   }
   // Main Method begins execution of C# application.
   static void Main()
   {
      HealthProfile human1 = new HealthProfile("", "", 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
      DisplayHealthInformation(human1);
      
   } //End of the Main Method
} //End of the class HealthProfileTest
