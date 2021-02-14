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
            _appDbContext.OrderForms.Add ( orderForm );

            var orderItems = _order.OrderItems;

            foreach (var orderItem in orderItems )
            {
                var orderFormDetail = new OrderFormDetail ()
                {
                    Amount = orderItem.Amount,
                    ProductId = orderItem.Product.ProductId,
                    OrderFormId = orderForm.OrderFormId,
                    Price = orderItem.Product.Price
                };
                _appDbContext.OrderFormDetails.Add(orderFormDetail);
            }
        _appDbContext.SaveChanges();
        }
    }
}