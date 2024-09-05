
//(Date Class)
//Create a class called Date that includes three pieces of information as auto-implemented properties - a month (type int), a day (type int), and a year (type int). Your class should have a constructor that initializes the three automatic properties and assumes that the values provided are correct. Provide a method DisplayDate that displays the month, day and year separated by forward slashes (/). Write a test application named DateTest that demonstrates class Date's capabilities.

class Date
{
  private int month {  get; set; } //auto-implmented property
   private int day { get; set; } //auto-implmented property
   private int year { get; set; } //auto-implmented property

   //Date constructor that receives 3 parameters.
   public Date(int inputMonth, int inputDay, int inputYear)
   {
      month = inputMonth;
      day = inputDay;
      year = inputYear;
   }

   //Method that adds the Month, Day, and Year together to form a date syntax MM/DD/YYYY
   public void DisplayDate(int takeMonth, int takeDay, int takeYear)
   {
      if (takeMonth > 0 || takeMonth < 12 && takeDay > 0 || takeDay < 31 && takeYear > 0)
      {
        Console.WriteLine($"{takeMonth}/{takeDay}/{takeYear}");
      }
   }

}