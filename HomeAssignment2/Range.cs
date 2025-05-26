namespace HomeAssignment2;

public class Range : Enemy
{
    private const int damage = 5;
    
    public override void Attack(Player player)
    {
        Console.WriteLine("Try to range attack");
        int result = random.Next(1, 101);
        if (result <= 50)
        {
            Console.WriteLine("Range attack succeeded");
            player.health -= damage;
            Console.WriteLine($"Player health is now {player.health}.");
        } else Console.WriteLine("The range attack didn't succeed");
    }
}