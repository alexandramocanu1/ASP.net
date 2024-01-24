using Microsoft.AspNetCore.Mvc;

namespace Planner.Controllers
{
    public class AccomodationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
