namespace HomeAssignment3;

public class UI
{
    public void OnHealthChanged(float newHealth, string reason) // method that prints out UI message
    {
        Console.WriteLine($"UI: Player's health is now {newHealth}. Reason: {reason}");
    }
}