//Defining classes - lab, Task 003
//13.06.2025, 00:29

using System.Collections.Generic;

namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        Car firstCar = new Car();
        Car secondCar = new Car("Honda", "Sivic", 2003);
        Car thirdCar = new Car("VW", "Golf", 2004, 55, 4);

        Console.WriteLine(firstCar.WhoAmI());
        Console.WriteLine();
        Console.WriteLine(secondCar.WhoAmI());
        Console.WriteLine();
        Console.WriteLine(thirdCar.WhoAmI());
    }
}