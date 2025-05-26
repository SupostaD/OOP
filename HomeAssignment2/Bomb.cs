namespace HomeAssignment2;

public class Bomb : Enemy
{
    private const int damage = 50;
    
    public override void Attack(Player player)
    {
        Console.WriteLine("Try to bomb attack");
        Console.WriteLine("Bomb attack succeeded");
        player.health -= damage;
        Console.WriteLine($"Player health is now {player.health}.");
    }
}