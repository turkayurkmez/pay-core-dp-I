namespace Adapter
{
    public class Currency
    {
        public double Selling { get; set; }
        public double Buying { get; set; }

        public string FromProvider { get; set; }
    }

    public interface ICurrencyAdapter
    {
        public List<Currency> GetCurrencies();
    }
    public class XMLServiceProvider : ICurrencyAdapter
    {
        public List<Currency> GetCurrencies()
        {
            return new List<Currency> { new Currency { FromProvider = "XML döndüren API'den çekildi" } };
        }
    }

    public class JsonServiceProvider : ICurrencyAdapter
    {
        public List<Currency> GetCurrencies()
        {
            return new List<Currency> { new Currency { FromProvider = "JSON döndüren API'den çekildi" } };
        }
    }

    public class CurrencyAdaptee
    {
        public List<Currency> GetCurrencies(ICurrencyAdapter currencyAdapter)
        {
            return currencyAdapter.GetCurrencies();
        }
    }

}
