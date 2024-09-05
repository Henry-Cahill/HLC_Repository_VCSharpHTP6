//Exercise 4.11
//(Employee Class)
//Create a class called Employee that includes
//three pieces of information as either instance variables or auto-implemented properties-a first name (type string), a last name (type string), and a monthly salary (decimal). 
// Your class should have a constructor that initializes the three values. Provide a property with a get and set accessor for any instance variables.
// If the monthly salary is negative, the set accessor should leave the instance variable unchanged. Write a test app named EmployeeTest that demonstrates class Employee's capabilities. Create two Employee objects and display each object's yearly salary. Then give each employee a 10% raise and display each Employee's yearly salary again.

class Employee
{
   public string First_Name { get; set; } //auto-implemented property
   public string Last_Name { get; set; } //auto-implemented property
   private decimal monthly_salary; //instance variable
   private decimal salary; //instance variable
   private decimal salarybonus; //instance variable

   //Employee constructor that receives the five parameters.
   public Employee(string emFirst_Name, string emLast_Name, decimal emMonthly_Salary, decimal emSalary, decimal emSalaryBonus) 
   {
      First_Name = emFirst_Name;
      Last_Name = emLast_Name;
      monthly_salary = emMonthly_Salary; //Monthly salary set accessor validates
      salary = emSalary; //Salary set accessor validates
      salarybonus = emSalaryBonus; //Salarybonus set accessor validates
   }

   //Monthly Salary property with validation.
   public decimal Monthly_Salary
   {
      get
      {
         return monthly_salary;
      }
      private set //can be used only within the class
      {
         //validate that the monthly salary is greater than 0.0; if it's not,
         //instance variable balance keeps its prior value
         if (value > 0.0m) //m indicates that 0.0 is a decimal literal
         {
            monthly_salary = value;
         }
      }
   }

   public decimal Salary
   {
      get
      {
         return salary;
      }
      private set //can be used only within the class
      {
         //validate that the salary is greater than 0.0; if it's not,
         //instance variable balance keeps its prior value
         if(value > 0.0m) // m indicates that 0.0 is a decimal literal
         {
            salary = value;
         }
      }
   }

   public decimal SalaryBonus
   {
      get
      {
         return salarybonus;
      }
      private set
      {
         //validate that the monthly salary is greater than 0.0; if it's not,
         //instance variable balance keeps it prior value
         if (value > 0.0m) //m indicate that 0.0 is a decimal literal
         {
            salarybonus = value;
         }
      }
   }

   //Method that multiplies Monthly Salary by 12 months to calculate the employees yearly salary.
   public void MonthlyTimesSalary(decimal NumTimeSalary)
   {
      if (monthly_salary > 0)
      {
         salary = monthly_salary * NumTimeSalary;
      }
   }

   //Method that multiplies Monthly Salary by 12 months to calculate the employees yearly salary.
   public void MonthlyTimesSalary2(decimal NumTimeSalary2)
   {
      if (monthly_salary > 0)
      {
         salary = monthly_salary * NumTimeSalary2;
      }
   }

   //Method that multiplies Monthly Salary by 12 months to calculate the employees yearly salary.
   //Where we add the employees yearly salary of a {user input}% bonus to the current salary calculated.
   public void BonusYearSalary(decimal BonusSalary)
   {
      if (monthly_salary > 0)
      {
         salarybonus = salary + (salary * (BonusSalary/100));
      }
   }
}
