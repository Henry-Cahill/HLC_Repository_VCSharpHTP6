// See https://aka.ms/new-console-template for more information
// Self Review Assignment 3.3G: Prompt.cs
// Write a statement that uses string interpolation to display the sum of the variables x and y. Assume variables x and y of type int exist and already have values.
using System;

namespace Prompt6
{
   class Prompt6
   {
      //Main method begins execution of C# application
      static void Main()
      {
         int x = 8; //declare the "x" variable of value 8
         int y = 15; //declare the "y" variable of value 15
         int sum; // declare sum of "x" and "y"

         sum = x + y; //sum of "x" and "y"

         Console.WriteLine($"Sum is {sum}"); // display sum
      }//end Main
   }//end class Prompt6
}