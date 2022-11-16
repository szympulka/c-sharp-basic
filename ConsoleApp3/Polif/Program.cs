// See https://aka.ms/new-console-template for more information
using Polif;

Console.WriteLine("Hello, World!");

var animal = new Animal();
var dog = new Dog();
var cat = new Cat();

Console.WriteLine($"{dog.Name} {dog.GetVoice()}");


cat.Name = "Filemon";
dog.Name = "Reksio";
animal.Name = "Jestem Animal";

Console.WriteLine($"{cat.Name} {cat.GetVoice()}");
Console.WriteLine($"{dog.Name} {dog.GetVoice()}");
Console.WriteLine($"{animal.Name} {animal.GetVoice()}");