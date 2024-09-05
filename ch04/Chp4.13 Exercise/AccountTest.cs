//Exercise 4.13
// (Removing Duplicate Code in the Method Main)
/* In the AccountTest class figure 4.12, method Main contains six statements (lines 13-14, 15-16, 26-27, 28-29, 39-40 and 41-42) that each display an Account object's Name and Balance. Study these statements and you'll notice that they differ only in the Account object being manipulated - account1 or account2. In this exercise, you'll define a new DisplayAccount method that contains one copy of that output statement. The methods's parameter will be an Account object and the method will output the object's Name and Balance. You'll then replace the six duplicated statements in Main with calls to DisplayAccount, passing as an argument the specific Account object to output.
* Modify class AccountTest class of Figure 4.12 to declare the following DisplayAccount method after the closing right brace of the Main and before the closing right brace of AccountTest:
* 
* Static void DisplayAccount (Account accountToDisplay)
* {
*   Place the statement that displays
*   accountToDisplay's Name and Balance here
* }
* 
* Replace the comment in the member function's body with a statement that displays accountToDisplay's Name and Balance.
* Note that Main is a static method. We also declared method DisplayAccount as a static method. When Main needs to call another method in the same class without first creating an object of that class, the other method also must be declared static
* Once you've completed DisplayAccount's declaration, modify Main to replace the statements that display each Account's Name and Balance with calls to DisplayAccount - Each receiving as its argument the account1 or account2 object, as appropriate. Then, test the updated AccountTest class to ensure that it produces the same output as shown in Figure 4.12.
*/

//Figure 4.12: AccountTest.cs
//Reading and writing monetary amounts with Account objects.

using System;
using System.ComponentModel.DataAnnotations;

class AccountTest
{
   static void DisplayAccount(Account accountToDisplay)
   {
      //place the statement that displays
      //accountToDisplay's Name and Balance
      //display balances
      Console.WriteLine(
         $"{accountToDisplay.Name}'s and Balance {accountToDisplay.Balance:C}");
   }
   static void Main()
   {
      Account account1 = new Account("Jane Green", 50.00m);
      Account account2 = new Account("John Blue", -7.53m);
      // display initial balance of each object

      //display balances
      DisplayAccount(account1);
      DisplayAccount(account2);

      //prompt for then read input
      Console.Write("\nEnter deposit amount for account1: ");
      decimal depositAmount = decimal.Parse(Console.ReadLine());
      Console.WriteLine(
         $"adding {depositAmount:C} to account1 balance\n");
      account1.Deposit(depositAmount); // add to account1's balance

      //display balances
      DisplayAccount(account1);
      DisplayAccount(account2);

      //prompt for then read input
      Console.Write("\nEnter deposit amount for account2: ");
      depositAmount = decimal.Parse(Console.ReadLine());
      Console.WriteLine(
         $"adding {depositAmount:C} to account2 balance\n");
      account2.Deposit(depositAmount); // add to account2's balance

      //display balances
      DisplayAccount(account1);
      DisplayAccount(account2);
   }
}
