//4.10 (Invoice Class) Create a class called Invoice that a hardware store might use to represent an invoice for an item sold at the store. An Invoice should include four pieces of information as either instance varbiables or auto-implemented properties -
//a part number (type string),
//a part description (type string),
//a quantity of the item being purchased (type int),
//and a price per item (decimal)
//Your class should have a constructor that initializes four values.
//Provide a property with a get and set accessor for any instance variables.
//For the Quantity and PricePerItem properties if the value passed to the set accesor is negative, the value of the instance variable should be left unchanged.
//Also, provide a method named GetInvoiceAmount that calculates the invoice amount (i.e., multiplies the quantity by the price per item), then returns the amount as a  decimal value.

//Write a test application named InvoiceTest that demonstrates class Invoice's capabilities.

class Invoice
{
   private int Number {  get; set; } //auto-implmented property
   public string Description { get; set; } // auto-implemented property
   private int quantity; //instance variable
   private decimal balance; // instance variable
   private decimal priceperitem; //instance variable

   //Account constructor that receives five parameters.
   public Invoice(int partNumber, string partDescription, int partQuantity,
       decimal initialBalance, decimal partPricePerItem)
   {
      Number = partNumber;
      Description = partDescription;
      Quantity = partQuantity; //Quantity's set accessor validates
      Balance = initialBalance; //Balance's set accessor validates
      Priceperitem = partPricePerItem; //Priceperitem set accessor validates
   }

   //Quantity with validation
   public int Quantity
   {
      get
      {
         return quantity;
      }
      private set
      {
         if (value > 0)
         {
            quantity = value;
         }
      }
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

   //Price per item with validation
   public decimal Priceperitem
   {
      get
      {
         return priceperitem;
      }
      private set 
      { 
         if (value > 0.0m)
         {
            priceperitem = value;
         }
      }
   }

   //method that multiplies Quantity and Priceperitem only a valid amount to the 
   public void GetInvoiceAmount(decimal newQuantity)
   {
      if (quantity > 0)
      {
         Balance = Balance + ((newQuantity) * Priceperitem);
      }
   }
}