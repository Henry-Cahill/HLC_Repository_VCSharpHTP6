// See https://aka.ms/new-console-template for more information

//Figure 3.28: Prompt28.cs
//(Digits of an Integer) Write an app that inputs one number consisting of five digits from the user, separates the number into its individual digits and displays the digits separated from one another by three spaces each. For example, if the user types 42339, the application should display.
//4   2   3   3   9
// Assume the user enters the correct number of digits.
// What happens when you execute the application and type a number with more than five digits?
// What happens when you execute the application and type a number with fewer than five digits?
//[Hint: It's possible to do this exercise with the techniques you learned in this chapter. You'll need to use both division and remainder operations to "pick off" each digit.] 

using System;
using System.Numerics;

class Prompt28
{
   // Main Method begins execution of C# application.
   static void Main()
   {
      //Prompt user and read first number
      Console.Write("Enter an intiger of five digits: ");
      int a = int.Parse(Console.ReadLine());

      int aa = (a / 10000);
      int ab = ((a - (aa * 10000)) / 1000);
      int ac = ((a - (aa * 10000) - (ab * 1000)) / 100);
      int ad = ((a - (aa * 10000) - (ab * 1000) - (ac * 100)) / 10);
      int ae = ((a - (aa * 10000) - (ab * 1000) - (ac * 100) - (ad * 10)) / 1);
      Console.WriteLine($"{aa}   {ab}   {ac}   {ad}   {ae}");


   }//end Main
}//end class Prompt28