
using Database;
using Database.Domain;
using Microsoft.EntityFrameworkCore;
using System.Globalization;


ShopContext db = new ShopContext();

var shop = db.Set<Shop>().First(x => x.Name == "Biedronka").Products.Sum(x => x.Price);
Console.WriteLine(shop);

var product = db.Set<Product>().First(x => x.Id == 7);
Console.WriteLine(product.Shop.Name);


void RunBasicLinq()
{

    ShopContext db = new ShopContext();
    var element = db.Set<Product>().Take(50);

    db.RemoveRange(element);
    db.SaveChanges();

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

}
