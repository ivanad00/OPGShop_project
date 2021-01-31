using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace OPG.Models
{
    public class OrderProductRepository : IOrderProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public OrderProductRepository (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        private object result;

        public void AddProduct ( Product p )
        {
            _appDbContext.Product.Add ( p );
            _appDbContext.SaveChanges ();
        }

        public void CalculatePrice ( int Price )
        {

        }
        public Product FindById ( int product_id )
        {
            result = (from r in _appDbContext.Product where r.ProductId == product_id select r).FirstOrDefault ();
            return (Product) result;
        }

        public void RemoveProduct ( int ProductId )
        {
            Product p = _appDbContext.Product.Find ( ProductId );
            _appDbContext.Product.Remove ( p );
            _appDbContext.SaveChanges ();
        }
    }
}
