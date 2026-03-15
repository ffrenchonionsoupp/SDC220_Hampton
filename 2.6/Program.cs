/***********************************************************
 * Name: Francis Hampton
 * Date: 3/15/2026
 * Assignment SDC220 Week 2 PA - Smallest Number
 * 
 * Main application (program) class.
 * In this application we will find the smallest value from a set
 * of integers entered by the user.
 */
public class SmallestNumber
{
    static void Main(string[] args)
    {
        //Print a header line
        Console.WriteLine("\nFrancis Hampton - Week 2 PA Smallest Number\n");

        Console.WriteLine("Finding the Smallest Value:");
        Console.Write("How many integers would you like to enter: ");

        string? val = Console.ReadLine();
        int count = Convert.ToInt32(val);

        //note: read the first value to initialize the smallest value
        Console.Write("Enter an integer value: ");
        val = Console.ReadLine();
        int smallest = Convert.ToInt32(val);

        //note: loop for the remaining values
        for (int i = 1; i < count; i++)
        {
            Console.Write("Enter an integer value: ");
            val = Console.ReadLine();
            int current = Convert.ToInt32(val);

            if (current < smallest)
            {
                smallest = current;
            }
        }

        Console.WriteLine("The smallest value entered is: {0}", smallest);
    }
}
