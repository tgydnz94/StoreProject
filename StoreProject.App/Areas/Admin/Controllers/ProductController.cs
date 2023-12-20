using Microsoft.AspNetCore.Mvc;

namespace StoreProject.App.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
