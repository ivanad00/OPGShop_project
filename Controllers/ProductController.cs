using Microsoft.AspNetCore.Mvc;
using OPG.Models;
using System.Linq;

namespace OPG.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly AppDbContext _appDbContext;
            

        public ProductController(IProductRepository productRepository, AppDbContext appDbContext)
        {
            _productRepository = productRepository;
            _appDbContext = appDbContext;
        }

        public ViewResult List ()
        {
            //var results = _appDbContext.Product.ToList();
            return View (/*_productRepository.AllProducts*/);
        }
        public IActionResult Shop ()
        {
            /*var results = _appDbContext.Product
                .OrderBy(p=>p.Category )
                .ToList();
            return View (results.ToList());*/
            var results = _appDbContext.Product.ToList ();
            return View ( _productRepository.AllProducts );
        }
        /*public IActionResult Details(int id )
        {
            var product = _productRepository.GetProductByID ( id );
            if ( product == null )
                return NotFound ();
            return View ( product );
        }*/
    }
}
