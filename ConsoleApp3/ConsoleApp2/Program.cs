

// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine("Hello, World!");

var x = 0;

//////////// PERSON ///////////
var szymon = new Person(75, 190);
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

//////// DOG ////////////
///


// VAR //
double height = 190;
double width = 75;

Console.WriteLine(height / width);

var height2 = 190.0;
var width2 = 75.0;
Console.WriteLine(height2 / width2);

// VAR //