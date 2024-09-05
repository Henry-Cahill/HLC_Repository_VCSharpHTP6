// See https://aka.ms/new-console-template for more information

//(Table of Squares and Cubes)
//Using only the programming techniques you learned in this chapter, write an application that calculates the squares and cubes of the numbers from 0 to 10 and displays the resulting values in table format, as shown in. All calculations should be done in terms of a variable x. 
// [Note: This app does not require any input from the user.]

using System;
using System.Numerics;

class Prompt29
{
   // Main Method begins execution of C# application.
   static void Main()
   {
      int a = 0;
      int b = 1;
      int c = 2;
      int d = 3;
      int e = 4;
      int f = 5;
      int g = 6;
      int h = 7;
      int i = 8; 
      int j = 9;
      int k = 10;

      Console.WriteLine("number   square   cube");
      Console.WriteLine($"{a}        {a * a}        {a * a * a}");
      Console.WriteLine($"{b}        {b * b}        {b * b * b}");
      Console.WriteLine($"{c}        {c * c}        {c * c * c}");
      Console.WriteLine($"{d}        {d * d}        {d * d * d}");
      Console.WriteLine($"{e}        {e * e}       {e * e * e}");
      Console.WriteLine($"{f}        {f * f}       {f * f * f}");
      Console.WriteLine($"{g}        {g * g}       {g * g * g}");
      Console.WriteLine($"{h}        {h * h}       {h * h * h}");
      Console.WriteLine($"{i}        {i * i}       {i * i * i}");
      Console.WriteLine($"{j}        {j * j}       {j * j * j}");
      Console.WriteLine($"{k}       {k * k}      {k * k * k}");
   }//end Main
}//end class Prompt29