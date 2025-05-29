namespace HomeAssignment2;

public class Melee : Enemy
{
    private const int damage = 20; 
    
    public override void Attack(Player player) // override of attack method for melee class
    {
        Console.WriteLine("Try to melee attack");
        int result = random.Next(1, 101); 
        if (result <= 20) // implementing random for a chance to hit
        {
            Console.WriteLine("Melee attack succeeded");
            player.health -= damage; 
            Console.WriteLine($"Player health is now {player.health}.");
        } else Console.WriteLine("The melee attack didn't succeed");
    }
}