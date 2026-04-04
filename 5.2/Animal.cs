/*
 * Name: Francis Hampton
 * Date: 4/3/2026
 * Assignment: SDC220 Performance Assessment - Inheritance & Overriding
 *
 * Animal class.
 * This is the base class that provides generic information shared by all
 * animals. Each animal has a name and a number of legs. The PrintAnimal
 * function prints this information to the console.
 */

public class Animal
{
    // Properties
    public string Name { get; set; }
    public int Legs { get; set; }

    // Constructor
    public Animal(string name, int legs)
    {
        Name = name;
        Legs = legs;
    }

    // Virtual function so derived classes can override it
    public virtual void PrintAnimal()
    {
        Console.WriteLine(
            "The Animal's name is {0} and it has {1} legs.",
            Name, Legs);
    }
}