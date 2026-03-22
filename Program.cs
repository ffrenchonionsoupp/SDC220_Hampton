/*****************************
* Name: Francis Hampton
* Date: 3/21/2026
* Assignment: SDC220 Week 3 PA - Calculations and Unique Numbers
*
* Main application (program) class.
* This program collects ten integer values from the user and stores them in an array.
* As the values are entered, the program identifies and stores only the unique integers
* in a List using the List.Contains method to prevent duplicates.
*/
using System.Collections.Generic;

public class UniqueNumbersCalc
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nFrancis Hampton - Week 3 PA Calculations & Unique Numbers\n");

        // Create an array to hold 10 integers
        int[] numbersArr = new int[10];

        // Create a List to hold only the unique values
        List<int> uniqueList = new List<int>();

        // Loop to gather 10 values from the user
        for (int i = 0; i < numbersArr.Length; i++)
        {
            Console.Write("Please enter an integer value: ");
            string? val = Console.ReadLine();
            int num = Convert.ToInt32(val);

            numbersArr[i] = num;

            // Add to List only if unique
            if (!uniqueList.Contains(num))
            {
                uniqueList.Add(num);
            }
        }

        // Display results for the array
        Console.WriteLine("\n");
        DisplayCollectionInfo(numbersArr);

        // Display results for the List
        Console.WriteLine("\n");
        DisplayCollectionInfo(uniqueList);
    }

    // Method to display count, sum, and average for an array
    public static void DisplayCollectionInfo(int[] arr)
    {
        int total = Sum(arr);
        Console.WriteLine("The count of integers entered is: {0}", arr.Length);
        Console.WriteLine("The sum of integers entered is: {0}", total);
        Console.WriteLine("The average of integers entered is: {0:F2}", (double)total / arr.Length);
    }

    // Overloaded method to display count, sum, and average for a List
    public static void DisplayCollectionInfo(List<int> list)
    {
        int total = Sum(list);
        Console.WriteLine("The count of unique integers entered is: {0}", list.Count);
        Console.WriteLine("The sum of unique integers entered is: {0}", total);
        Console.WriteLine("The average of unique integers entered is: {0:F2}", (double)total / list.Count);
    }

    // Method to calculate the sum of an array
    public static int Sum(int[] arr)
    {
        int total = 0;

        foreach (int n in arr)
        {
            total += n;
        }

        return total;
    }

    // Overloaded method to calculate the sum of a List
    public static int Sum(List<int> list)
    {
        int total = 0;

        foreach (int n in list)
        {
            total += n;
        }

        return total;
    }
}