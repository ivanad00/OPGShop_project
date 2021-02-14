using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class OrderFormRepository : IOrderFormRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly Order _order;
        
        public OrderFormRepository ( AppDbContext appDbContext, Order order )
        {
            _appDbContext = appDbContext;
            _order = order;
        }
        public void CreateOrderForm ( OrderForm orderForm )
        {
            orderForm.OrderPlaced = DateTime.Now;

            var orderItems = _order.OrderItems;
            orderForm.OrderTotal = _order.GetOrderTotal ();

            orderForm.OrderFormDetails = new List<OrderFormDetail> ();
          
            foreach (var orderItem in orderItems )
            {
                var orderFormDetail = new OrderFormDetail ()
                {
                    Amount = orderItem.Amount,
                    ProductId = orderItem.Product.ProductId,
                    Price = orderItem.Product.Price
                };
                orderForm.OrderFormDetails.Add ( orderFormDetail );
            }
            _appDbContext.OrderForms.Add ( orderForm );
        _appDbContext.SaveChanges();
        }
    }
}