// Self Review Assignment 3.3C: Prompt.cs
// Input an integer and assign the result to int variable value. 
using System;

namespace Prompt2
{
   class Prompt2
   {
      //Main method begins execution of C# application
      static void Main()
      {
         int number; //declare first number


         Console.Write("Enter an integer: "); //prompt user
                                              // read fist number from user
         number = int.Parse(Console.ReadLine());
         Console.WriteLine($"{number} is the Input Integer the user entered after Prompted. While being held within a int. variable."); // display prompted number
      }//end Main
   }//end class Prompt2
}