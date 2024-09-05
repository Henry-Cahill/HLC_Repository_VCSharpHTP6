// See https://aka.ms/new-console-template for more information

//3.14 Displaying Numbers
//Write an application that displays the number of 1 to 4 on the same line, with each pair of adjacent numbers seperated by one space. Write the app using the following techniques:

namespace Prompt12
{
   class Prompt12
   {
      //Main method begins execution of C# application
      static void Main()
      {
         int one = 1;
         int two = 2;
         int three = 3;
         int four = 4;

         // A) Use one Console.WriteLine Statement
         Console.WriteLine("1 2 3 4");

         // B) Use four Console.Write Statement
         Console.Write("1 "); Console.Write("2 "); Console.Write("3 "); Console.Write("4");

         // C) Use one Console.WriteLine statement with four int variables and string interpolation.
         Console.WriteLine($"\n{one} {two} {three} {four}");

      }//end Main
   }//end class Prompt12
}