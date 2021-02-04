using Microsoft.AspNetCore.Mvc;
using OPG.Models;
using OPG.ViewModels;
using System.Linq;

namespace OPG.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly Order _order;

        public OrderController ( IProductRepository productRepository, Order order )
        {
            _productRepository = productRepository;
            _order = order;
        }

        public ViewResult Cart ()
        {
            var items = _order.GetOrderItems ();
            _order.OrderProducts = items;

            var shoppingCartViewModel = new OrderViewModel
            {
                Order = _order,
                OrderTotal = _order.GetOrderTotal ()
            };

            return View ( shoppingCartViewModel );
        }

        public RedirectToActionResult AddToOrder ( int productId )
        {
            var selectedProduct = _productRepository.AllProducts.FirstOrDefault ( p => p.ProductId == productId );

            if ( selectedProduct != null )
            {
                _order.AddToOrder ( selectedProduct, 1 );
            }
            return RedirectToAction ( "Cart" );
        }

        public RedirectToActionResult RemoveFromOrder ( int productId )
        {
            var selectedProduct = _productRepository.AllProducts.FirstOrDefault ( p => p.ProductId == productId );

            if ( selectedProduct != null )
            {
                _order.RemoveFromOrder ( selectedProduct );
            }
            return RedirectToAction ( "Index" );
        }
    }
    
}
