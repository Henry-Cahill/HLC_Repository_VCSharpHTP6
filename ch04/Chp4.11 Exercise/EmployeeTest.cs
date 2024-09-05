// See https://aka.ms/new-console-template for more information

using System;

class EmployeeTest
{
   static void Main(string[] args)
   {
      Employee employee1 = new Employee("Henry", "Cahill", 12201.00m, 0.00m, 0.00m);
      Employee employee2 = new Employee("Hank", "Cahill", 6250.00m, 0.00m, 0.00m);

      //display the intial monthly salary.
      Console.WriteLine(
         $"{employee1.First_Name} {employee1.Last_Name}'s expected to monthly salary is {employee1.Monthly_Salary:C}.");
      Console.WriteLine(
         $"{employee2.First_Name} {employee2.Last_Name}'s expected to monthly salary is {employee2.Monthly_Salary:C}.");

      //display the yearly salary
      Console.WriteLine(
         $"{employee1.First_Name} {employee1.Last_Name}'s expected for the yearly salary is {employee1.Monthly_Salary * 12:C}.");
      Console.WriteLine(
         $"\n{employee2.First_Name} {employee2.Last_Name}'s expected for the yearly salary is {employee2.Monthly_Salary * 12:C}.");

      //prompt to Read input Employee1 months
      Console.Write($"\nEnter months to count for {employee1.First_Name}'s salary: ");
      int NumTimeSalary = int.Parse(Console.ReadLine());

      //Displaying the caught number of months for the first employee.
      Console.WriteLine(
         $"Multiplying {NumTimeSalary:G} months to {employee1.Monthly_Salary:C}.");
      employee1.MonthlyTimesSalary(NumTimeSalary); //multiply the current salary by the months entered.

      //Reviewing the employees salary for the months entered
      Console.WriteLine(
         $"{employee1.First_Name}'s salary for {NumTimeSalary:G} months is {employee1.Salary:C}.");

      //display the salary calculated from the months entered 
      Console.WriteLine(
         $"{employee1.First_Name} {employee1.Last_Name}'s expected for the {NumTimeSalary:G} of Months salary is {employee1.Salary:C}.");
      Console.WriteLine(
         $"\n{employee2.First_Name} {employee2.Last_Name}'s expected for the 0 of Months salary is {employee2.Salary:C}.");

      //prompt to Read input for Employee2 months
      Console.Write(
         $"\nEnter months to count for {employee2.First_Name}'s salary: ");
      int NumTimeSalary2 = int.Parse(Console.ReadLine());

      //Displaying the caught number of months for the second employee.
      Console.WriteLine(
         $"Multiplying {NumTimeSalary2:G} months to {employee2.Monthly_Salary:C}.");

      //Reviewing the employees salary for the months entered
      Console.WriteLine(
         $"{employee2.First_Name}'s salary for {NumTimeSalary2:G} months is {employee2.Monthly_Salary:C}.");
      employee2.MonthlyTimesSalary2(NumTimeSalary2); // multiplying the new number of months to the salary.

      //Reviewing the employees salary for the months entered
      Console.WriteLine(
         $"{employee2.First_Name}'s salary for {NumTimeSalary2:G} months is {employee2.Salary:C}.");

      //display the monthly calculated salary
      Console.WriteLine(
         $"{employee1.First_Name} {employee1.Last_Name}'s expected for the {NumTimeSalary:G} of Months salary is {employee1.Salary:C}.");
      Console.WriteLine(
         $"\n{employee2.First_Name} {employee2.Last_Name}'s expected for the {NumTimeSalary2:G} of Months salary is {employee2.Salary:C}.");

      //prompt to Read input for both employees
      Console.Write($"\nEnter percentage for bonuses: ");
      int BonusSalary = int.Parse(Console.ReadLine());

      //Reviewing the employees expected bonus. 
      Console.WriteLine($"{employee1.First_Name}'s bonus is {BonusSalary:G}% of his or her yearly salary.");
      Console.WriteLine($"\n{employee2.First_Name}'s bonus is {BonusSalary:G}% of his or her yearly salary.");

      employee1.BonusYearSalary(BonusSalary); //the percentege for the annual salary plus the bonus to the newly created salarybonus.
      employee2.BonusYearSalary(BonusSalary); //the percentage for the annual salary plus the bonus to the newly created salarybonus.

      Console.WriteLine($"The employee {employee1.First_Name}'s {BonusSalary:G}% bonus is {employee1.SalaryBonus:C}.");
      Console.WriteLine($"\nThe employee {employee2.First_Name}'s {BonusSalary:G}% bonus is {employee2.SalaryBonus:C}.");

   }
}