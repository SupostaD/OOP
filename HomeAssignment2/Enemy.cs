namespace HomeAssignment2;

public abstract class Enemy
{
    protected static Random random = new Random(); // object of a random class that will be used in derived classes
    public abstract void Attack(Player player); // abstract method that will be implemented in derived classes
}