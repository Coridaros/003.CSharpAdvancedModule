namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        Car car = new Car();

        car.Make = "VW";
        car.Model = "Golf 5";
        car.Year = 2004;
        car.FuelQuantity = 55;
        car.FuelConsumption = 14;

        Console.WriteLine(car.WhoAmI());
        Console.WriteLine();

        car.Drive(178);
        car.Drive(200);
        car.Drive(200);
        car.Drive(200);

        Console.WriteLine(car.WhoAmI());
        Console.WriteLine();
    }
}
