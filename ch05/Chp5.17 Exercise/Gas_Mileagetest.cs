// See https://aka.ms/new-console-template for more information
/*
 *For Exercises 5.17, perform each of the following steps.
 *a) Read the problem statement.
 *b) Formulate the algorithm using pseudocode and top-down, stepwise refinement.
 *c) Write a C# app.
 *d) Test, debug and execute the C# app.
 *e) Process three complete sets of data
*/
/*
 * (Gas Mileage)
 * Drivers are concerned with the mileage their automobiles get. One driver has kept track of several tankful of 
 * gasoline by recording the miles driven and gallons used for each tankful. Develop a C# app that will input the miles 
 * driven and gallons used (both as integers) for each tankful. The app should calculate and display the miles per
 * gallon obtained for each tankful up to this point. All averaging calculations should produce floating-point results.
 * Display the results rounded to the nearest hundredth. Use Console class's ReadLine method and sentinel-controlled
 * iteration to obtain the data from the user.
*/

using System;

class Gas_MileageTest
{
    static void DisplayMilesGallonsMP(Gas_Mileage personToDisplay) 
    {
      personToDisplay.CalculateMilesGallon();
    } //End the DisplayMilesGallonMP method
    static void Main()
    {
      Gas_Mileage person1 = new Gas_Mileage(0, 0, 0, 0, 0);
      Gas_Mileage person2 = new Gas_Mileage(0, 0, 0, 0, 0);
      Gas_Mileage person3 = new Gas_Mileage(0, 0, 0, 0, 0);

      DisplayMilesGallonsMP(person1);
      DisplayMilesGallonsMP(person2);
      DisplayMilesGallonsMP(person3);

    }// End the Main Method
}//End the class Gas_MileageTest