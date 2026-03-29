/*****************************
* Name: Francis Hampton
* Date: 3/29/2026
* Assignment: Week 4 PA - Account Balance Calculations
*
* Main application (program) class.
* This program prompts the user for a starting balance and then repeatedly
* asks for credit or debit amounts. If the debit would cause the balance
* to go negative, a user-defined exception is thrown. If the user enters
* a non-numeric value, a FormatException is handled. The program continues
* until the user enters 0 to quit.
*/

public class AccountBalanceProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Francis Hampton - Week 4 PA Account Balance Calculations\n");

        double balance = 0;
        bool cont = true;   // loop control variable

        // Get starting balance
        Console.Write("Please enter the starting balance: ");
        try
        {
            string? start = Console.ReadLine();
            balance = Convert.ToDouble(start);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e);
            Console.WriteLine("Please enter a numeric value.");
            return; // cannot continue without a valid starting balance
        }

        // Loop for credits or debits
        while (cont)
        {
            try
            {
                Console.Write("Please enter a credit or debit amount (0 to quit): ");
                string? val = Console.ReadLine();
                double amount = Convert.ToDouble(val);   // might throw FormatException

                if (amount == 0)
                {
                    Console.WriteLine($"\nThe updated balance is: {balance:F2}");
                    cont = false;
                    break;
                }

                // If debit would cause negative balance
                if (balance + amount < 0)
                {
                    throw new Exception("Amount entered will cause account to be negative.");
                }

                // Valid update
                balance += amount;
                Console.WriteLine($"\nThe updated balance is: {balance:F2}\n");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Please enter a numeric value.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine();
            }
        }
    }
}
