// See https://aka.ms/new-console-template for more information

//Figure 5.9
// Solving the class-average problem using counter-controlled iteration.

using System;

class ClassAverage
{
   static void Main()
   {
      //Initialization phase
      int total = 0; //initialize sum of grades entered by the user
      int gradeCounter = 1; //initialize grade # to be entered next

      //Processing phase uses counter-controlled iteration
      while (gradeCounter <= 10) //loop 10 times
      {
         Console.Write("Enter grade: "); //prompt
         int grade = int.Parse(Console.ReadLine()); //input grade
         total = total + grade; // add the grade to total
         gradeCounter = gradeCounter + 1; //increment the counter by 1
      }

      //Termination phase
      int average = total / 10; //integer division yields integer result

      //display total and average of grades
      Console.WriteLine($"\nTotal of all 10 grades is {total:N}");
      Console.WriteLine($"Class average is {average:F}");

   } //End of the Main Method
} //End the class ClassAverage