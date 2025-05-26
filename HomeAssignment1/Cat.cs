namespace HomeAssignment1;

public class Cat : Animal // derived class for cats
{
    public Cat(string catName, int catAge, string catSpecies, bool isCatDomestic) 
        : base(catName, catAge, catSpecies, isCatDomestic){} // constructor inherited from the base class

    public void CatSound() // method that prints out the sound that a particular cat makes
    {
        Console.WriteLine($"{name}: Meow!"); 
    }
}