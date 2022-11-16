// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var adam = new Person<Human>();
Person<double> szymon = new Person<double>();

adam.Name = "Adam";

szymon.Name = "szymon";
szymon.Value = 20.22;
szymon.Values = new List<double>
{
    26.22,
    25.22,
    24.22,
    23.22
};

Console.WriteLine(MyEnum.D);

public class Person<T>
{
    public string Name { get; set; }
    public T Value { get; set; }

    public List<T> Values { get; set; }

    public void Test()
    {
        Console.WriteLine("Test");
    }

    public T Test2()
    {
        return Value;
    }
}

public class Human
{

}

public enum MyEnum
{
    A = 0,
    B = 1,
    C = 2,
    D = 10,
}