using Microsoft.AspNetCore.Mvc;

namespace CorBalance.Controllers
{
    public class CommunityController
    {
    }
}
public class CommunityController : Controller
{
    public IActionResult Index() => View();
}