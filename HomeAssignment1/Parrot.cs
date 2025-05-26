namespace HomeAssignment1;

public class Parrot : Animal // derived class for parrots
{
    protected string color; // unique class field for parrots
    
    public Parrot(string parrotName, int parrotAge, string parrotSpecies, bool isParrotDomestic, string parrotColor) 
        : base(parrotName, parrotAge, parrotSpecies, isParrotDomestic) // constructor that inherits everything from the base class except color
    {
        color = parrotColor; 
    }
    
    public void ParrotSound() // method that prints out the sound that a particular parrot makes
    {
        Console.WriteLine($"{name}: Chirp!");
    }

    public bool CanTalk() // method that returns the value of isDomestic and determines if a parrot talks or not
    {
        return isDomestic;
    }
}