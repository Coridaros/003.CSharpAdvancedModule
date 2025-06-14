//Defining classes - lab, Task 004
//13.06.2025, 00:36

namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        Tire[] tires = new Tire[4]
        {
            new Tire(2010, 2.5),
            new Tire(2010, 2.4),
            new Tire(2010, 2.5),
            new Tire(2010, 2.4)
        };

        Engine engine = new Engine(105, 1900);

        Car carGolf = new Car("VW", "Golf 5", 2004, 55, 4, engine, tires);

        Console.WriteLine(carGolf.Tires[0].Year);
    }
}