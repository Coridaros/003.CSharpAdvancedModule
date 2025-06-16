public class Cargo
{
    private string type;
    private int weigth;

    public string Type { get; set; }
    public int Weight { get; set; }

    public Cargo(string type, int weight)
    {
        this.Type = type;
        this.Weight = weight;
    }
}