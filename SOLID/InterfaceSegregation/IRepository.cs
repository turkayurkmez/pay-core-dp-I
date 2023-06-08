namespace InterfaceSegregation
{

    //ISP diyor ki: Bir sınıf, bir interface'i implemente etmiş ise her fonksiyonu icra etmek zorundadır.
    public interface IRepository<T>
    {


        T Get(int id);
        IList<T> GetAll();
        int Create(T entity);
        int Update(T entity);
        bool Delete(int id);

        // IList<T> SearchEntityByName(string name);

    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Comment
    {
        public string CommentBody { get; set; }
    }


    public interface IProductRepository : IRepository<Product>
    {
        IList<Product> SearchProductsByName(string name);
    }

    public class ProductRepository : IProductRepository
    {
        public int Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Product> SearchProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public int Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    public interface ICommentRepository : IRepository<Comment>
    {

    }

    public class CommentRepository : ICommentRepository
    {
        public int Create(Comment entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
