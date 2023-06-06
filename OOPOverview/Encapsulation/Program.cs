// See https://aka.ms/new-console-template for more information

using Encapsulation;

Product p1 = new Product();
//decimal value = -5;
//if (value<0)
//{

//}

p1.SetPrice(10);

Console.WriteLine($"Ürünün fiyatı: {p1.GetPrice()}");
p1.Name = "Gözlük";
Console.WriteLine(p1.Name);
p1.Stock = 1000;
Console.WriteLine(p1.Stock);
