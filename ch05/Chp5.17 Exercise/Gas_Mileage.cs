using System.Security.Cryptography.X509Certificates;

internal class Gas_Mileage
{
   //Initialization phase
   public int   miles_Driven;    // instance variable
   public int   gallons;         // instance variable
   public int   tankCounters;    // instance variable
   public float averageMiles_Driven; // instance variable
   public float averageGallons;      // instance variable

      //Gas Mileage constructor that receives the parameters
      public Gas_Mileage(int perMiles_Driven, int perGallons, int perTankCounters, float perAvgMiles_Driven, float perAvgGallons)
      {
         miles_Driven = perMiles_Driven;
         gallons = perGallons;
         tankCounters = perTankCounters;
         averageMiles_Driven = perAvgMiles_Driven;
         averageGallons = perAvgGallons;
      }

   //Miles driven property
   public int perMiles_Driven
   {
      get
      {
         return miles_Driven;
      }
      private set //can be used only within the class
      {
         miles_Driven = value;
      }
   }
   //Gallons used property
   public int perGallons
   {
      get
      {
         return gallons;
      }
      private set //can be used only within the class
      {
         gallons = value;
      }
   }
   //Tank counters property
   public int perTankCounter
   {
      get
      {
         return tankCounters;
      }
      private set //can be used only within the class
      {
         tankCounters = value; 
      }
   }
   //Average Miles Driven property
   public float perAverageMilesDriven
   {
      get
      {
         return averageMiles_Driven;
      }
      private set //can be used only within the class
      {
         averageMiles_Driven = value;
      }
   }
   //Average Gallons property
   public float perAverageGallons
   {
      get
      {
         return averageGallons;
      }
      private set //can be used only within the class
      {
         averageGallons = value;
      }
   }

   /*Method that creates a while statement to iterate 10 times
   *Which will capture the Miles Driven from person #
   *The result one will be added to perMiles_Driven as the total Miles driven
   *Which will capture the Gallons from person #
   *The result two will be added to perGallons as the total Gallons consumed
   *After the While statement terminates
   *Calculate the Average for average miles driven how it is performed miles driven divided by perTankCounter
   *Calculate the Average for average gallons consumed how it is performed gallons divided by perTankCounter
   *Console.Write display of total of the results for average miles driven
   *Console.Write display of total of the results 2 for gallons consumed
   */
   public void CalculateMilesGallon()
   {
      //Processing phase
      // process 2 Tanks using counter-controlled iteration
      while (perTankCounter <= 2)
      {
         //prompt user for input and obtain a value from the user
         Console.Write("Enter the Miles Driven: ");
         int result = int.Parse(Console.ReadLine());

         //Adding the result of the miles driven user inputted to the miles driven.
         perMiles_Driven += result;

         //prompt user for input and obtain a value from the user
         Console.Write("Enter the Gallons consumed: ");
         int result2 = int.Parse(Console.ReadLine());

         //Adding the result of the miles driven recorded by the user input to the miles driven.
          perGallons += result2;

         // increment perTankCounter so loop eventually terminates
         ++perTankCounter;
      }
      
      averageMiles_Driven = perMiles_Driven / perTankCounter;
      averageGallons = perGallons / perTankCounter;

      //Termination phase; prepare and display results
      Console.WriteLine($"The total Miles Driven {perMiles_Driven:N}."+
                        $"\nThe total Gallons Consumed {perGallons:N}.");
      Console.WriteLine($"The average Miles Driven {perAverageMilesDriven:N}." +
                        $"\nThe average Gallons Consumed {perAverageGallons:N}.\n");
   } //End Method CalculateMilesGallon
} //End class Gas Milage
