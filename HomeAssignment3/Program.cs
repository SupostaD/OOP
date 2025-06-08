namespace HomeAssignment3;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(100f);
        UI ui = new UI();

        player.OnHealthChanged += ui.OnHealthChanged; // subscribing the UI method to the Player event

        Enemy enemy1 = new Enemy("Goblin", player);
        Enemy enemy2 = new Enemy("Orc", player);
        Enemy enemy3 = new Enemy("Skeleton", player);

        player.OnPlayerDied += enemy1.PlayVictoryAnimation; // subscribing the Enemy method to the Player event for each Enemy class instance
        player.OnPlayerDied += enemy2.PlayVictoryAnimation;
        player.OnPlayerDied += enemy3.PlayVictoryAnimation;

        player.Heal(30f);
        enemy1.Attack(10f);
        player.Heal(20f);
        enemy2.Attack(30f);
        player.Heal(5f);
        enemy3.Attack(90);
        player.Heal(30f);

    }
}