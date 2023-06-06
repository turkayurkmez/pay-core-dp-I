namespace SingleResponsibility
{
    public class ProductService
    {
        public int AddProduct(string name, decimal price)
        {
            DbOperations dbOperations = new DbOperations("");
            Dictionary<string, object> commandParameters = new Dictionary<string, object>();
            commandParameters.Add("@p1", name);
            commandParameters.Add("@p2", price);

            var affectedRows = dbOperations.ExecuteCommand("SORGU", commandParameters);

            return affectedRows;
        }
    }
}
