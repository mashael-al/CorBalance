using Microsoft.AspNetCore.Mvc;

namespace CorBalance.Controllers
{
    public class ContactController
    {
    }
}
public class ContactController : Controller
{
    public IActionResult Index() => View();
}