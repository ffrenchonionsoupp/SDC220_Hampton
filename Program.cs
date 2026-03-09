/*******************************************************************
* Name: Francis Hampton
* Date: 3/8/26
* Assignment SDC220 Week 1 PA - Employee Class
* 
* Main application (program) class.
* This class demonstrates the use of constructors, class methods, and class
* properties.
*/
public class EmployeeTest
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("\nFrancis - Week 1 PA Classes\n");

        // Create 2 instances of the Employee class
        Employee emp1 = new Employee("Jane", "Green", 1234);
        Employee emp2 = new Employee("John", "Blue", 567);

        // Display the initial monthly salaries of each account
        Console.WriteLine("Initial information for each employee");
        Console.WriteLine("Name: {0} {1} \nMonthly Salary: ${2:F2}\n", emp1.FirstName,
            emp1.LastName, emp1.Salary);
        Console.WriteLine("Name: {0} {1} \nMonthly Salary: ${2:F2}\n", emp2.FirstName,
            emp2.LastName, emp2.Salary);

        // Update information
        emp1.FirstName = "Janey";
        emp1.Update(4000);

        emp2.LastName  = "Smith";
        emp2.Update(1500);


        // Display the initial monthly salaries of each account
        Console.WriteLine("Updated information for each employee");
        Console.WriteLine("Name: {0} {1} \nMonthly Salary: ${2:F2}\n", emp1.FirstName,
            emp1.LastName, emp1.Salary);
        Console.WriteLine("Name: {0} {1} \nMonthly Salary: ${2:F2}\n", emp2.FirstName,
            emp2.LastName, emp2.Salary);
    }
}
