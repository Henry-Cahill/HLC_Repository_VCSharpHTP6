internal class HealthProfile
{
   //date of birth, (consisting of separate attributes for the month, day and year of birth),

   public string first_Name;       //instance variable
   public string last_Name;        //instance variable
   public string gender;           //instance variable
   public int age;              //instance variable
   public int currentYear;      //instance variable
   public int heightInInches;   //instance variable
   public int weightInPounds;   //instance variable
   public int month { get; set; } //auto-implmented property
   public int day { get; set; } //auto-implmented property
   public int year { get; set; } //auto-implmented property
   private int maxHeartRate;     //instance variable
   private double minHighHeartRate; //instance variable
   private double minLowHeartRate;  //instance variable
   private double bMI;              //instance variable
   

   //HeartProfile constructor that receives the  parameters.
   public HealthProfile(string perFirst_Name, string perLast_Name,
                        int perAge, string perGender, int perCurrentYear,
                        int perMaxHeartRate, double perMinHighHeartRate, double perMinLowHeartRate,
                        int perHeightInInches, int perWeightInPounds, double perBMI, int inputMonth, int inputDay, int inputYear)
   {
      first_Name = perFirst_Name;
      last_Name = perLast_Name;
      currentYear = perCurrentYear;
      age = perAge;
      month = inputMonth;
      day = inputDay;
      year = inputYear;
      gender = perGender;
      maxHeartRate = perMaxHeartRate;
      minHighHeartRate = perMinHighHeartRate;
      minLowHeartRate = perMinLowHeartRate;
      heightInInches = perHeightInInches;
      weightInPounds = perWeightInPounds;
      bMI = perBMI;
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
   public int perCurrentYear
   {
      get
      {
         return currentYear;
      }
      private set // can be used only within the class
      {
         //validate that the current year is greater than 0; if it's not.
         //instance variable current year keeps its prior value
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
   //Gender property
   public string perGender
   {
      get
      {
         return gender;
      }
      private set //can be used only within the class
      {
         gender = value;
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

   public int perHeightInInches
   {
      get
      {
         return heightInInches;
      }
      private set //can be used only within the class
      {
         //validate that the heightInInches is greater than 0; if it's not,
         //instance variable heightInInches keeps its prior value.
         if (heightInInches > 0)
         {
            heightInInches = value;
         }
      }

   }

   public int perWeightInPounds
   {
      get
      {
         return weightInPounds;
      }
      private set //can be used only within the class
      {
         //validate that the weightInPounds is greater than 0; if it's not,
         //instance variable wieghtInPounds keeps its prior value.
         if (weightInPounds > 0)
         {
            weightInPounds = value;
         }
      }
   }

   public double perBMI
   {
      get
      {
         return bMI;
      }
      private set //can be used only within the class
      {
         //validate that the bMI is greater than 0; if it's not,
         //instance variable bMI keeps its prior value.
         if (bMI > 0)
         {
            bMI = value;
         }
      }
   }

   /*
   * Method that subtracts the yearOfBirth from the currentYear to calculate the age of the person.
   */
   public void CalcAge()
   {
      if (perAge == 0)
      {
         age = perCurrentYear - year;
      }
   }
   /* 
    * Method that contains three properties computations for the Heart Rate
    * We use the value of two hundred and twenty subtracted by the age to calculate the maxHeartRate
    * We use the maxHeartRate mulitplied eighty divided by one-hundred to compute the minimum High Heart rate.
    * We use the maximum Heart Rate again to multiplied five divided by ten to generate the value for the minimum Low Heart rate. 
   */
   public void CalcHeartRates()
   {
      if (age > 0)
      {
         maxHeartRate = 220 - age;
         minHighHeartRate = maxHeartRate * 85 / 100;
         minLowHeartRate = maxHeartRate * 5 / 10;
      }
   }
   /*
    * Method that contains the computation for BMI
   */
   public void CalcBMI()
   {
      if ((heightInInches > 0) && (weightInPounds > 0))
      {
         bMI = (weightInPounds * 703) / (heightInInches * heightInInches);
      }
   }
   /*
    * Method that adds the Month, Day, and Year together to form a date syntax MM/DD/YYYY
   */
   public void DisplayDate()
   {
      if (month > 0 || month < 12 && day > 0 || day < 31 && year > 0)
      {
         Console.WriteLine($"{month}/{day}/{year}");
      }
   }
}

