// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 0;

Person szymon = new Person();
szymon.age = 27;
szymon.name = "Szymon";
szymon.height = 190;
szymon.weight = 75;

double szymonBMI = szymon.GetBMI();
Console.WriteLine(szymonBMI);
szymon.ShowAll();

public class Person
{
    public string name;
    public int age;
    public double weight;
    public double height;

    public double GetBMI()
    {
        double bmi = weight / height;
        return bmi;
    }
    public void ShowAll()
    {
        Console.WriteLine($"{name} ma {age} lat i jego bmi to {GetBMI()}");
    }
}