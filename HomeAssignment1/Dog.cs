namespace HomeAssignment1;

public class Dog : Animal // derived class for dogs
{
    public Dog(string dogName, int dogAge, string dogSpecies, bool isDogDomestic) 
        : base(dogName, dogAge, dogSpecies, isDogDomestic){} // constructor inherited from the base class

    public void DogSound() // method that prints out the sound that a particular dog makes
    {
        Console.WriteLine($"{name}: Bark!");
    }
}