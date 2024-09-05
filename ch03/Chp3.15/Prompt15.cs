// See https://aka.ms/new-console-template for more information

// Self Review Assignment 3.15
// (Arithmetic) Write an application that asks the user to enter two integers, obtains them from the user and displays their sum, product, difference and quotient (division). Use the techniques shown in Figure 3.14.

using System;
using System.Numerics;

namespace Prompt15
{
   class Prompt15
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

         Console.WriteLine(c + b);
         Console.WriteLine(c * b);
         Console.WriteLine(c - b);
         Console.WriteLine(c / b);

      }//end Main
   }//end class Prompt15
}