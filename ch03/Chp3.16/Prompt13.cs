// See https://aka.ms/new-console-template for more information

// Self Review Assignment 3.16
// (Comparing Integers) Write an app that asks the user to enter two integers, obtains them from the user and displays the larger number followed by the words "is larger". If the number s are equal, display the message "These numbers are equal." Use the techniques shown in Figure 3.22.

using System;
using System.Numerics;

namespace Prompt13
{
   class Prompt13
   {
      //Main method begins execution of C# application
      static void Main()
      {
         //Prompt user and read first number
         Console.Write("Enter an intiger: ");
         int b = int.Parse(Console.ReadLine());

         //Prompt user and read second number
         Console.Write("Enter an second intiger: ");
         int c = int.Parse(Console.ReadLine());

         if (c == b)
         {
            Console.WriteLine($"The numbers are equal");
         }

         if (c < b)
         {
            Console.WriteLine($"{b} is larger.");
         }

         if (c > b)
         {
            Console.WriteLine($"{c} is larger.");
         }

      }//end Main
   }//end class Prompt13
}