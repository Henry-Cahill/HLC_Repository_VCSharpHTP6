// See https://aka.ms/new-console-template for more information
//Figure 3.22: Comparison.cs
//Comparing integers using if statements, equality operators
// and relational operators.
using System;

class Comparison
{
   // Main Method begins execution of C# application.
   static void Main()
   {
      //Prompt user and read first number
      Console.Write("Enter first intiger: ");
      int number1 = int.Parse(Console.ReadLine());

      //Prompt user and read second number
      Console.Write("Enter second intiger: ");
      int number2 = int.Parse(Console.ReadLine());

      if (number1 == number2)
      {
         Console.WriteLine($"{number1} == {number2}");
      }

      if (number1 != number2)
      {
         Console.WriteLine($"{number1} != {number2}");
      }

      if (number1 < number2)
      {
         Console.WriteLine($"{number1} < {number2}");
      }

      if (number1 > number2)
      {
         Console.WriteLine($"{number1} > {number2}");
      }

      if (number1 <= number2)
      {
         Console.WriteLine($"{number1} <= {number2}");
      }

      if (number1 >= number2)
      {
         Console.WriteLine($"{number1} >= {number2}");
      }
   }//end Main
}//end class Comparison