// See https://aka.ms/new-console-template for more information

// Self Review Assignment 3.8 A-C: Prompt.cs
// Write C# statements that accomplish each of the following tasks:
//a) Display the message  "Enter an integer: "' leaving the cursor on th esame line.
//b) Assign  the product of variables b and c to variable a.
//c) State that an app performs a simple payroll calculation (i.e., use text that helps to document an app).

using System;

namespace Prompt10
{
   class Prompt10
   {
      //Main method begins execution of C# application
      static void Main()
      {


         //Prompt user and read first number
         Console.Write("Enter an intiger: ");
         int b = int.Parse(Console.ReadLine());

         //Prompt user and read second number
         Console.Write("Of the number of customers: ");
         int c = int.Parse(Console.ReadLine());

         int a = b * c;
         Console.WriteLine($"Product {a} is the total pay you can get if on average the you recieve ${b}");
      }//end Main
   }//end class Prompt10
}