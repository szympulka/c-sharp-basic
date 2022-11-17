
using Database;
using Database.Domain;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

ShopContext db = new ShopContext();
var element = db.Set<Product>().Take(50);

db.RemoveRange(element);
db.SaveChanges();

public class Item
{
    public int Id { get; set; }
    public double Price { get; set; }
}


//var prod = new Product()
//{
//    Code = "asdfasdf",
//    Name = "Test",
//    Price = 2.2,
//};
//var prod2 = new Product()
//{
//    Code = "asdfasdf",
//    Name = "Test",
//    Price = 2.2,
//};
//Console.WriteLine(prod.Id);

//db.Add(prod);
//db.Add(prod2);

//db.SaveChanges();

//Console.WriteLine(prod.Id);
