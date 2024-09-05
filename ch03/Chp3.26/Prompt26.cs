// See https://aka.ms/new-console-template for more information

//Figure 3.26: Prompt26.cs
//(Diameter, Circumference and Area of a Circle)
//Here's a peek ahead. In this chapter, you have learned about integers and the type int. C# also can represent floating-point numbers that contain decimal points such as 3.14159. Write an app that inputs from the user the radius of a circle as an integer and displays the circle's diameter, circumfrence and area using the floating-point value 3.14159 for PIE. Use the techniques shown in Figure 3.14 [Note: You may also use the predefined constant Math.PI for the value of PIE. This constant is more precise than the value 3.14159. Class Math is defined in the namespace System]. Use the following formulas (r is the radius):

//diameter = 2r
//circumference = 2(PIE)r
//area = (PIE)r*Squared

//Don't store each calculation's result in a variable. Rather, specify each calculation as the value to be output in a Console.WriteLine statement. The values produced by the circumference and area calculations are floating-point numbers. You'll learn more about these in Chapter 5.

using System;
using System.Numerics;

class Prompt26
{
   // Main Method begins execution of C# application.
   static void Main()
   {
      //Prompt user and read first number
      Console.Write("Enter an intiger of the Radius of your Circle:  ");
      int r = int.Parse(Console.ReadLine());

      int diameter;
      double circumference;
      double area;

      //diameter = 2r
      diameter = 2*r;
      Console.WriteLine($"Diameter of our Circle is {diameter}.");

      //circumference = 2(PIE)r
      circumference = 2 * Math.PI * r;
      Console.WriteLine($"Circumference of our Circle is {circumference}");

      //area = (PIE)r*Squared
      area = (Math.PI * (r * r));
      Console.WriteLine($"Area of our Circle is {area}");

   }//end Main
}//end class Prompt26