// See https://aka.ms/new-console-template for more information

//Ex. 5.16: Mystery.cs
class Mystery
{
    static void Main()
    {
        //Initialization phase
        int x = 1; //initialize value of x to 1
        int total = 0; //initialize total as the value of zero
        
        //Processing phase
        // loop until x is bigger than 10
        while (x <= 10)
        {
            int y = x * x; //initialize y to be x times x
            Console.WriteLine(y); //print to the console the value of y
            total += y; //Add or overwrite the value of total with the value of y
            ++x; //increment the value of x by 1
        }

        //Termination phase
        Console.WriteLine($"Total is {total:N}");
    } //End of the Main Method
} //End the class Mystery