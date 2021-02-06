using Microsoft.AspNetCore.Mvc;
using OPG.Models;
using OPG.ViewModels;

namespace OPG.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly AppDbContext _appDbContext;


        public ProductController ( IProductRepository productRepository, AppDbContext appDbContext )
        {
            _productRepository = productRepository;
            _appDbContext = appDbContext;
        }
        public IActionResult Shop ()
        {
            ShopViewModel productsShopViewModel = new ShopViewModel ();
            productsShopViewModel.Product = _productRepository.AllProducts;
            return View ( productsShopViewModel);
        }
        public IActionResult Details (int id)
        {
            var product = _productRepository.GetProductByID ( id );
            if ( product == null )
                return NotFound("Product does not exist.");
            return View ( product );
        }
    }
}