namespace HomeAssignment3;

public class Enemy
{
    private string name;
    private Player player;

    public Enemy(string Name, Player Player)
    {
        name = Name;
        player = Player;
    }

    public void Attack(float damageAmount) // method that applies damage to the player
    {
        player.TakeDamage(damageAmount); 
    }

    public void PlayVictoryAnimation() // method that plays victory animation of the enemy
    {
        Console.WriteLine($"{name} plays a victory animation!");
    }
}