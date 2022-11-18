// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var list = new List<(string name, int time)>()
{
    ("Item1",800),
    ("Item2",700),
    ("Item3",10),
    ("Item4",11),
    ("Item5",20),
    ("Item6",600),
    ("Item7",500),
    ("Item8",200),
    ("Item9",5500),
    ("Item10",3300),
    ("Item11",1200),
    ("Item12",200),
    ("Item13",200),
    ("Item14",1200),
    ("Item15",20),
    ("Item16",200),
    ("Item17",2200),
    ("Item18",400),
    ("Item19",200)
};

var asd = list.OrderByDescending(x => x.time);

await Parallel.ForEachAsync(asd, async (item, cancellationToken) =>
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"I am {item.name} and i will wait {item.time} ms");
    await Task.Delay(item.time);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Done {item.name}");
    Console.ForegroundColor = ConsoleColor.Blue;
});



//Task.WaitAll(Method1Asnyc(), Method2Asnyc());
//Console.WriteLine("Done");

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
        for (int i = 0; i < 50; i++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Method 2");
            Task.Delay(i * 10).Wait();
        }
    });
}