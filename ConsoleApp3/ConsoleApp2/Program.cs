

// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine("Hello, World!");

int x = 0;

//////////// PERSON ///////////
Person szymon = new Person(75, 190);
szymon.age = 27;
szymon.name = "Szymon";

double szymonBMI = szymon.GetBMI();
Console.WriteLine(szymonBMI);
szymon.ShowAll();
//////////// PERSON ///////////


//////// DOG ////////////
Dog azor = new Dog();
azor.Age = 27;

Console.WriteLine(azor.Name);
azor.SetName("Kubuś");
Console.WriteLine(azor.Name);

//////// DOG ////////////