// See https://aka.ms/new-console-template for more information
// Self Review Assignment 3.4A&B: Prompt.cs
//  Identify and correct the errors in eac of the following statements:
using System;

namespace Prompt7
{
   class Prompt7
   {
      //Main method begins execution of C# application
      static void Main()
      {
         //Prompt user and read first number
         Console.Write("Enter first intiger: ");
         int c = int.Parse(Console.ReadLine());

         if (c < 7)
         {
            Console.WriteLine("c is less than 7");
         }
         if (c >= 7)
         {
            Console.WriteLine("c is greater than or equal to 7");
         }
      }//end Main
   }//end class Prompt7
}