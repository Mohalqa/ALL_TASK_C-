using System;

public class Vehicle
{
    protected string make;
    protected int year;
    protected string type;

    public Vehicle(string make, int year, string type)
    {
        this.make = make;
        this.year = year;
        this.type = type;
    }

    public void Move()
    {
        Console.WriteLine($"{type} {make} is moving.");
    }
}

public class Car : Vehicle
{
    private decimal price;
    private string model;
    private string palletNumber;
    private string color;

    public Car(string make, int year, string type, decimal price, string model, string palletNumber, string color)
        : base(make, year, type)
    {
        this.price = price;
        this.model = model;
        this.palletNumber = palletNumber;
        this.color = color;
    }

    public void StartEngine()
    {
        Console.WriteLine($"Starting the engine of {make} {model}...");
    }

    public void StopEngine()
    {
        Console.WriteLine($"Stopping the engine of {make} {model}...");
    }

    public string GetCarInfo()
    {
        return $"Car: {year} {make} {model}, Type: {type}, Color: {color}, Price: {price:C}, Pallet No: {palletNumber}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", 2023, "Sedan", 25000.50m, "Camry", "PAL1234", "Blue");

        myCar.StartEngine();
        Console.WriteLine(myCar.GetCarInfo());
        myCar.StopEngine();

        myCar.Move();
    }
}
