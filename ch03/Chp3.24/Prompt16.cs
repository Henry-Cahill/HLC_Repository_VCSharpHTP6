// See https://aka.ms/new-console-template for more information

//Figure 3.24: Prompt16.cs
//(Odd or Even) Write an app that reads an integer, then determines and displays whether it's odd or even. [Hint: use the remainder operator. An even number is a multiple of 2. Any multiple of 2 leaves a remainder of 0 when divided by 2.
using System;
using System.Numerics;

class Prompt16
{
   // Main Method begins execution of C# application.
   static void Main()
   {
      //Prompt user and read first number
      Console.Write("Enter an intiger: ");
      int a = int.Parse(Console.ReadLine());

      if (0 == (a % 2)) Console.WriteLine($"{a} is an even number.");
      else if (0 != (a % 2)) Console.WriteLine($"{a} is an odd number.");
   }//end Main
}//end class Prompt16