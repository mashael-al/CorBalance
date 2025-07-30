using Microsoft.AspNetCore.Mvc;

namespace CorBalance.Controllers
{
    public class ChallengesController
    {
    }
}
public class ChallengesController : Controller
{
    public IActionResult Index() => View();
}