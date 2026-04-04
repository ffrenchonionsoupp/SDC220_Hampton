/*
 * Name: Francis Hampton
 * Date: 4/3/2026
 * Assignment: SDC220 Performance Assessment - Inheritance & Overriding
 *
 * Main application class.
 * This program demonstrates inheritance and overriding by creating
 * Animal and Cat objects, printing their properties, updating them,
 * and printing them again.
 */

public class Program
{
    static void Main(string[] args)
    {
        // Header line
        Console.WriteLine("Francis Hampton - Week 5 PA - Inheritance & Overriding\n");

        // Instantiate objects
        Animal a1 = new Animal("Roo", 2);
        Cat c1 = new Cat("Fluffy", 4, "meow");

        Animal a2 = new Animal("Flipper", 0);
        Cat c2 = new Cat("Garfield", 4, "I'm HUNGRY");

        // Print original values
        a1.PrintAnimal();
        c1.PrintAnimal();
        a2.PrintAnimal();
        c2.PrintAnimal();

        Console.WriteLine();

        // Update values
        a1.Name = "Updated Roo";
        a1.Legs = 3;

        c1.Name = "Updated Fluffy";
        c1.Legs = 4;
        c1.Sound = "purr";

        a2.Name = "Updated Flipper";
        a2.Legs = 0;

        c2.Name = "Updated Garfield";
        c2.Legs = 4;
        c2.Sound = "FEED ME";

        // Print updated values
        a1.PrintAnimal();
        c1.PrintAnimal();
        a2.PrintAnimal();
        c2.PrintAnimal();
    }
}