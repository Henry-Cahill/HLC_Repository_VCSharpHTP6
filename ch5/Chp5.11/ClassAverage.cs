﻿// See https://aka.ms/new-console-template for more information

//Fig. 5.11: ClassAverage.cs
//Solving the class-average problem using sentinel-controlled iteration.
using System;

class ClassAverage
{ 
   static void Main()
   {
      //Initialization phase
      // initialize variables in declarations
      int total = 0; //initialize sum of grades
      int gradeCounter = 0; // initialize # of grades entered so far

      //Processing phase
      //prompt for input and read grade from user
      Console.Write("Enter grade or -1 to quit: ");
      int grade = int.Parse(Console.ReadLine());

      //loop until sentinel value is read from the user
      while (grade != -1)
      {
         total = total + grade; //add grade to total
         gradeCounter = gradeCounter + 1; //increment counter

         //prompt for input and read grade from user
         Console.Write("Enter grade or -1 to quit: ");
         grade = int.Parse(Console.ReadLine());
      }

      //Termination phase
      //if the user entered at least one grade...
      if(gradeCounter != 0)
      {
         //use number with decimal point to calculate average of grades
         double average = (double)total / gradeCounter;

         //display the total and average (with two digits of precision)
         Console.WriteLine(
            $"\nTotal of the {gradeCounter:N} grades entered is {total:F}");
         Console.WriteLine($"Class average is {average:F}");
      }
      else //no grades we're entered, so output error message
      {
         Console.WriteLine("No grades we're entered");
      }
   } //End of the Main Method
} //End the class ClassAverage
