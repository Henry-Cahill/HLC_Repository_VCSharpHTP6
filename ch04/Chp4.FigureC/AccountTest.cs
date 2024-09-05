// See https://aka.ms/new-console-template for more information

//Figure 4.5: AccountTest.cs
//Creating and manipulating an Account object with properties.
using System;

class AccountTest
{
   static void Main()
   {
      //create two Account objects
      Account account1 = new Account("Jane Green");
      Account account2 = new Account("John Blue");

      //display initial value of name for each Account
      Console.WriteLine($"account1 name is: {account1.Name}");
      Console.WriteLine($"account2 name is: {account2.Name}");
   }
}