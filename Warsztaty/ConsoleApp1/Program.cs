
#region Without array
using ConsoleApp2;

Console.WriteLine("Pierwszy przypadek");
int sum = 0;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Podaj liczbę");
    sum += int.Parse(Console.ReadLine());
}
Console.WriteLine($"suma wynosi {sum}");

#endregion
Console.ReadLine();

#region With array and index
Console.WriteLine("Drugi przypadek");
int[] array = new int[10];
Console.WriteLine("Podaj liczbę");
array[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbę");
array[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbę");
array[2] = int.Parse(Console.ReadLine());

var sum2 = 0;
for (int i = 0; i < 3; i++)
{
    sum2 += array[i];
}
Console.WriteLine($"suma wynosi {sum2}");
Console.ReadLine();
#endregion

#region With array and dynamic index
Console.WriteLine("Trzeci przypadek");
Console.WriteLine("Podaj wielkość tablicy");

int index = int.Parse(Console.ReadLine());

int[] array2 = new int[index];
for (int i = 0; i < index; i++)
{
    Console.WriteLine("Podaj liczbę");
    array2[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"suma wynosi {array2.Sum()}");
Console.ReadLine();
#endregion

