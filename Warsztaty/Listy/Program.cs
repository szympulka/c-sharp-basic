// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var list2 = new List<double>();


for (double i = 0; i < 10; i++)
{
    var random = new Random();
    list2.Add(random.Next(-100, 100));
}

//foreach (var item in list2)
//{
//    Console.WriteLine(item);
//}

var rand = new Random();
Console.WriteLine(rand.Next(2, 2));
