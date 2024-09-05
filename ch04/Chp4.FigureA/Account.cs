// Figure 4.2: Account.cs
//A simple Account class that contains a private instance
// variable name and public methods to Set and Get name's value.

class Account
{
   private string name; // instance variable

   // method that sets the account name in the object
   public void SetName(string accountname)
   {
      name = accountname;
   }

   // method that retrieves the account name from the object
   public string GetName()
   {
      return name; // returns name's value to this method's callers
   }
}
