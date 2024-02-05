using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Planner.Controllers
{
    [Authorize]
    public class AccomodationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
