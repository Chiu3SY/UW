using System;

public class TemperatureAlarm
{
    private double temperature;

    [TemperatureRange(5, 35)]
    public double Temperature
    {
        get { return temperature; }
        set
        {
            temperature = value;
            CheckTemperature();
        }
    }

    [Brand("BrandName")]
    public string Brand { get; set; }

    [Size(10)]
    public int Size { get; }

    public TemperatureAlarm(double temperature, string brand)
    {
        Temperature = temperature;
        Brand = brand;
        Size = 10;
    }

    private void CheckTemperature()
    {
        if (temperature > 35 || temperature < 5)
        {
            Console.WriteLine("Temperature alarm triggered!");
        }
    }
}

public class TemperatureRangeAttribute : Attribute
{
    public double MinTemperature { get; }
    public double MaxTemperature { get; }

    public TemperatureRangeAttribute(double minTemperature, double maxTemperature)
    {
        MinTemperature = minTemperature;
        MaxTemperature = maxTemperature;
    }
}

public class BrandAttribute : Attribute
{
    public string BrandName { get; }

    public BrandAttribute(string brandName)
    {
        BrandName = brandName;
    }
}

public class SizeAttribute : Attribute
{
    public int Size { get; }

    public SizeAttribute(int size)
    {
        Size = size;
    }
}

public class Program
{
    public static void Main()
    {
        TemperatureAlarm alarm = new TemperatureAlarm(40, "MyBrand");
        Console.WriteLine($"Brand: {alarm.Brand}");
        Console.WriteLine($"Size: {alarm.Size}");
        alarm.Temperature = 10;
    }
}
