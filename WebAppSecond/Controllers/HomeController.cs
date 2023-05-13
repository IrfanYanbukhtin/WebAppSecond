using Microsoft.AspNetCore.Mvc;

namespace WebAppSecond.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
