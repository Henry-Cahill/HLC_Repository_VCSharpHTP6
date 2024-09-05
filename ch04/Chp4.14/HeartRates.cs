class HeartRates
{
   public string first_Name; //instance variable
   public string last_Name; //instance variable
   public int yearOfBirth; //instance variable
   public int age; //instance variable
   public int currentYear; //instance variable
   private int maxHeartRate; //instance variable
   private double minHighHeartRate; //instance variable
   private double minLowHeartRate; //instance variable

   //HeartRate constructor that receives the eight parameters.
   public HeartRates(string perFirst_Name, string perLast_Name, int perYearOfBirth, int perAge, int perCurrentYear, int perMaxHeartRate, double perMinHighHeartRate, double perMinLowHeartRate)
   {
      first_Name = perFirst_Name;
      last_Name = perLast_Name;
      yearOfBirth = perYearOfBirth;
      currentYear = perCurrentYear;
      age = perAge;
      maxHeartRate = perMaxHeartRate;
      minHighHeartRate = perMinHighHeartRate;
      minLowHeartRate = perMinLowHeartRate;
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
   //Year of Birth property with validation
   public int perYearOfBirth
   {
      get
      {
         return yearOfBirth;
      }
      private set // can be used only within the class
      {
         //validate that the year of birth is greater than 0; if it's not.
         //instance variable year of birth keeps its prior value
         if (value > 0)
         {
            yearOfBirth = value;
         }
      }
   }
   //Year of Birth property with validation
   public int perCurrentYear
   {
      get
      {
         return currentYear;
      }
      private set // can be used only within the class
      {
         //validate that the current Year is greater than zero; if it's not.
         //instance variable current Year keeps its prior value
         if (value > 0)
         {
            currentYear = value;
         }
      }
   }
   //Age property with validation
   public int perAge 
   {
      get
      {
         return age;
      }
      private set //can be used only within the class
      {
         //validate that the age is greater than 0; if it's not,
         //instance variable age keeps its prior value
         if (value > 0)
         {
            age = value;
         }
      }
   }
   //MaxHeartRate property with validation
   public double perMaxHeartRate
   {
      get
      {
         return maxHeartRate;
      }
      private set //can be used only within the class
      {
         //validate that the maxHeartRate is greater than 0; if it's not,
         //instance variable maxHeartRate keeps its prior value.
         if (maxHeartRate > 0)
         {
            maxHeartRate = (int)value;
         }
      }
   }
   //MinHighHeartRate property with validation
   public double perMinHighHeartRate
   {
      get
      {
         return minHighHeartRate;
      }
      private set //can be used only within the class
      {
         //validate that the minHighHeartRate is greater than 0; if it's not,
         //instance variable minHighHeartRate keeps its prior value.
         if (minHighHeartRate > 0)
         {
            minHighHeartRate = (int)value;
         }
      }
   }
   //MinLowHeartRate property with validation
   public double perMinLowHeartRate
   {
      get
      {
         return minLowHeartRate;
      }
      private set //can be used only within the class
      {
         //validate that the minLowHeartRate is greater than 0; if it's not,
         //instance variable minLowHeartRate keeps its prior value.
         if (minLowHeartRate > 0)
         {
            minLowHeartRate = (int)value;
         }
      }
   }

   //Method that subtracts the yearOfBirth from the currentYear to calculate the age of the person.  
   public void CalcAge()
   {
      if (perAge == 0)
      {
         age = perCurrentYear - perYearOfBirth;
      }
   }
   /* Method that contains three propertie computations
    * We use the value of two hundred and twenty subtracted by the age to calculate the maxHeartRate
    * We use the maxHeartRate mulitplied eighty divided by one-hundred to compute the minimum High Heart rate.
    * We use the maximum Heart Rate again to multiplied five divided by ten to generate the value for the minimum Low Heart rate. 
   */ 
   public void CalcHeartRates()
   {
      if (age > 0)
      {
         maxHeartRate = 220 - age;
         minHighHeartRate = maxHeartRate * 85/100;
         minLowHeartRate = maxHeartRate * 5/10;
      }
   }
}