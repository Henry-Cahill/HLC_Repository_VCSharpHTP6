// See https://aka.ms/new-console-template for more information

//Figure 5.13: Analysis.cs
//Analysis of examination results, using nested control statements.
using System;

class Analysis
{
   static void Main()
   {
      //Initialization phase
      //initialize variables in declarations
      int passes = 0; //number of passes
      int failures = 0; //number of failures
      int studentCounter = 1; //student counter

      //Processing phase
      //process 10 students using counter-controlled iteration
      while(studentCounter <= 10)
      {
         //prompt user for input and obtain a value from the user
         Console.Write("Enter result (1 = pass, 2 = fail): ");
         int result = int.Parse(Console.ReadLine());

         //if ...else is nested in the while statement
         if(result == 1)
         {
            passes = passes + 1; //increment passes
         }
 
         else
         {
            failures = failures + 1; //increment failures
         }
         //increment studentCounter so loop eventually terminates
         studentCounter = studentCounter + 1;
      }
      //Termination phase; prepare and display results
      Console.WriteLine($"Passed: {passes:N}\nFailed: {failures:N}");
      //determines whether more than 8 students passed
      if (passes > 8)
      {
         Console.WriteLine("Bonus to instructor!");
      }
   } //End of the Main Method
} //End the class Analysis
