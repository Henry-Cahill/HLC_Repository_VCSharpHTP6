﻿// See https://aka.ms/new-console-template for more information
//Figure 3.14: Addition.cs
//Displaying the sum of two numbers input from the keyboard.
using System;

class Addition
{
   // Main Method begins execution of C# application.
   static void Main()
   {
      int number1; //declare first number to add
      int number2; //declare second number to add
      int sum; // declare sum of number1 and number2

      Console.Write("Enter first integer: "); //prompt user
      // read fist number from user
      number1 = int.Parse(Console.ReadLine());
      Console.Write("Enter second integer: "); //prompt user
      //read second number from user
      number2 = int.Parse(Console.ReadLine());
      
      sum = number1 + number2; //add numbers

      Console.WriteLine($"Sum is {sum}"); // display sum
   }//end Main
}//end class Addition