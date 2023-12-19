using Microsoft.AspNetCore.Mvc;

namespace StoreProject.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
