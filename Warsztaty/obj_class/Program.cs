// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var car = new Car();
car.Description = "This is skoda";
car.Id = 1;
car.Name = "Skoda";
car.Fuel = 0;
car.Color = "White";
car.Power = 60;
var electricCar = new Car()
{
    Color = "red",
    Fuel = null,
    Name = "Tesla",
    Id = 2,
    Description = "This is tesla",
    Power = 100
};

var list = new List<Car>()
{
    car,
    electricCar
};

Car newCar = CreateNewCar(CarTypeEnum.Oil, "blue", 22.22);

list.Add(newCar);

foreach (var item in list)
{
    Console.WriteLine($"{item.Name} ma moc {item.GetHorsPower()}");
    Console.WriteLine("Jedziemy na stacje");
    GoToGasSation(item);
    if (item.HasFueal() == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{item.Name} ma paliwo!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (item.HasFueal() == false)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{item.Name} nie ma paliwa!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"{item.Name} jest elektrykiem!");
        Console.ForegroundColor = ConsoleColor.White;
    }
}





void GoToGasSation(Car car)
{
    car.Fuel += 100;
}

Car CreateNewCar(CarTypeEnum carType, string color, double power)
{
    return new Car
    {
        CarType = carType,
        Power = power,
        Color = color,
        Fuel = 0,
        Id = new Random().Next(0, 100),
        Name = $"Car"
    };
}

List<Car> GetAllCars()
{
    return new List<Car>();
}


public class Car
{
    public Car()
    {
        this.Components.Add(new CarComponent()
        {
            Name = "Test",
            Value = 20
        });
        this.Components.Add(new CarComponent()
        {
            Name = "Test2",
            Value = 204
        });
        this.Components.Add(new CarComponent()
        {
            Name = "Test3",
            Value = 203
        });
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Color { get; set; }
    public double Power { get; set; }
    public int? Fuel { get; set; }
    public CarTypeEnum CarType { get; set; }
    public List<CarComponent> Components { get; set; } = new List<CarComponent>();

    public double GetHorsPower()
    {
        return this.Power * 1.24;
    }

    public bool? HasFueal()
    {
        if (this.Fuel.HasValue)
        {
            return this.Fuel.Value > 0;
        }
        return null;
    }
}

public class CarComponent
{
    public string Name { get; set; }
    public int Value { get; set; }
}

public enum CarTypeEnum
{
    Oil = 1,
    Electric = 2
}