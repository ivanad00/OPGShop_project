using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace OPG.Models
{
    public class Order
    {
        private readonly AppDbContext _appDbContext;
        public string OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        private Order ( AppDbContext appDbContext )
        {
            _appDbContext = appDbContext;

        }
        public static Order GetOrder ( IServiceProvider services )
        {
            ISession session = services.GetService<IHttpContextAccessor> ()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext> ();

            string orderId = session.GetString ( "OrderId" ) ?? Guid.NewGuid ().ToString ();

            session.SetString ( "OrderId", orderId );
            return new Order ( context ) { OrderId = orderId };

        }
        public void AddToOrder ( Product product, int amount )
        {
            var orderItem =
                _appDbContext.OrderItems.SingleOrDefault (
                    s => s.Product.ProductId == product.ProductId && s.OrderId == OrderId );

            if ( orderItem == null )
            {
                orderItem = new OrderItem
                {
                    OrderId = OrderId,
                    Product = product,
                    Amount = 1
                };

                _appDbContext.OrderItems.Add( orderItem );
            }
            else
            {
                orderItem.Amount++;
            }
            _appDbContext.SaveChanges ();
        }
        public int RemoveFromOrder ( Product product )
        {
            var orderItem =
                    _appDbContext.OrderItems.SingleOrDefault (
                        s => s.Product.ProductId == product.ProductId && s.OrderId == OrderId );

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
                    _appDbContext.OrderItems.Remove ( orderItem );
                }
            }

            _appDbContext.SaveChanges ();

            return localAmount;
        }

        public List<OrderItem> GetOrderItems ()
        {
            return OrderItems ??
                   (OrderItems =
                       _appDbContext.OrderItems.Where ( c => c.OrderId == OrderId )
                           .Include ( s => s.Product )
                           .ToList ());
        }

        public void ClearOrder ()
        {
            var orderItems = _appDbContext
                .OrderItems
                .Where ( order => order.OrderId == OrderId );

            _appDbContext.OrderItems.RemoveRange ( orderItems );

            _appDbContext.SaveChanges ();
        }

        public decimal GetOrderTotal ()
        {
            var total = _appDbContext.OrderItems.Where ( c => c.OrderId == OrderId )
                .Select ( c => c.Product.Price * c.Amount ).Sum ();
            return total;
        }


    }
}