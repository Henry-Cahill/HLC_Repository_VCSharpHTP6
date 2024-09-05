// See https://aka.ms/new-console-template for more information

//Figure 3.30
//(Counting Negative, Positive and Zero Values)
//Write an application that inputs five numbers and determines and displays the number of negative numbers input, the number of positive numbers input and the number of zeros input.

using System;
using System.Numerics;

class Prompt30
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

      if       (0 == aa)         Console.WriteLine($"{aa} is an zero number");
      else if  (0 == (aa % 2))   Console.WriteLine($"{aa} is an even number.");
      else if  (0 != (aa % 2))   Console.WriteLine($"{aa} is an odd number.");

      if       (0 == ab)         Console.WriteLine($"{ab} is an zero number");
      else if  (0 == (ab % 2))   Console.WriteLine($"{ab} is an even number.");
      else if  (0 != (ab % 2))   Console.WriteLine($"{ab} is an odd number.");

      if       (0 == ac)         Console.WriteLine($"{ac} is an zero number");
      else if  (0 == (ac % 2))   Console.WriteLine($"{ac} is an even number.");
      else if  (0 != (ac % 2))   Console.WriteLine($"{ac} is an odd number.");

      if       (0 == ad)         Console.WriteLine($"{ad} is an zero number");
      else if  (0 == (ad % 2))   Console.WriteLine($"{ad} is an even number.");
      else if  (0 != (ad % 2))   Console.WriteLine($"{ad} is an odd number.");

      if       (0 == ae)         Console.WriteLine($"{ae} is an zero number");
      else if  (0 == (ae % 2))   Console.WriteLine($"{ae} is an even number.");
      else if  (0 != (ae % 2))   Console.WriteLine($"{ae} is an odd number.");
      

   }//end Main
}//end class Prompt30