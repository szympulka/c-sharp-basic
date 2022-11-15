// See https://aka.ms/new-console-template for more information
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
