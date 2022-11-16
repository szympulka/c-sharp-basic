// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Task.WaitAll(Method1Asnyc(), Method2Asnyc());
Console.WriteLine("Done");

async Task Method1Asnyc()
{
    await Task.Run(() =>
    {
        for (int i = 0; i < 10; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Method 1");
            Task.Delay(i * 100).Wait();
        }
    });
}

async Task Method2Asnyc()
{
    await Task.Run(() =>
    {
        for (int i = 0; i < 5000; i++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Method 2");
            Task.Delay(i * 10).Wait();
        }
    });
}