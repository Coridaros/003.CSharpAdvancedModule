namespace CarManufacturer;

public class Car
{
	private string make;
	private string model;
	private int year;
	private double fuelQuantity;
	private double fuelConsumption;

    #region gets and sets
    public string Make
	{
		get { return make; }
		set { make = value; }
	}
	public string Model
	{
		get { return model; }
		set { model = value; }
	}
	public int Year
	{
		get { return year; }
		set { year = value; }
	}
	public double FuelQuantity
	{
		get { return fuelQuantity; }
		set { fuelQuantity = value; }
	}
	public double FuelConsumption
    {
		get { return fuelConsumption; }
		set { fuelConsumption = value; }
	}
    #endregion

	public void Drive(double distance)
	{
        //if(fuelQuantity >= (distance * (fuelConsumation / 100.0)))
        //{
        //	fuelQuantity -= (distance * (fuelConsumation / 100.0));
        //      }
        //else
        //{
        //          Console.WriteLine("Not enough fuel to perform this trip!");
        //}

        bool canContinue = this.FuelQuantity - (distance * (this.FuelConsumption / 100)) >= 0;
        if (canContinue)
            this.FuelQuantity -= distance * (this.FuelConsumption / 100);
        else
            Console.WriteLine("Not enough fuel to perform this trip!");
    }

	public string WhoAmI()
	{
		string result = $"Make: {this.make}\r\nModel: {this.model}\r\nYear: {this.year}\r\nFuel: {this.fuelQuantity:F2}L";

		return result;
	}
}