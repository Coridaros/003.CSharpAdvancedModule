public class Car
{
    private string model;
    private Engine engine;
    private int weight;
    private string color;

    public string Model { get; set; }
    public Engine Engine { get; set; }
    public int Weigth { get; set; }
    public string Color { get; set; }

    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}