namespace Facade
{
    /*
     * Problem:
     *   Gerçekleşmesi için çok karmaşık adımların atıldığı bir operasyonu, istemciye basit bir metotla aktarmak istersek nasıl ilerlememiz gerekir?
     */

    public class Customer
    {
        public string Name { get; set; }
    }

    public class OrderLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

    }

    public class Order
    {
        public Customer Customer { get; set; }
        public List<OrderLine> OrderItems { get; set; }
    }

    public class OrderService
    {
        public int AddOrder(Customer customer, DateTime dateTime)
        {
            Console.WriteLine($"{customer.Name}, {dateTime.ToLongDateString()} tarihinde sipariş verdi");
            return 1;
        }
    }

    public class OrderDetailService
    {
        public void AddOrderDetails(int orderId, List<OrderLine> orderLines)
        {
            Console.WriteLine($"{orderId} numaralı siparişte satın alınan ürünler");
            orderLines.ForEach(o => Console.WriteLine($"{o.Name} ürününden {o.Quantity} adet aldındı"));

        }
    }

    public class ProductService
    {
        public void UpdateStock(List<OrderLine> orderLines)
        {
            orderLines.ForEach(o => Console.WriteLine($"{o.Name} ürününün stoğundan {o.Quantity} adet düşüldü"));
        }
    }

    public class OrderFacade
    {
        OrderService orderService = new OrderService();
        OrderDetailService orderDetailService = new OrderDetailService();
        ProductService productService = new ProductService();

        public void CreateOrder(Customer customer, List<OrderLine> orderLines)
        {
            var orderId = orderService.AddOrder(customer, DateTime.Now);
            orderDetailService.AddOrderDetails(orderId, orderLines);
            productService.UpdateStock(orderLines);

        }
    }
}
