public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private List<Tire> tires;

    public string Model { get => model; set => model = value; }
    public Engine Engine { get => engine; set => engine = value; }
    public Cargo Cargo { get => cargo; set => cargo = value; }
    public List<Tire> Tires { get => tires; set => tires = value; }

    public Car(string model, Engine eng, Cargo carg, List<Tire> tr)
    {
        this.Model = model;
        this.Engine = eng;
        this.Cargo = carg;
        this.Tires = tr; // !
    }
}