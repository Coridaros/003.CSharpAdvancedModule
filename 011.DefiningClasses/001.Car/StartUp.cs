using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        Car golf = new Car();

        golf.Make = "VW";
        golf.Model = "Golf 5";
        golf.Year = 2004;

        Console.WriteLine($"Make: {golf.Make} \r\nModel: {golf.Model} \r\nYear: {golf.Year}");
    }
}
