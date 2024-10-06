// See https://aka.ms/new-console-template for more information

/*
 * Combine the statements that you wrote in Exercise 5.5 into a C# app that calculates and displays
 * the sum of the integers from 1 to 10. Use a while statement to loop through the calculation and increment statements. The loop should terminate when the value of x becomes 11.
 */

//Ex. 5.6: Calculate.cs
//Calculate the sum of the integers from 1 to 10
using System;

class Calculate
{
   static void Main()
   {
      int sum = 0; // initialize sum to 0 for totaling
      int x = 1; // initialize x to 1 for counting

      while (x <=10)
      {
         sum += x; // add x to sum
         ++x; // increment x
      } // end while

      Console.WriteLine($"The sum is: {sum:N}");
   } // End of the Main Method
} //End the class Calculate
