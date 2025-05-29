namespace HomeAssignment2;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(100);
        Enemy knight = new Melee();
        Enemy archer = new Range();
        Enemy bomberman = new Bomb(); // creating new object classes with polymorphism
        
        knight.Attack(player);
        Console.WriteLine();
        
        archer.Attack(player);
        Console.WriteLine();
        
        bomberman.Attack(player); // taking turns in attacking with different overrides
    }
}