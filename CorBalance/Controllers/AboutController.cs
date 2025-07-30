using Microsoft.AspNetCore.Mvc;

namespace CorBalance.Controllers
{
    public class AboutController
    {
    }
}
public class AboutController : Controller
{
    public IActionResult Index() => View();
}