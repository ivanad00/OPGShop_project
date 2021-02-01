using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;




namespace OPG.Models
{
    public class Order
    {
        private readonly AppDbContext _appDbContext;
        public string OrderId { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

        private Order (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public static Order GetOrder(IServiceProvider services )
        {
            ISession session = services.GetService<IHttpContextAccessor> ()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext> ();

            string order_id = session.GetString ( "OrderId" ) ?? Guid.NewGuid ().ToString ();

            session.SetString ( "order_id", order_id );
            return new Order ( context ) { OrderId = order_id };

        }
        public void AddToOrder ( Product product, int amount )
        {
            var orderItem =
                _appDbContext.OrderProduct.SingleOrDefault (
                    o => o.Product.ProductId == product.ProductId && o.OrderId == OrderId );

            if ( orderItem == null )
            {
                orderItem = new OrderProduct
                {
                    OrderId = OrderId,
                    Product = product,
                    Amount = 1
                };

                _appDbContext.OrderProduct.Add ( orderItem );
            }
            else
            {
                orderItem.Amount++;
            }
            _appDbContext.SaveChanges ();
        }
        public int RemoveFromOrder( Product product )
        {
            var orderItem =
                    _appDbContext.OrderProduct.SingleOrDefault (
                        o => o.Product.ProductId == product.ProductId && o.OrderId == OrderId );

            var localAmount = 0;

            if ( orderItem != null )
            {
                if ( orderItem.Amount > 1 )
                {
                    orderItem.Amount--;
                    localAmount = orderItem.Amount;
                }
                else
                {
                    _appDbContext.OrderProduct.Remove ( orderItem );
                }
            }

            _appDbContext.SaveChanges ();

            return localAmount;
        }

        public List<OrderProduct> GetOrderItems ()
        {
            return OrderProducts ??
                   (OrderProducts =
                       _appDbContext.OrderProduct.Where ( c => c.OrderId == OrderId )
                           .Include ( s => s.Product )
                           .ToList ());
        }

        public void ClearOrder ()
        {
            var orderItems = _appDbContext
                .OrderProduct
                .Where ( order => order.OrderId == OrderId );

            _appDbContext.OrderProduct.RemoveRange ( orderItems );

            _appDbContext.SaveChanges ();
        }

        public decimal GetOrderTotal ()
        {
            var total = _appDbContext.OrderProduct.Where ( c => c.OrderId == OrderId )
                .Select ( c => c.Product.Price * c.Amount ).Sum ();
            return total;
        }
    }
}