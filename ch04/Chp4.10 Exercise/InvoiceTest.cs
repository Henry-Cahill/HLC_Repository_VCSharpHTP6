using System;

class AccountTest
{
   static void Main()
   {
      Invoice account1 = new Invoice(10000,"Hubcap", 1,0.00m, 50.00m);
      Invoice account2 = new Invoice(10001, "Hair Gell", 1, 0.00m, 7.53m);

      // display initial prices per item.
      Console.WriteLine(
         $"{account1.Description}'s is expected to be {account1.Priceperitem:C} per item.");
      Console.WriteLine(
         $"{account2.Description}'s is expected to be {account2.Priceperitem:C} per item.");

      // display initial quantity per item.
      Console.WriteLine(
         $"{account1.Description}'s quantity in cart is {account1.Quantity}");
      Console.WriteLine(
         $"{account2.Description}'s quantity in cart is {account2.Quantity}");


      //prompt for then read input 
      Console.Write($"\nEnter desired amount of {account1.Description}'s: ");
      int newQuantity = int.Parse(Console.ReadLine());
      Console.WriteLine(
         $"adding {newQuantity:G} to account1 balance\n");
      account1.GetInvoiceAmount(newQuantity); // add to account1's balance

      // Review the accounts balances for account 1 and account 2
      Console.WriteLine(
         $"account1's balance: {account1.Balance:C}");
      Console.WriteLine(
         $"account2's balance: {account2.Balance:C}");

      //prompt for them read input 
      Console.Write($"\nEnter desired amount of {account2.Description}'s: ");
      newQuantity = int.Parse(Console.ReadLine());
      Console.WriteLine(
         $"adding {newQuantity:G} to account1 balance\n");
      account2.GetInvoiceAmount(newQuantity); // add to account2's balance

      // Review the accounts balances for account 1 and account 2
      Console.WriteLine(
         $"account1's balance: {account1.Balance:C}");
      Console.WriteLine(
         $"account2's balance: {account2.Balance:C}");
   }
}