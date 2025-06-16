//Defining classes - exercise, Task 006
//15.06.2025, 01:02


public class StartUp
{
    static void Main()
    {
        List<Car> cars = new List<Car>();

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string model = input[0];
            double fuel = double.Parse(input[1]);
            double fuelPerKm = double.Parse(input[2]);

            Car car = new Car(model, fuel, fuelPerKm);

            cars.Add(car);
        }

        while(true)
        {
            string command = Console.ReadLine();

            if(command == "End")
            {
                break;
            }

            string model = command.Split()[1];
            double distance = double.Parse(command.Split()[2]);

            foreach(var item in cars)
            {
                if(item.Model == model)
                {
                    item.Drive(model, distance);
                }
            }
        }

        foreach(var item in cars)
        {
            Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.Travelleddistance}");
        }
    }
}