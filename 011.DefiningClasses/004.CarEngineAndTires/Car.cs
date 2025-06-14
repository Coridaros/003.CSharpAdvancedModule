//using System;

//namespace CarManufacturer;

//public class Car
//{
//    private string make;
//    private string model;
//    private int year;
//    private double fuelQuantity;
//    private double fuelConsumption;
//    private Engine engine;
//    private Tire[] tires;

//    #region gets and sets
//    public string Make
//    {
//        get { return make; }
//        set { make = value; }
//    }
//    public string Model
//    {
//        get { return model; }
//        set { model = value; }
//    }
//    public int Year
//    {
//        get { return year; }
//        set { year = value; }
//    }
//    public double FuelQuantity
//    {
//        get { return fuelQuantity; }
//        set { fuelQuantity = value; }
//    }
//    public double FuelConsumption
//    {
//        get { return fuelConsumption; }
//        set { fuelConsumption = value; }
//    }
//    public Engine Engine
//    {
//        get { return engine; }
//        set { engine = value; }
//    }
//    public Tire[] Tires
//    {
//        get { return tires; }
//        set { tires = value; }
//    }
//    #endregion

//    #region constructors
//    public Car()
//    {
//        this.make = "VW";
//        this.model = "Golf";
//        this.Year = 2025;
//        this.FuelQuantity = 200;
//        this.FuelConsumption = 10;
//    }

//    public Car(string make, string model, int year) : this()
//    {
//        this.make = make;
//        this.model = model;
//        this.year = year;
//    }

//    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
//        : this(make, model, year)
//    {
//        this.fuelQuantity = fuelQuantity;
//        this.fuelConsumption = fuelConsumption;
//    }

//    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
//        Engine engine, Tire[] tires) : this (make, model, year, fuelQuantity, fuelConsumption)
//    {
//        this.Engine = engine;
//        this.Tires = tires;
//    }
//    #endregion

//    public void Drive(double distance)
//    {
//        bool canContinue = this.FuelQuantity - (distance * (this.FuelConsumption / 100)) >= 0;
//        if (canContinue)
//            this.FuelQuantity -= distance * (this.FuelConsumption / 100);
//        else
//            Console.WriteLine("Not enough fuel to perform this trip!");
//    }

//    public string WhoAmI()
//    {
//        string result = $"Make: {this.make}\r\nModel: {this.model}\r\nYear: {this.year}\r\nFuel: {this.fuelQuantity:F2}L";

//        return result;
//    }
//}

using System;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
            Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            double fuel = FuelQuantity - (distance * FuelConsumption);

            if (fuel < 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }
            else
            {
                FuelQuantity = fuel;
                Console.WriteLine($"You have {FuelQuantity:f2} left in the tank.");
            }
        }

        public void WhoAmI()
        {
            Console.WriteLine($"Make: {this.Make} " +
                $"\r\nModel: {this.Model} " +
                $"\r\nYear: {this.Year}" +
                $"\r\nFuel: {this.FuelQuantity:f2}");
        }
    }
}