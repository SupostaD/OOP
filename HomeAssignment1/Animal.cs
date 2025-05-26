namespace HomeAssignment1;

public class Animal // parent class for all types of animals
{
    protected string name; // common class fields
    protected int age;
    protected string species;
    protected bool isDomestic;

    public Animal(string animalName, int animalAge, string animalSpecies, bool isAnimalDomestic) // constructor
    {
        name = animalName;
        age = animalAge;
        species = animalSpecies;
        isDomestic = isAnimalDomestic;
    }

    public void ShowNameAndAge() // method that prints animal name and its age
    {
        Console.WriteLine($"The animal's name is {name} and it's {age} years old.");
    }
}