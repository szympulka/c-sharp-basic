// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var list2 = new List<double>();

for (double i = 0; i < 10; i++)
{
    list2.Add(i * 2.56 / 5 + 9 - (33 * 0.2));
}

list2.Add(2323.23);
//for (int i = 0; i < list2.Count(); i++)
//{
//    Console.WriteLine(list2[i]);
//}

foreach (var item in list2)
{
    Console.WriteLine(item);
}
