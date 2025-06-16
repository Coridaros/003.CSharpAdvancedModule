public class Engine
{
    private int speed; // възможна грешка -> int || double
    private int power;

    public int Speed { get; set; }
    public int Power { get; set; }

    public Engine(int speed, int power)
    {
        this.Speed = speed;
        this.Power = power;
    }
}