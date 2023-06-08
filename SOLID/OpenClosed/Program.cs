// See https://aka.ms/new-console-template for more information

using OpenClosed;

Customer customer = new Customer() { Name = "Türkay", Card = new Premium() };
OrderManager orderManager = new OrderManager { Customer = customer };

var price = orderManager.GetDiscountedPrice(1000);
Console.WriteLine(price);


Console.WriteLine("Hello, World!");
// Bir nesne gelişime AÇIK değişime KAPALI

