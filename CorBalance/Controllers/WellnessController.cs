using Microsoft.AspNetCore.Mvc;

namespace CorBalance.Controllers
{
    public class WellnessController
    {
    }
}
public class WellnessController : Controller
{
    public IActionResult Index() => View();
}