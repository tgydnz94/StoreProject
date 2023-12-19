using Microsoft.AspNetCore.Mvc;

namespace StoreProject.App.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
