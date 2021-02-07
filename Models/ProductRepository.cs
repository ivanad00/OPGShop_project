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
        public Product GetProductByID ( int productId )
        {
            return _appDbContext.Products.FirstOrDefault ( p => p.ProductId == productId);
        }
    }
}
