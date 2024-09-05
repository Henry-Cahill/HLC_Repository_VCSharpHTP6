// Self Review Assignment 3.3B: Prompt.cs
// Prompt the user to enter an integer.
using System;

namespace Prompt
{
   class Prompt
   {
      //Main method begins execution of C# application
      static void Main()
      {
         int number; //declare first number to add


         Console.Write("Enter an integer: "); //prompt user
                                                 // read fist number from user
         number = int.Parse(Console.ReadLine());
         Console.WriteLine($"{number} is the Number the user entered after Prompted"); // display prompted number
      }//end Main
   }//end class Prompt
}