// See https://aka.ms/new-console-template for more information
// Self Review Assignment 3.3D: Prompt.cs
// If the variable number is not equal to 7, display "The variable number is not equal to 7" 
using System;
using System.Numerics;

namespace Prompt3
{
   class Prompt3
   {
      //Main method begins execution of C# application
      static void Main()
      {
         int number; //declare first number


         Console.Write("Enter an integer: "); //prompt user
                                              // read fist number from user
         number = int.Parse(Console.ReadLine());

         if (number == 7)
         {
            Console.WriteLine($"The variable ({number}) number is equal to 7");
         }

         if (number != 7)
         {
            Console.WriteLine($"The variable ({number}) number is not equal to 7");
         }

         if (number < 7)
         {
            Console.WriteLine($"The variable ({number}) number is less than 7");
         }

         if (number > 7)
         {
            Console.WriteLine($"The variable ({number}) number is greater than 7");
         }

         if (number <= 7)
         {
            Console.WriteLine($"The variable ({number}) number is less than or equal to 7");
         }

         if (number >= 7)
         {
            Console.WriteLine($"The variable ({number}) number  greater than or equal to 7");
         }

         Console.WriteLine($"{number} is the Input Integer the user entered after Prompted. While being held within a int. variable."); // display prompted number
      }//end Main
   }//end class Prompt3
}