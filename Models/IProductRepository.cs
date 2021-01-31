using System.Collections.Generic;


namespace OPG.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        Product GetProductByID(int product_id);
    }
}
