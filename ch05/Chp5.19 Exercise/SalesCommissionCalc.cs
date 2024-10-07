
internal class SalesCommissionCalculation
{
   //Initialization phase
   public string first_Name;     //instance variable
   public string last_Name;      //instance variable
   public int account;           //instance variable
   public int sales;             //instance variable
   public int countItems;        //instance variable
   public double balanceSales;   //instance variable
   public int totalCountOfSales; //instance variable

   //Sales Commission Calculator constructor that receives the parameters.
   public SalesCommissionCalculation(string perFirst_Name, string perLast_Name, int perAccount, int perSales, int perCountItems, double perBalanceSales, int perTotalCountOfSales)
   {
      first_Name        = perFirst_Name;
      last_Name         = perLast_Name;
      account           = perAccount;
      sales             = perSales;
      countItems        = perCountItems;
      balanceSales      = perBalanceSales;
      totalCountOfSales = perTotalCountOfSales;
   }

   //Fist Name property
   public string perFirst_Name
   {
      get
      {
         return first_Name;
      }
      private set // can be used only within the class
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
   //Sales property
   public int perSales
   {
      get
      {
         return sales;
      }
      private set //can be only within the class
      {
         sales = value;
      }
   }
   //Count Items property
   public int perCountItems
   {
      get
      {
         return countItems;
      }
      private set // can be only within the class
      {
         countItems = value;
      }
   }
   //Balance Sales property
   public double perBalanceSales
   {
      get
      {
         return balanceSales;
      }
      private set // can be only within the class
      {
         balanceSales = value;
      }
   }
   //Total Count Of Sales property
   public int perTotalCountOfSales
   {
      get
      {
         return totalCountOfSales;
      }
      private set //can be only within the class
      {
         totalCountOfSales = value;
      }
   }

   public void CommissionCalculation()
   {
      /*Processing Phase
      *prompt for input and read credits from user.
      */
      Console.WriteLine("Salespersons are paid $200 weekly plus 9% of each gross sales item.");
      //Informing the user to enter a one or a value to continue
      //Teaching the user to enter -1 to quit
      Console.WriteLine("Enter 1 or a value to continue and understand value of -1 to quit: ");

      // Initiating the ItemCharged attribute
      // Reading the first iterations values from a string parsed to an integer.
      double itemCharged = double.Parse(Console.ReadLine());

      //Within the Console adding buffer for easier read ability. 
      Console.WriteLine("\n\n");

      double sumOfValues = 0;       //initialize sum to 0 for totaling.
      double percentageOfSales = 0; //initialize placeholder for the Commission of Sales for the existing loop.
      double totalOfCommission = 0; //initialize placeholder for the Total Of Commissions after each loop. 

      //loop until sentinel value (negative one) is input from the user.
      while (itemCharged != -1)
      { 
         //When we are exiting the while loop we won't compute the following calculations
         //If we are continuing the While loop we will compute "percentage of Sales"
         //If we are continuing the While loop we will complete the SumOfValues and total Of Commissions Sales
         if (itemCharged != -1)
         {
            percentageOfSales = (itemCharged * 0.09);       // Calculating the 9 percentage of the entered item charged. Which will be used as the profit the sales person earns for their work.
            sumOfValues += itemCharged;                     // added itemCharged to sumOfCharged
            totalOfCommission += percentageOfSales;         // added calculated atribute percentage of sales to the Total of commission.
         }

         //---Prompt user for input and obtain a value from the user---
         //Displaying the number of Items entered using the iteration +1
         //(+1 is used to display the values in 1, 2, 3 ect. scale except the 0, 1, 2, 3 ect. scale.)
         Console.Write($"Iteration {perTotalCountOfSales + 1}\n"+
         //Asking the human with the account number the item purchased
         $"Enter Account ({perAccount})'s value of the Item Purchased: ");

         //Reading the users input and parsing the values to an integer.
         //Where we are expecting a double (00.00) then converting the value to an integer.
         itemCharged = (double.Parse(Console.ReadLine()));

         //Thanking the user for entering item # and informing the human to be prepared to enter Item #
         //Including buffer space to enhance readability of the code.
         Console.WriteLine($"Thanks for entering item price {perTotalCountOfSales + 1}. Be prepared to enter Item price of {perTotalCountOfSales + 2}.\n\n");

         // increment perTotalCountOfSales so we can count the number of credits entered.
         ++perTotalCountOfSales;
      }
      /*
       *Termination Phrase; prepare and display results 
      */
      //The Person Balance Sales value is made up of the attributes "Sum of Values" plus "Balance Sales" minus one
      perBalanceSales = sumOfValues + balanceSales -1;

      //If the "Sum of Values" equals negative one OR "Sum of Values" equals one
      if (sumOfValues == -1 || sumOfValues == 1)
      {
         //We will set the attribute "sum of Values" equal to zero
         sumOfValues = 0;
      }
      //If the Person Balance Sales is equal to negative one 
      if (perBalanceSales == -1)
      {
         //We will set the attribute "Person balance sales" equal to zero
         perBalanceSales = 0;
      }
      //If the Total Of Commission is equal to nine hundredth
      if (totalOfCommission == 0.09)
      {
         //We will set the attribute "Total Of Commission" is equal to zero
         totalOfCommission = 0;
      }

      //Displaying the Total credits.
      Console.WriteLine($"This is the total funds ${sumOfValues:F}.\n"+
         //Account number is the total sales for the end of the week.
         $"Account {perAccount} week of sales balance is ${perBalanceSales:F}\n" +
         //Commission on all sales as a total displayed for the end user.
         $"Commission earned total is ${totalOfCommission:F}\n"+
         //We are only calculating for one week of sales.
         $"Funds earned for the Account {perAccount} is ${totalOfCommission+200:F}");
   }
}
