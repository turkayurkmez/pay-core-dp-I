namespace OpenClosed
{
    //public enum CardType
    //{
    //    Standard,
    //    Silver,
    //    Gold,
    //    Premium

    //}

    public abstract class CardType
    {
        public abstract decimal GetDiscountedPrice(decimal price);

    }

    public class Standard : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .95m;
        }
    }

    public class Silver : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .9m;
        }
    }
    public class Gold : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .85m;
        }
    }

    public class Premium : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .8m;
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public CardType Card { get; set; }
    }
    public class OrderManager
    {
        public Customer Customer { get; set; }
        public decimal GetDiscountedPrice(decimal totalPrice)
        {
            //switch (Customer.Card)
            //{
            //    case CardType.Standard:
            //        return totalPrice * .95m;
            //    case CardType.Silver:
            //        return totalPrice * .90m;

            //    case CardType.Gold:
            //        return totalPrice * .85m;
            //    case CardType.Premium:
            //        return totalPrice * .8m;
            //    default:
            //        return totalPrice;
            //}
            return Customer.Card.GetDiscountedPrice(totalPrice);
        }
    }
}
