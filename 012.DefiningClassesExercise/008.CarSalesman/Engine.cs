public class Engine
{
    private string model;
    private int power;
    private int discplacement;
    private string efficiency;

    public string Model { get; set; }
    public int Power { get; set; }
    public int Discplacement { get; set; }
    private string Efficiency { get; set; }

    public Engine(string model, int power)
    {
        this.Model = model;
        this.Power = power;
    }
}