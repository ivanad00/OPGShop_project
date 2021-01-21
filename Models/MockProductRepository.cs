using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly IProductRepository _productRepository = new MockProductRepository() ;

        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product{Product_ID=1,User_ID=2,Category_ID=3,Product_Description="voce", Discount=0},
                new Product{Product_ID=3,User_ID=5,Category_ID=3,Product_Description="voce", Discount=0}

            };

        public Product GetProductByID(int Product_Id)
        {
            return AllProducts.FirstOrDefault(p => p.Product_ID == Product_Id);
        }
    }
}
