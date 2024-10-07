// See https://aka.ms/new-console-template for more information
/*
 * For Exercises 5.17 - 5.20 perform each of the following steps
 * a) Read the problem statements.
 * b) Formulating the algorithm using pseudocode and top-down, stepwise refinement.
 * c) Write a C# application
 * d) Test, debug and execute the C# application.
 * e) Process three complete sets of data.
 */
/*
 * (Sales-Commission Calculator)
 * A large company pays its salespeople on a commission basis. The salespeople receive $200 per week plus 9% of their gross sales for that week.
 * For example, a salesperson who sells $5,000 worth of merchandise in a week receives $200 plus 9% of $5,000, or a total of $650. You've been 
 * supplied with a list of the items sold by each salesperson. The values of these items are as follows
 * Item  Value
 * 1     239.99
 * 2     129.75
 * 3      99.95
 * 4     350.89
 * 
 * Develop a C# application that inputs one salesperson's items sold for last week, then calculates and displays that salesperson's earnings. 
 * There's no limit to the number of items that can be sold by a salesperson.
 */

using System;

public class SalesCommissionCalculationTest
{
   static void DisplayCommission(SalesCommissionCalculation personToDisplay)
   {
      //Asking the user to enter the First Name of Human#
      Console.Write($"Please enter the sales person's First name: ");
      personToDisplay.first_Name = Console.ReadLine();

      //Asking the user to enter the Last name of Human#
      Console.Write($"Now enter {personToDisplay.perFirst_Name}'s Last name: ");
      personToDisplay.last_Name = Console.ReadLine();

      //Asking the user to enter their Sales Account Number
      Console.Write($"Please enter {personToDisplay.perFirst_Name} {personToDisplay.perLast_Name}'s Sales account Number: ");
      personToDisplay.account = int.Parse(Console.ReadLine());

      //Gets humans commission calculation
      personToDisplay.CommissionCalculation();
      Console.Write("\n");
   }
   //Main Method begins execution of C# Application
   static void Main()
   {
      SalesCommissionCalculation SalesPerson1 = new SalesCommissionCalculation("", "", 0, 0, 0, 0, 0);
      SalesCommissionCalculation SalesPerson2 = new SalesCommissionCalculation("", "", 0, 0, 0, 0, 0);
      SalesCommissionCalculation SalesPerson3 = new SalesCommissionCalculation("", "", 0, 0, 0, 0, 0);

      DisplayCommission(SalesPerson1);
      DisplayCommission(SalesPerson2);
      DisplayCommission(SalesPerson3);

   } //End of the Main Method
} //End of the class SalesCommissionCalculationTest