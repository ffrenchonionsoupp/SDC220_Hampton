/*
 * Name: Francis Hampton
 * Date: 4/3/2026
 * Assignment: SDC220 Performance Assessment - Inheritance & Overriding
 *
 * Cat class.
 * This class is derived from Animal and adds the unique property "Sound".
 * The PrintAnimal function is overridden to include the sound the cat makes.
 */

public class Cat : Animal
{
    // Additional property
    public string Sound { get; set; }

    // Constructor
    public Cat(string name, int legs, string sound) : base(name, legs)
    {
        Sound = sound;
    }

    // Override of the base class function
    public override void PrintAnimal()
    {
        Console.WriteLine(
            "The Cat's name is {0}, it has {1} legs and is making a {2} sound.",
            Name, Legs, Sound);
    }
}