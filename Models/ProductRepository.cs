using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace OPG.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category );
            }
        }

        public void AddCategory ()
        {
            throw new System.NotImplementedException ();
        }

        public void AddPrice ()
        {
            throw new System.NotImplementedException ();
        }

        public void AddProduct ()
        {
            throw new System.NotImplementedException ();
        }

        public Product GetProductByID ( int product_id )
        {
            return _appDbContext.Products.FirstOrDefault ( p => p.ProductId == product_id);
        }
    }
}
