using Microsoft.AspNetCore.Mvc;

namespace CorBalance.Controllers
{
    public class FitnessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
