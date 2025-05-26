namespace HomeAssignment1;

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("Whiskers", 3, "Cat", true);
        cat.ShowNameAndAge();
        cat.CatSound();
        Console.WriteLine();

        Dog dog = new Dog("Bolt", 5, "Dog", true);
        dog.ShowNameAndAge();
        dog.DogSound();
        Console.WriteLine();

        Parrot firstParrot = new Parrot("Spike", 2, "Parrot", true, "Green");
        firstParrot.ShowNameAndAge();
        firstParrot.ParrotSound();
        Console.WriteLine($"Talks? {firstParrot.CanTalk()}");
        Console.WriteLine();

        Parrot secondParrot = new Parrot("Rio", 4, "Parrot", false, "Blue");
        secondParrot.ShowNameAndAge();
        secondParrot.ParrotSound();
        Console.WriteLine($"Talks? {secondParrot.CanTalk()}");
    }
}