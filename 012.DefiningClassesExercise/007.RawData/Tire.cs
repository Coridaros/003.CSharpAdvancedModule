public class Tire
{
    private int age;
    private double pressure;

    public int Age { get; set; }
    public double Pressure { get; set; }

    public Tire(int age, double pressure)
    {
        this.Age = age;
        this.Pressure = pressure;
    }
}