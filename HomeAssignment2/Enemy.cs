namespace HomeAssignment2;

public abstract class Enemy
{
    protected static Random random = new Random();
    public abstract void Attack(Player player);
}