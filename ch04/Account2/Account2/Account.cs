﻿// Fig. 4.6: Account.cs
// Account class that replaces public methods SetName
// and GetName with a public Name property.

class Account
{
   private string name; // instance variable

   // property to get and set the name instance variable               
   public string Name
   {
      get // returns the corresponding instance variable's value
      {
         return name; // returns the value of name to the client code
      }
      set // assigns a new value to the corresponding instance variable
      {
         name = value; // value is implicitly declared and initialized
      }
   }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
