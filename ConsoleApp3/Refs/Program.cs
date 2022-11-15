// See https://aka.ms/new-console-template for more information
using Refs;

Console.WriteLine("Hello, World!");

int x = 5;
Console.WriteLine(x);
Console.WriteLine("Wysyłamy kopię do funkcji");
var newValue = Incremnt(x);
Console.WriteLine(newValue);

int Incremnt(int x)
{
    return x += 5;
}


string text = "5fd";

bool isGood = int.TryParse(text, out int parseValue);
if (isGood == true)
{
    Console.WriteLine("Działa!");
}
else
{
    Console.WriteLine("Nie działa!");
}


StaticClass.Test();
Console.WriteLine();


var date = DateTime.UtcNow; // Czas podany w utc
var polandTime = date.PolandTime(); // Wywołanie Extension Metody
var polandTime2 = date.PolandTime(5); // Wywołanie Extension Metody
Console.WriteLine(polandTime);
Console.WriteLine(polandTime2);

Console.WriteLine(polandTime.ToString("MM/dd.yyy HH:mm:ss:ff"));
