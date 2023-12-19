using Microsoft.AspNetCore.Mvc;
using StoreProject.Dal.Context;
using StoreProject.Entities.Models;
using StoreProject.Services.Abstract;

namespace StoreProject.App.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService=productService;
        }
        public IActionResult Index()
        {
            var product = _productService.GetAllProducts(false);
            
            return View(product);
        }
    }
}
