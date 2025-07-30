using Microsoft.AspNetCore.Mvc;

namespace CorBalance.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}