// See https://aka.ms/new-console-template for more information
// Self Review Assignment 3.5 A-J: Prompt.cs
// Write declarations, statements or comments that accomplish each of the followning tasks:
// a) State that an app will calculate the product of three integers
// b) Declare the variables x, y, z and result to be of type int.
// c) Prompt the user to enter the first integer.
// d) Read the first integer from the user and store it in the variable x.
// e) Prompt the user to enter the second integer.
// f) Read the second integer from the user and store it in the variable y.
// g) Prompt the user to enter the third integer.
// h) Read the third integer from the user and store it in the variable z.
// i) Compute the product of the three integers contained in variables x, y, and z, and assign the result to the variable result.
// j) Display the message "Product is", followed by the value of the variable result - use string interpolation.
using System;

namespace Prompt8
{
   class Prompt8
   {
      //Main method begins execution of C# application
      static void Main()
      {
         

         //Prompt user and read first number
         Console.Write("Enter first intiger: ");
         int x = int.Parse(Console.ReadLine());

         //Prompt user and read second number
         Console.Write("Enter second intiger: ");
         int y = int.Parse(Console.ReadLine());

         //Prompt user and read third number
         Console.Write("Enter third intiger: ");
         int z = int.Parse(Console.ReadLine());

         int result = x*y*z;
         Console.WriteLine($"Product is {result}");
      }//end Main
   }//end class Prompt8
}