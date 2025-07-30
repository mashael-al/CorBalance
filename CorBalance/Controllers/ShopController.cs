using Microsoft.AspNetCore.Mvc;

namespace CorBalance.Controllers
{
    public class ShopController
    {
    }
}
public class ShopController : Controller
{
    public IActionResult Index() => View();
}