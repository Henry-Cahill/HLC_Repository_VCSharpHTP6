using System.Windows.Markup;

internal class SalaryCalculator
{  //Initialization phase
   public string  first_Name;        //Instance variable
   public string  last_Name;         //Instance variable
   public int     account;           //Instance variable
   public int     hours;             //Instance variable
   public int     countItems;        //Instance variable
   public double  totalCountOfHours; //Instance variable
   public double  balanceHours;      //Instance variable
   

   //Salary Calculator constructor receives the parameters.
   public SalaryCalculator(string perFirst_Name, string perLast_Name, int perAccount, int perHours, int perCountItems, double perTotalCountOfHours, double perBalanceHours)
   {
      first_Name        = perFirst_Name;
      last_Name         = perLast_Name;
      account           = perAccount;
      hours             = perHours;
      countItems        = perCountItems;
      totalCountOfHours = perTotalCountOfHours;
      balanceHours      = perBalanceHours;
   }

   //First Name property
   public string perFirst_Name
   {
      get
      {
         return first_Name;
      }
      private set //can be used only within the class
      {
         first_Name = value;
      }
   }
   //Last Name property
   public string perLast_Name
   {
      get
      {
         return last_Name;
      }
      private set //can be only within the class
      {
         last_Name = value;
      }
   }
   //Account property
   public int perAccount
   {
      get
      {
         return account;
      }
      private set //can be only within the class
      {
         account = value;
      }
   }
   //Hours property
   public int perHours
   {
      get
      {
         return hours;
      }
      private set //can only be within the class.
      {
         hours = value;
      }
   }
   //CountItems property
   public int perCountItems
   {
      get
      {
         return countItems;
      }
      private set // can be only within the class.
      {
         countItems = value;
      }
   }
   //TotalCountOfHours property
   public double perTotalCountOfHours
   {
      get
      {
         return totalCountOfHours;
      }
      private set //can be only within the class.
      {
         totalCountOfHours = value;
      }
   }
   //BalanceHours property
   public double perBalanceHours
   {
      get
      {
         return balanceHours;
      }
      private set //can be only within the class.
      {
         balanceHours = value;
      }
   }

   public void SalaryHourCalculator()
   {
      /*Processing Phase
       * prompt for input and read credits from user.
       */
      
      //Teaching the user to enter -1 to quit.
      Console.Write("\nEnter 1 or a value to continue and understand value of -1 to quit: ");

      //Initiating the ItemCharged attribute
      //Reading the first iterations values from a string parsed to an integer.
      double itemCharged = double.Parse(Console.ReadLine());
      //loop until sentinel value (negative one) is input from the user.
      while(itemCharged != -1)
      {  //---Prompt user for input and obtain a value from the user---
         
         //Displaying the number of Items entered using the iteration +1
         //(+1 is to display the values in 1, 2, 3, ect. scale except the 0, 1, 2 ,3 ect. scale)
         Console.Write($"\nIteration {++perCountItems}\n" +
         //Asking the human with the account number the hours input
                       $"Enter the number One(1) if you want to continue: ");
         //Reading the user input and parsing the values to a double.
         itemCharged = (double.Parse(Console.ReadLine()));

         Console.Write($"Please enter ({perAccount})'s hours worked: ");
         hours = int.Parse(Console.ReadLine());

         //Thanking the user for entering item # and informing the human to prepared to enter Item #
         //Including buffer space to enhance readability of the code.
         Console.Write($"\nThanks for entering your {perCountItems + 1} set of Hours Worked.");
         if (itemCharged != -1)
         { 
            Console.Write($" Be prepared to enter your {perCountItems + 2} iteration hours worked.\n\n");
         }

         // Increment perCountItems so we can count the number of times hours are entered.
         ++perCountItems;
         perBalanceHours += hours;
      }
      /*
       * Termination phase; prepare and display results
       */
      Console.Write("\n--------------------------------------------------------------------------------------------------\n" +
                    "--------------------------------------------------------------------------------------------------\n" +
                    "TERMINATION PHASE                                                                                 \n\n");
      //The Personal Balance of Hours is made up of the attributes "person Balance Hours" plus "total Count Of Hours"
     perTotalCountOfHours = perBalanceHours + totalCountOfHours;
      if (perTotalCountOfHours <= 40)
      {
         //Displaying the Total Hours worked.
         Console.Write($"This is the total hours worked {perTotalCountOfHours}.\n");
      }
      else if( perTotalCountOfHours <= 80)
      {
         Console.Write($"This is the total hours worked {perTotalCountOfHours}.\n" +
                        "Where there is already 40 hours of work\n" +
                       $"There is {perTotalCountOfHours - 40} hour of time-and-a-half\n\n");
      }
      else
      {
         Console.Write("Exceed 80 hours of work.\n");
      }
   }
}
