using Microsoft.AspNetCore.Mvc;

namespace WebAppSecond.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
