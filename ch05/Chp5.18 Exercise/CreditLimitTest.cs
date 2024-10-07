// See https://aka.ms/new-console-template for more information
/*
 * For Exercises 5.18, perform each of the following steps:
 * a) Read the problem statement.
 * b) Formulate the algorithm using pseudocode and top-down, stepwise refinement.
 * c) Write a C# app.
 * d) Test, debug and execute the C# App.
 * e) Process three complete set of data.
 * 
 * 5.18 (Credit-limit calculator)
 * Develop a C# that will determine whether any of several department-store customers has exceeded the credit limit on a charge account.
 * For each customer, the following facts are available:
 * 
 * a) account number,
 * b) balance at the beginning of the month,
 * c) total all of items charged by the customer this month,
 * d) total of all credits applied to the customer's account this month and
 * e) allowed credit limit.
 * 
 * The app. should input all these facts as integers, calculate the new balance (= beginning balance + charges - credits), display the new balance and 
 * determine whether the new balance exceeds the customer's credit limit. For those whose credit limit is exceeded, the app should display the message
 * "Credit limit exceeded". Use sentinel-controlled iteration to obtain the data for each account.
*/
using System;

public class CreditLimitTest
{
    static void DisplayCredit(CreditLimit personToDisplay)
    {
      //Asking the user to enter the First name of Human#
      Console.Write($"Please enter a person's First name: ");
      personToDisplay.first_Name = Console.ReadLine();

      //Asking the user to enter the Last name of Human#
      Console.Write($"Now enter a {personToDisplay.perFirst_Name}'s Last name: ");
      personToDisplay.last_Name = Console.ReadLine();

      //Asking the user to enter their account Number
      Console.Write($"Please enter {personToDisplay.perFirst_Name} {personToDisplay.perLast_Name} account Number: ");
      personToDisplay.account = int.Parse(Console.ReadLine());

      //Gets the users monthly Credits.
      personToDisplay.MonthlyCredits();
    }
   //Main Method begins execution of C# application
    static void Main()
    {
      CreditLimit human1 = new CreditLimit("", "", 0, 10000, 0, 0, 0, 0);
      CreditLimit human2 = new CreditLimit("", "", 0, -10000, 0, 0, 0, 0);
      CreditLimit human3 = new CreditLimit("", "", 0, 0, 0, 0, 0, 0);
      DisplayCredit(human1);
      DisplayCredit(human2);
      DisplayCredit(human3);
    }//End of the Main Method
}//End of the class CreditLimitTest