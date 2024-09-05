// See https://aka.ms/new-console-template for more information

// Self Review Assignment 3.17
// (Arithmetic, Smallest and Largest)
//Write an application that inputs three integers from the user and displays the sum, average, product, and smallest and largest of the numbers. Use the techniques from Fig. 3.22 [Note: The average calculation in this exersise should result in an integer representation of the average. So, if the sum of the values is 7, the average should be 2 not 2.33333....]

using System;
using System.Numerics;

namespace Prompt17
{
   class Prompt17
   {
      //Main method begins execution of C# application
      static void Main()
      {
         //Prompt user and read first number
         Console.Write("Enter an intiger: ");
         int a = int.Parse(Console.ReadLine());

         //Prompt user and read second number
         Console.Write("Enter an second intiger: ");
         int b = int.Parse(Console.ReadLine());

         //Prompt user and read third number
         Console.Write("Enter an third intiger: ");
         int c = int.Parse(Console.ReadLine());

         int d = a + b + c;
         int e = (a + b + c) / 3;
         int f = a * b * c;

         Console.WriteLine($"{d}");
         Console.WriteLine($"{e}");
         Console.WriteLine($"{f}");

         if (a < b && a < c) Console.WriteLine($"{a} is the smallest number.");
         else if (b < a && b < c) Console.WriteLine($"{b} is the smallest number.");
         else if (c < a && c < b) Console.WriteLine($"{c} is the smallest number.");

         if (a > b && a > c) Console.WriteLine($"{a} is the largest number.");
         else if (b > a && b > c) Console.WriteLine($"{b} is the largest number.");
         else if (c > a && c > b) Console.WriteLine($"{c} is the largest number.");

      }//end Main
   }//end class Prompt17
}