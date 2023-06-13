// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");
Customer customer = new Customer { Name = "Türkay" };
List<OrderLine> orders = new List<OrderLine>()
{
    new(){ Name="Şapka", Quantity=5},
    new(){ Name="Eldiven", Quantity=2},

};

OrderFacade orderFacade = new OrderFacade();
orderFacade.CreateOrder(customer, orders);