//4.9(Account Modification)
//Modify class Account (Figure.4.11) to provide a Withdraw Method that withdraws money from an Account.
//Ensure that the withdrawal amount doesn't exceed the balance. If it does, the balance should not be changed and the method should display a message indicating "Withdrawal amount exceeded account balance." Modify class AccountTest (Figure.4.12) to test method Withdraw

//Figure. 4.13: Account.cs
//Account class with a balance and a Deposit method.

class Account
{
   public string Name { get; set; } // auto-implemented property
   private decimal balance; //instance variable

   //Account constructor that receives two paramaters
   public Account(string accountName, decimal initialBalance)
   {
      Name = accountName;
      Balance = initialBalance; //Balance;s set accessor validates
   }

   //Balance property with validation
   public decimal Balance
   {
      get
      {
         return balance;
      }
      private set //can be used only within the class
      {
         //validate that the balance is greater than 0.0; if it's not,
         //instance variable balance keeps its prior value
         if (value > 0.0m) //m indicates that 0.0 is a decimal literal
         {
            balance = value;
         }
      }
   }

   //method that deposits (adds) only a valid amount to the balance
   public void Deposit(decimal depositAmount)
   {
      if (depositAmount > 0.0m) // if the depositAmount is valid
      {
         Balance = Balance + depositAmount; // add it to the balance
      }
   }

   //method that Withdraws (subtract) only a valid amount to the balance
   public void Withdraw(decimal withdrawAmount)
   {
      if (withdrawAmount >= Balance ) // if the withdrawAmount is valid
      {
         Console.WriteLine("Withdrawl amount exceeded the account balance.");
      }
      else if (withdrawAmount > 0.0m) // if the withdrawAmount is valid
      {
         Balance = Balance - withdrawAmount; // subtract from the balance
      }
   }
}