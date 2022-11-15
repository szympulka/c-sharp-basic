// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 0;

Person szymon = new Person(75, 190);
szymon.age = 27;
szymon.name = "Szymon";

double szymonBMI = szymon.GetBMI();
Console.WriteLine(szymonBMI);
szymon.ShowAll();

public class Person
{
    public string name;
    public int age;
    private double weight;
    private double height;

    public Person(double weightComing, double heightComing)
    {
        weight = weightComing;
        height = heightComing;
    }
    public Person()
    {

    }

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