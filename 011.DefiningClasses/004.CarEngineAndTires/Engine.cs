//using System;

//namespace CarManufacturer;

//public class Engine
//{
//    private int hoursePower;
//    private double cubicCapacity;

//    public int HoursePower
//    {
//        get { return hoursePower; }
//        set { hoursePower = value; }
//    }

//    public double CubicCapacity
//    {
//        get { return cubicCapacity; }
//        set { cubicCapacity = value; }
//    }

//    public Engine(int hoursePower, double cubicCapacity)
//    {
//        this.hoursePower = hoursePower;
//        this.cubicCapacity = cubicCapacity;
//    }
//}

using System;

namespace CarManufacturer
{
    public class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        private int horsePower;
        private double cubicCapacity;

        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
    }
}