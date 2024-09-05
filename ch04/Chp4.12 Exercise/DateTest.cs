// See https://aka.ms/new-console-template for more information

using System;

class DateTest
{
   static void Main()
   {
      Date date1 = new Date(01, 01, 2001);

      int takeMonth;
      int takeDay;
      int takeYear;

      //Prompt for the input of the desired Month.
      Console.Write($"\nEnter desired Month: ");
      int inputMonth = takeMonth = int.Parse(Console.ReadLine());

      //Prompt for the input of the desired Day.
      Console.Write($"\nEnter desired Day: ");
      int inputDay = takeDay = int.Parse(Console.ReadLine());

      //Prompt for the input of the desired Year.
      Console.Write($"\nEnter desired Year: ");
      int inputYear = takeYear = int.Parse(Console.ReadLine());

      //invoke the method of Display name to show Month, Day, and Year seperated by a forward slash.
      date1.DisplayDate(takeMonth, takeDay, takeYear);

   }
}