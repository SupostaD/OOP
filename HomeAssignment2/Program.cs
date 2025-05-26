namespace HomeAssignment2;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(100);
        Enemy knight = new Melee();
        Enemy archer = new Range();
        Enemy bomberman = new Bomb();
        
        knight.Attack(player);
        Console.WriteLine();
        
        archer.Attack(player);
        Console.WriteLine();
        
        bomberman.Attack(player);
    }
}