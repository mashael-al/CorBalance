using Microsoft.AspNetCore.Mvc;

namespace CorBalance.Controllers
{
    public class NutritionController
    {
    }
}
public class NutritionController : Controller
{
    public IActionResult Index() => View();
}