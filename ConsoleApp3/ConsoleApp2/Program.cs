

// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine("Hello, World!");

int x = 0;

Person szymon = new Person(75, 190);
szymon.age = 27;
szymon.name = "Szymon";

double szymonBMI = szymon.GetBMI();
Console.WriteLine(szymonBMI);
szymon.ShowAll();
