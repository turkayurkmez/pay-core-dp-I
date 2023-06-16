namespace Command
{
    public interface ICommand
    {
        void Execute();
    }
    public class CreateCustomerCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Db'de Müşteri oluşturuldu");
        }
    }

    public class CreateOrderAndUpdateStockCommand : ICommand
    {
        private DBCommandReceiver receiver;
        private string customer;
        private string products;

        public CreateOrderAndUpdateStockCommand(DBCommandReceiver receiver, string customer, string products)
        {
            this.receiver = receiver;
            this.customer = customer;
            this.products = products;
        }

        public void Execute()
        {
            receiver.CreateNewOrder(customer);
            receiver.UpdateStock(products);
        }
    }

    public class DBCommandReceiver
    {
        public void CreateNewOrder(string customer)
        {
            Console.WriteLine($"{customer}, yeni bir sipariş oluşturdu.");
        }

        public void UpdateStock(string products)
        {
            Console.WriteLine("ürünlerin stoğu güncellendi");
        }
    }

    public class CommandInvoker
    {

        /*
         * Komut geçmişi izlenebilir. Birim zamanda benchmark yapılabilir. 
         */
        private List<ICommand> commands = new List<ICommand>();
        public void AddCommand(ICommand command) => commands.Add(command);
        public void RemoveCommand(ICommand command) => commands.Remove(command);

        public void Clear() => commands.Clear();

        public void ExecuteAll()
        {
            commands.ForEach(command => command.Execute());
            commands.Clear();
        }
    }
}
