//Defining classes - lab, Task 001
//12.06.2025, 23:24

namespace CarManufacturer;

public class Car
{
    private string make;
    private string model;
    private int year;

    public string Make
    {
        get
        { 
            return make; 
        }
        set
        {
            make = value;
        }
    }

    public string Model
    {
        get
        {
            return model;
        }
        set
        {
            model = value;
        }
    }

    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            year = value;
        }
    }
}
