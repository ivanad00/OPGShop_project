using Microsoft.AspNetCore.Mvc;
using OPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public ViewResult List()
        {
            //var results = _appDbContext.Products.ToList();
            return View(/*productRepository.AllProducts*/);
        }
    }
}
