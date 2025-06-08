namespace HomeAssignment3;

public delegate void HealthEvents(float newHealth, string reason);

public delegate void DeathEvents(); // separate delegates for separate arguments

public class Player
{
    private float health;
    private bool isPlayerDead;
    
    public event HealthEvents OnHealthChanged;
    public event DeathEvents OnPlayerDied;

    public Player(float setHealth) // constructor that limits the health from 0 to 100
    {
        if (setHealth > 100f)
            health = 100f;
        else if (setHealth < 0f)
            health = 0f;
        else health = setHealth;
    }

    public void Heal(float amount)
    {
        if (isPlayerDead) return; // dead can't heal

        if (health == 100f) // if health is 100 before healing, it won't change, so we don't invoke an event
        {
            Console.WriteLine($"Heal was useless, already at max health ({health}).");
        }
        else if (health + amount > 100f) // if health exceeds 100 after heal, we limit it to 100, invoke an event and print accordingly
        {
            health = 100f;
            OnHealthChanged?.Invoke(health, $"Healed for {amount} to max, health now is {health}.");
        } 
        else // normal heal + event
        {
            health += amount;
            OnHealthChanged?.Invoke(health, $"Healed for {amount}. Current health: {health}.");
        }
    }

    public void TakeDamage(float amount)
    {
        if (isPlayerDead) return;

        health -= amount;

        if (health < 0f) // limiting to 0 before invoking an event to not print negative health
            health = 0f;
        
        OnHealthChanged?.Invoke(health, $"Player was hit for {amount} damage.");
        
        if (health == 0f && !isPlayerDead) // double-checking the state of a player and then death event
        {
            isPlayerDead = true;
            OnPlayerDied?.Invoke(); 
        }
    }
}