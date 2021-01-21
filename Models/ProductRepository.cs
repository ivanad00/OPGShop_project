using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Product GetProductByID ( int Product_id )
        {
            return _appDbContext.Products.FirstOrDefault ( p => p.product_id == Product_id);
        }
    }
}
