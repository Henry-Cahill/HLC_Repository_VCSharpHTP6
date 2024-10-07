// See https://aka.ms/new-console-template for more information

/*For Exercises 5.20, perform each of the following steps:
* a) Read the problem statement
* b) Formulate the algorithm using pseudocode and top-down, stepwise refinement.
* c) Write a C# application.
* d) Test, debug and execute the C# application
* e) Process three complete sets of data
*/
/*
* 5.20 (Salary Calculator)
* Develop a C# application that will determine the gross pay for each of three employees. The company pays straight time for the first 40 hours worked by each employee and time-and-a-half for all hours worked in excess of 40 hours. You're given a list of the three employees of the company, the number of hours each employee worked last week and the hourly rate of each employee. Your application should input this information for each employee, then should determine and display the employee's gross pay. Use the Console class's ReadLine method to input the data. 
*/

using System;

public class SalaryCalculatorTest
{
   static void DisplayHours(SalaryCalculator personToDisplay)
   {
      Console.Write("--------------------------------------------------------------------------------------------------\n" +
                    "PROCESSING PHASE                                                                                  \n\n" +
                    //Asking the user to  enter First Name of Human#
                    "Please enter the sales person's First name: ");
      personToDisplay.first_Name = Console.ReadLine();
      //Asking the user to enter Last Name of Human#
      Console.Write($"              Now enter {personToDisplay.perFirst_Name}'s Last name: ");
      personToDisplay.last_Name = Console.ReadLine();
      //Asking the user to enter their Human Resource Number
      Console.Write($"Please enter {personToDisplay.perFirst_Name} {personToDisplay.perLast_Name}'s Human Resource Number: ");
      personToDisplay.account = int.Parse(Console.ReadLine());
      Console.Write("\n##################################################################################################\n" +
                    "                                         EXPECTATIONS:                                            \n\n" +
                    "The company pays straight time for the first 40 hours worked by each employee and time-and-a-half,\n" +
                    "for all hours worked in excess of 40 hours.\n" +
                    "##################################################################################################\n");
      //Informing the user to enter a one or a value to continue.
      //Get humans salary Calculator
      personToDisplay.SalaryHourCalculator();
   }
   //Main Method begins execution of C# Application
   static void Main()
   {
      SalaryCalculator HumanResource1 = new SalaryCalculator("", "", 0, 0, 0, 0, 0);
      SalaryCalculator HumanResource2 = new SalaryCalculator("", "", 0, 0, 0, 0, 0);
      SalaryCalculator HumanResource3 = new SalaryCalculator("", "", 0, 0, 0, 0, 0);

      DisplayHours(HumanResource1);
      DisplayHours(HumanResource2);
      DisplayHours(HumanResource3);
      
   } //End of Main Method
} //End of the class SalaryCalculatorTest