public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionPerKilometer;
    private double travelleddistance;

    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKilometer;
    public double Travelleddistance { get; set; } // тук може да даде грешка...

    public Car(string model, double fuelAmount, double consumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumptionPerKilometer = consumption;
        this.Travelleddistance = 0.0;
    }

    public void Drive(string carModel, double kilometers)
    {
        bool canContinue = this.FuelAmount - (kilometers * (this.FuelConsumptionPerKilometer)) >= 0;

        if (canContinue)
        {
            this.FuelAmount -= kilometers * (this.FuelConsumptionPerKilometer);
            this.Travelleddistance += kilometers;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}