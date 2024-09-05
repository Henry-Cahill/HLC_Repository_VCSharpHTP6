// See https://aka.ms/new-console-template for more information

// Figure 4.1: AccountTest.cs
// Creating and manipulating an Account object.

using System;

class AccountTest
{
   static void Main()
   {
      // Create an Account Object and assign it to myAccount.
      Account myAccount = new Account();

      //display myAccount's initial name (there isn't one yet)
      Console.WriteLine($"Initial name is: {myAccount.GetName()}");

      //prompt for and read the name , then put the name in the object
      Console.Write("Enter the name: "); // Prompt
      string theName = Console.ReadLine(); // Read the name
      myAccount.SetName(theName); // put theName in the myAccount object

      // display the name stored in the myAccount object
      Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
   }
}
