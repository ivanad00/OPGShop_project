using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OPG.Models;

namespace OPG.Controllers
{
    //[Authorize]
    public class OrderFormController: Controller
    {
        private readonly IOrderFormRepository _orderFormRepository;
        private readonly Order _order;

        public OrderFormController (IOrderFormRepository orderFormRepository, Order order)
        {
            _orderFormRepository = orderFormRepository;
            _order = order;
        }

        public IActionResult Checkout ()
        {
            return View ();
        }
        [HttpPost]
        public IActionResult Checkout (OrderForm orderForm)
        {
            var items = _order.GetOrderItems ();
            _order.OrderItems = items;

            if ( _order.OrderItems.Count == 0 )
            {
                ModelState.AddModelError ( "", "Your cart is empty, add some products first" );
            }
            if ( ModelState.IsValid )
            {
                _orderFormRepository.CreateOrderForm ( orderForm );
                _order.ClearOrder ();
                return RedirectToAction ( "CheckoutComplete" );
            }
            return View ( orderForm );
        }
        public IActionResult CheckoutComplete ()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order.";
            return View ();
        }
    }
}
