// See https://aka.ms/new-console-template for more information

//Figure 3.25: Prompt25.cs
//(Multiples) Write an app that reads two integers, determines whether the first is a multiple of the second and displays the result. [Hint: Use the remainder operator]
using System;
using System.Numerics;

class Prompt25
{
   // Main Method begins execution of C# application.
   static void Main()
   {
      //Prompt user and read first number
      Console.Write("Enter an intiger: ");
      int a = int.Parse(Console.ReadLine());

      //Prompt user and read second number
      Console.Write("Enter another intiger: ");
      int b = int.Parse(Console.ReadLine());

      if ((b/a) == a) Console.WriteLine($"{a} is a multiple of the number {b}.");
      else if (a*(b/a) != b) Console.WriteLine($"{a} isn't a multiple of the number {b}.");
      else if ((b/a) == (b/a)) Console.WriteLine($"{a} is a multiple of the number {b}.");
   }//end Main
}//end class Prompt25