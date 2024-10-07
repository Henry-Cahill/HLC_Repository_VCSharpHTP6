
using System.Security.Principal;

//For each customer, the following facts are available:

// a) account number,
// b) balance at the beginning of the month,
// c) total all of items charged by the customer this month,
// d) total of all credits applied to the customer's account this month and
// e) allowed credit limit.

internal class CreditLimit
{
   //Initialization phase
   public string first_Name;        //instance variable
   public string last_Name;         //instance variable
   public int account;              //instance variable
   public int balanceBeginMonth;    //instance variable
   public int balanceEndMonth;      //instance variable
   public int debitOfItem;          //instance variable
   public int allItemsCharged;      //instance variable
   public int totalOfAllCredits;    //instance variable


   //CreditLimit Profile constructor that receives the parameters
   public CreditLimit(string perFirst_Name, string perLast_Name, int perAccount,
      int perBalanceBeginMonth, int perBalanceEndMonth, int perDebitOfItem, int perAllItemsCharged, int perTotalOfAllCredits)
   {
      first_Name = perFirst_Name;
      last_Name = perLast_Name;
      account = perAccount;
      balanceBeginMonth = perBalanceBeginMonth;
      balanceEndMonth = perBalanceEndMonth;
      debitOfItem = perDebitOfItem;
      allItemsCharged = perAllItemsCharged;
      totalOfAllCredits = perTotalOfAllCredits;
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
      private set //can be used only within the class
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
      private set //can be used only within the class
      {
         account = value;
      }
   }
   //Balance Begin Month property
   public int perBalanceBeginMonth
   {
      get
      {
         return balanceBeginMonth;
      }
      private set //can be used only within the class
      {
         balanceBeginMonth = value;
      }
   }
   //Balance End of the Month property
   public int perBalanceEndMonth
   {
      get
      {
         return balanceEndMonth;
      }
      private set //can be used only within the class
      {
         balanceEndMonth = value;
      }
   }
   //Debit of Item property
   public int perDebitOfItem
   {
      get
      {
         return debitOfItem;
      }
      private set //can be used only within the class
      {
         debitOfItem = value;
      }
   }
   //Total of All Items Charged property
   public int perAllItemsCharged
   {
      get
      {
         return allItemsCharged;
      }
      private set //can be used only within the class
      {
         allItemsCharged = value;
      }
   }
   //Total of All Credits property
   public int perTotalOfAllCredits
   {
      get
      {
         return totalOfAllCredits;
      }
      private set //can be used only within the class
      {
         totalOfAllCredits = value;
      }
   }

   /*
    * Method
    *The app. should input all these facts as integers, calculate the new balance (= beginning balance + charges - credits), display the new balance and 
    *determine whether the new balance exceeds the customer's credit limit. For those whose credit limit is exceeded, the app should display the message
    *"Credit limit exceeded". Use sentinel-controlled iteration to obtain the data for each account.
    */
   public void MonthlyCredits()
   {
      /*Processing Phase
      *prompt for input and read credits from user.
      */
      //Informing the user to enter a one or a value to continue
      //Teaching the user to enter -1 to quit
      Console.WriteLine("Enter 1 or a value to continue and understand value of -1 to quit: ");
      Console.WriteLine("Note: If entering a Debit ensure the number is positive. If crediting or withdrawing ensure the number is negative.");
      // Initiating the ItemCharged attribute
      // Reading the first iterations values from a string parsed to an integer.
      int itemCharged = int.Parse(Console.ReadLine());
      //Within the Console adding buffer for easier read ability. 
      Console.WriteLine("\n\n");

      int sumOfValues = 0; // initialize sum to 0 for totaling
      

      // loop until sentinel value is read from the user.
      while (itemCharged != -1)
      {
         sumOfValues += itemCharged; // add x to sum

         //---Prompt user for input and obtain a value from the user---
         //Displaying the number of Items entered using the iteration +1 (+1 is used to display the values in 1,2,3 ect. scale except the 0,1,2,3 ect. scale.)
         Console.WriteLine($"Iteration({perAllItemsCharged +1})");
         //Asking the human with the account number the item purchased
         Console.WriteLine($"Enter Account({perAccount})'s value of the Item Purchased");
         //Reading the users input and parsing the values to an integer
         itemCharged = int.Parse(Console.ReadLine());
         //Thanking the user for entering item # and be prepared to enter Item #
         //Including buffer to enhance readability of the code.
         Console.WriteLine($"Thanks for entering item {perAllItemsCharged + 1}. Be prepared to enter Item {perAllItemsCharged + 2}.\n\n");

         // increment AllItemsCharged so we can count the number of credits entered
         ++perAllItemsCharged;
      }
      /*
       * Termination Phrase; prepare and display results
       */

      perBalanceEndMonth = sumOfValues + balanceBeginMonth -1;
      //Displaying Number of Items added to the list of expenses.
      Console.WriteLine($"The number of Items {perAllItemsCharged -1}\n");
      //Displaying the Total credits.
      Console.WriteLine($"The month's beginning balance is ${balanceBeginMonth}");
      Console.WriteLine($"This is the total expenses ${sumOfValues -1}");
      Console.WriteLine($"Account {account} is end of the month is ${balanceEndMonth}");
      
      if(balanceEndMonth >= 8000)
      {
         Console.WriteLine("Exceeded Credit limit of $8000");
      }
   }
}
