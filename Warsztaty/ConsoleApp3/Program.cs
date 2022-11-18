// See https://aka.ms/new-console-template for more information


Console.WriteLine("Podaj prosze pierwsza liczbe:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj prosze drugą liczbe:");
int secNumber = int.Parse(Console.ReadLine());

CheckNumbers(firstNumber, secNumber);
Console.WriteLine("Zakres:");
DisplayRange(firstNumber, secNumber);
Console.WriteLine("Liczby niep");
DisplayOdd(firstNumber, secNumber);

Console.ReadLine();

void CheckNumbers(int first, int second)
{
    if (first >= secNumber)
    {
        Console.WriteLine($"więszka jest {first}");
    }
    else
    {
        Console.WriteLine($"więszka jest {second}");
    }
}

void DisplayRange(int first, int second)
{
    if (first <= second)
    {
        int x = first;
        first = second;
        second = x;
    }

    for (int i = first; i >= second; i--)
    {
        Console.WriteLine(i);
    }
}

void DisplayOdd(int first, int second)
{
    if (first <= second)
    {
        int x = first;
        first = second;
        second = x;
    }

    for (int i = first; i >= second; i--)
    {
        if (i % 2 == 1)
            Console.WriteLine(i);
    }
}