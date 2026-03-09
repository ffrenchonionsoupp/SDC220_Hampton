/*******************************************************************
* Name: Francis Hampton
* Date: 3/8/26
* Assignment SDC220 Week 1 PA - Employee Class
*
* Employee class.
* This class demonstrates the use of constructors, class methods, and class
* properties.
*/
public class Employee
{
    // Class properities - in C#, there is no need no need to declare a sparate,
    // private instance variable - creating the get and set on the property
    // implies private instance variables

    // Name is a fully-accessible property; values may be read and updated
    // directly
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Make Salary a read-only property - values may be read but cannot be 
    // Written to the property other than by class functions
    public double Salary { get; private set; }

    // Constructor takes 3 parameters to set the instance variables
    public Employee(string firstname, string lastname, double salary)
    {
        FirstName = firstname;
        LastName = lastname;

        // Validate the salary provided - if it is greater than 1000,
        // set the instance variable to the value provided; otherwise
        // leave the instance variable as the default 1000.0
        if (salary > 1000.0)
        {
            Salary = salary;
        }
    }

    // Method to update the salary amount, if it is valid
    public void Update(double amount)
    {
        if (amount > 1000.0)
        {
            Salary = Salary + amount;
        }
    }
}
