// See https://aka.ms/new-console-template for more information

//Figure 5.16: Increment.cs
//Prefix increment and post fix increment operators.
using System;

class Increment
{
   static void Main()
   {
      //Initialization phase
      // demonstrate postfix increment operator
      int c = 5;//assign 5 to c

      //Processing phase
      //Termination phase
      Console.WriteLine($"c before post-increment: {c:N}"); // display 5
      Console.WriteLine($"    post-incrementing c: {c++:N}"); // display 5
      Console.WriteLine($" c after post-increment: {c:N}"); // display 6
      Console.WriteLine(); //skip a line

      //demonstrate prefix increment operator
      c = 5; //assign 5 to c
      Console.WriteLine($" c before pre-increment: {c:N}"); // displays 5
      Console.WriteLine($"     pre-incrementing c: {++c:N}"); // displays 6
      Console.WriteLine($"  c after pre-increment: {c:N}"); // display 6
   } //End of the Main Method
} //End the class Increment 
