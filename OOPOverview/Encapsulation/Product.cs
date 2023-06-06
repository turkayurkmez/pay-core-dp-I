namespace Encapsulation
{
    public class Product
    {
        private decimal price;
        public void SetPrice(decimal value)
        {
            if (value < 0)
            {
                throw new Exception("Eksi olmaz");
            }
            this.price = value;
        }
        public decimal GetPrice()
        {
            return price;
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
